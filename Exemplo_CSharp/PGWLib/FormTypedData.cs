using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PGWLib.CustomObjects;
using static PGWLib.Enums;

namespace PGWLib
{
    public partial class FormTypedData : MetroForm
    {
        private bool _userAborted = false;
        private PW_GetData _expectedData;
        private static Timer _timer = new Timer();
        private bool _twoTimesValid;
        private string _firstString;

        public FormTypedData(PW_GetData expectedData)
        {
            InitializeComponent();
            this.TopMost = true;
            // Inicializa membros utilizados para validação de digitação dupla
            _twoTimesValid = false;
            _firstString = null;

            _timer.Interval = 4000;
            _timer.Tick += TimerTick;
            _timer.Start();

            _expectedData = expectedData;

            // Caso seja necessário capturar uma das senhas, atribui as caracteristicas
            // de captura de validação de usuário da automação
            // Caso a autenticação da automação seja feita pelo próprio sistema operacional,
            // ou de alguma outra forma, basta adiciona o identificador PWINFO_AUTHMNGTUSER
            // ou o PWINFO_AUTHTECHUSER, de acordo com o nível de permissão do usuário autenticado,
            // contendo a identificação do usuário autenticado, isso fará com que esse usuário
            // seja considerado e a biblioteca não solicite essa autenticação
            // *** IMPORTANTE: O valor adicionado na biblioteca deve ser o identificador do 
            // *** usuário autenticado e não a senha que ele utilizou para se autenticar.
            if (expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHMNGTUSER)
            {
                // Exemplificando a captura de uma senha de lojista de até 4 dígitos
                expectedData.szPrompt = "Insira a Senha do Lojista";
                expectedData.bTamanhoMaximo = 4;
            }
            if (expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHTECHUSER)
            {
                // Exemplificando a captura de uma senha de lojista de até 10 dígitos
                expectedData.szPrompt = "Insira a Senha Técnica";
                expectedData.bTamanhoMaximo = 10;
            }

            // Casp seja uma das senhas ou a biblioteca tenha solicitado que o dado
            // seja capturado de forma mascarada
            if (expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHMNGTUSER ||
                expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHTECHUSER ||
                expectedData.bOcultarDadosDigitados == 1)
                txtValue.PasswordChar = '*';

            // Define se o preenchimento deve ser feito da direita pra esquerda (um valor
            // em dinheiro, por exemplo)
            // if (expectedData.bIniciaPelaEsquerda != 1)
            //     txtValue.RightToLeft = RightToLeft.Yes;

            // Define o tamanho máximo do dado a ser capturado
            //if (expectedData.bTamanhoMaximo > 0)
            //    txtValue.MaxLength = expectedData.bTamanhoMaximo;

            // Se não existir mascara de captura, cria uma padrão baseado no tamanho máximo
            if (expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHTECHUSER ||
                expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHMNGTUSER ||
                expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_DESTTCPIP ||
                expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_POSID)
            {
                expectedData.szMascaraDeCaptura = "";
            }
            else if (expectedData.szMascaraDeCaptura == "")
            {
                expectedData.szMascaraDeCaptura = new string('@', expectedData.bTamanhoMaximo);
            }
            else
            {
                // Ajuste necessário para exibição da moeda
                if (expectedData.szMascaraDeCaptura.Contains("R$"))
                {
                    expectedData.szMascaraDeCaptura = expectedData.szMascaraDeCaptura.Replace("R$", "");
                    lblCurrency.Text = "R$";
                }
            }

            // Restringe as entradas de dados de acordo com o sinalizado pela biblioteca
            switch (expectedData.bTiposEntradaPermitidos)
            {
                case ((byte)E_PWTypeInput.TYPED_NUMERIC):
                    txtValue.Mask = expectedData.szMascaraDeCaptura.Replace("@", "0");
                    break;
                case ((byte)E_PWTypeInput.TYPED_ALPHA):
                    txtValue.Mask = expectedData.szMascaraDeCaptura.Replace("@", "L");
                    break;
                case ((byte)E_PWTypeInput.TYPED_ALPHANUMERIC):
                    txtValue.Mask = expectedData.szMascaraDeCaptura.Replace("@", "a");
                    break;
                case ((byte)E_PWTypeInput.TYPED_ALPHANUMERICSP):
                default:
                    txtValue.Mask = expectedData.szMascaraDeCaptura.Replace("@", "C");
                    break;
            }


            // Valor inicial informado pelo servidor. Pode ser alterado pelo usuário.
            if (!string.IsNullOrEmpty(expectedData.szValorInicial.Trim()))
                txtValue.Text = expectedData.szValorInicial;

            // Atribui o valor do prompt a ser exibido, substituindo a quebra de linha utilizada
            // pela biblioteca pela quebra de linha utilizada nos forms
            LblHeader.Text = expectedData.szPrompt.Replace("\r", "\n");
        }

        private static bool isCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool mode10(string entrada)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            entrada = entrada.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (entrada.Length != 14)
                return false;

            string tempCnpj = entrada.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return entrada.EndsWith(digito);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime data;

            // Validação de tamanho mínimo
            if (_expectedData.bTamanhoMinimo > 0 && txtValue.Text.Length < _expectedData.bTamanhoMinimo)
            {
                Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", string.Format("Você deve inserir ao menos {0} caracteres", _expectedData.bTamanhoMinimo), "yellow", false, false);
                return;
            }

            // Validação de valor mínimo
            if (_expectedData.ulValorMinimo > 0 && int.Parse(txtValue.Text) < _expectedData.ulValorMinimo)
            {
                Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgDadoMenor, "blue", false, false);
                return;
            }

            // Validação de valor máximo
            if (_expectedData.ulValorMaximo > 0 && int.Parse(txtValue.Text) > _expectedData.ulValorMaximo)
            {
                Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgDadoMaior, "blue", false, false);
                return;
            }

            // Validações específica de entrada que devem ser implementadas
            switch (_expectedData.bValidacaoDado)
            {
                case ((byte)E_PWTypeValid.NONE):
                    break;

                case ((byte)(E_PWTypeValid.NOTNULL)):
                    // Validação de valor não nulo
                    if (txtValue.Text.Length == 0)
                    {
                        Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                        return;
                    }
                    break;


                case ((byte)(E_PWTypeValid.MODE10)):
                    // Validação de módulo de 10
                    if (!mode10(txtValue.Text))
                    {
                        Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                        return;
                    }
                    break;

                case ((byte)(E_PWTypeValid.CPF)):
                    // Validação de CPF
                    if (!isCPF(txtValue.Text))
                    {
                        Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                        return;
                    }
                    break;

                case ((byte)(E_PWTypeValid.DATEMMAA)):
                    // Validação de data (MM/AA)
                    if (!DateTime.TryParseExact(txtValue.Text, "MMyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out data))
                    {
                        Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                        return;
                    }

                    break;

                case ((byte)(E_PWTypeValid.DATEDDMMAA)):
                    // Validação de data (DD/MM/AA)
                    if (!DateTime.TryParseExact(txtValue.Text, "ddMMyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out data))
                    {
                        Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                        return;
                    }
                    break;

                case ((byte)(E_PWTypeValid.TWOTIMES)):
                    // Digitar duas vezes o mesmo valor
                    if (!_twoTimesValid)
                    {
                        if (_firstString == null)
                        {
                            _firstString = txtValue.Text;
                            txtValue.Text = "";
                            Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgConfirmacao, "blue", false, false);
                            return;
                        }
                        else
                        {
                            if (_firstString != txtValue.Text)
                            {
                                Sync.Util.SyncMessagerPayGo.CreateMessage(0, "TEF PayGo", _expectedData.szMsgValidacao, "blue", false, false);
                                _twoTimesValid = false;
                                _firstString = null;
                                txtValue.Text = "";
                                return;
                            }

                        }
                    }
                    break;

                default:
                    break;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _userAborted = true;
            txtValue.Text = "";
            this.Close();
        }

        public void ShowDialog(ref bool abort, ref string value)
        {
            this.ShowDialog();

            abort = _userAborted;

            // *** IMPORTANTE: O valor adicionado na biblioteca deve ser o identificador do 
            // *** usuário autenticado e não a senha que ele utilizou para se autenticar.
            if (_expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHMNGTUSER ||
                _expectedData.wIdentificador == (ushort)E_PWINFO.PWINFO_AUTHTECHUSER)
            {
                // Necessário retornar o usuário que foi autenticado pela senha digitada
                value = "Operador1234";
            }
            else
                value = txtValue.Text.Trim();
        }

        private void FormTypedData_Load(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.Activate();
            txtValue.Focus();
        }

        private void FormTypedData_Shown(object sender, EventArgs e)
        {
            this.BringToFront();       // Garante que fique na frente da stack de janelas
            this.Focus();              // Tenta focar
            this.Activate();           // Tenta ativar
        }
    }
}
