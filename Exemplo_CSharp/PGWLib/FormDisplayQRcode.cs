using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGWLib
{
    public partial class FormDisplayQRcode : MetroForm
    {
        bool _userAborted;
        string _lastQRcode;
        bool _isStarted;
        private Thread _uiThread;

        private void AtualizaQRCode(string qrCode)
        {
            // Código comentado do QRCodeGenerator pode ficar aqui caso queira usar

            // Caso o componente de geração de QRcode não esteja instalado, somente exibe a string com o código na tela
            this.tbQRcode.Text = qrCode;
            this.TopMost = true;
        }

        public FormDisplayQRcode()
        {
            InitializeComponent();
            _userAborted = false;
            _isStarted = false;
        }

        // Inicia a exibição da janela de QRcode no modo permanente numa thread STA
        public void Start()
        {
            if (_isStarted)
                return;

            _uiThread = new Thread(() =>
            {
                this.ShowDialog();
            });
            _uiThread.SetApartmentState(ApartmentState.STA);
            _uiThread.IsBackground = true;
            _uiThread.Start();

            _isStarted = true;
        }

        // Para a exibição do QRcode
        public void Stop()
        {
            if (!_isStarted)
                return;

            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                if (this.IsDisposed)
                    throw new ObjectDisposedException("Control is already disposed.");
                else
                {
                    this.Close();
                }
            }

            _isStarted = false;
        }

        // Atualiza o texto e/ou o QRcode
        public void ChangeText(string text, string qrCode)
        {
            if (qrCode != _lastQRcode)
                AtualizaQRCode(qrCode);
            _lastQRcode = qrCode;

            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    this.lblMessage.Text = text.TrimStart('\r').Replace("\r", "\n");
                    this.Focus();
                }));
            }
            else
            {
                if (this.IsDisposed)
                    throw new ObjectDisposedException("Control is already disposed.");
                else
                {
                    this.lblMessage.Text = text.TrimStart('\r').Replace("\r", "\n");
                    this.Focus();
                }
            }
        }

        // Caso o operador pressione a tecla ESC para abortar a operação
        private void FormDisplayQRcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _userAborted = true;
                this.Close();
            }
        }

        private void tbQRcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _userAborted = true;
                this.Close();
            }
        }

        // Checa se a tecla ESC foi pressionada
        public bool isAborted()
        {
            return _userAborted;
        }

        private void FormDisplayQRcode_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.Activate();
        }
    }
}