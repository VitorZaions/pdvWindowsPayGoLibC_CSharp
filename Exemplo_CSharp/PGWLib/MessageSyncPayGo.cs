using MetroFramework.Forms;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGWLib
{
    public partial class MessageSyncPayGo : MetroForm
    {
        private string _NomeTela;
        private string _Descricao;
        private string _Color;
        private bool _ButtonCancelar;
        private bool _ForceDisableOthers;
        private bool _IsUpdating;
        private bool _IsAviso;
        private int _TipoTela;
        private int _DefaultButton;

        // Informações do modulo se necessário

        private static string _CaminhoModulo;

        public MessageSyncPayGo(int TipoTela, string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers, bool IsUpdating, bool IsAviso, int DefaultButton = 0)
        {
            _NomeTela = NomeTela;
            this.Text = _NomeTela;
            _Descricao = Descricao;
            _Color = Color;
            _ButtonCancelar = ButtonCancelar;
            _ForceDisableOthers = ForceDisableOthers;
            _IsUpdating = IsUpdating;
            _IsAviso = IsAviso;
            _TipoTela = TipoTela;
            _DefaultButton = DefaultButton;

            InitializeComponent();
        }

        public MessageSyncPayGo(string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers, bool IsUpdating, string CaminhoModulo)
        {
            _NomeTela = NomeTela;
            this.Text = _NomeTela;
            _Descricao = Descricao;
            _Color = Color;
            _ButtonCancelar = ButtonCancelar;
            _ForceDisableOthers = ForceDisableOthers;
            _IsUpdating = IsUpdating;
            _CaminhoModulo = CaminhoModulo;
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                    this.DialogResult = DialogResult.None;
                    Close();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void MessageSync_Load(object sender, EventArgs e)
        {
            CheckColor();
            SetupHeader();
            SetupIsUpdating();
            SetupDesc();
            SetupButtons();
            SetupIsAviso();


            if (_TipoTela == 1)
            {
                BTN_Confirmar.Text = "Sim";
                BTN_Cancelar.Text = "Não";
            }

            if (_DefaultButton == 0)
            {
                BTN_Cancelar.TabIndex = 0;
                BTN_Confirmar.TabIndex = 1;
            }
            else
            {
                BTN_Cancelar.TabIndex = 1;
                BTN_Confirmar.TabIndex = 0;
            }

        }

        private void SetupIsAviso()
        {
            if (_IsAviso)
            {
                ovCBX_NaoAvisarNovamente.Visible = true;
            }
        }

        private void CheckColor()
        {
            HeaderBG_Default.Visible = true;
            PB_Icone.Image = Properties.Resources.information;
        }

        private void SetupHeader()
        {
            LBL_Header.Text = _NomeTela;
        }

        private void SetupDesc()
        {
            int DescHeight = LBL_Desc.Height;
            LBL_Desc.Text = _Descricao;
            if (LBL_IsUpdating.Visible)
                this.Height = this.Height + (LBL_Desc.Height - DescHeight);
            else
                this.Height = this.Height + (LBL_Desc.Height - DescHeight) - (LBL_IsUpdating.Height * 2);
            LBL_Desc.Update();

        }

        private void SetupButtons()
        {
            if (_ButtonCancelar == false)
                BTN_Cancelar.Visible = false;
        }

        private void SetupIsUpdating()
        {
            if (_IsUpdating == true)
            {
                LBL_IsUpdating.Visible = true;
                LBL_IsUpdatingClick.Visible = true;
                LBL_IsUpdatingClick.BringToFront();
            }
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            if (ovCBX_NaoAvisarNovamente.Checked && _IsAviso)
            {
                this.DialogResult = DialogResult.Ignore;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MessageSync_Activated(object sender, EventArgs e)
        {
            if (_ForceDisableOthers == true)
                DisableOtherForms();
        }

        private void DisableOtherForms()
        {
            Task CloseOtherForms = Task.Factory.StartNew(() =>
            {
                Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => (x.Name != "MessageSync" && x.Name != "")).ToArray();
                foreach (Form openForm in formsList)
                {
                    openForm.Invoke((MethodInvoker)(() =>
                    {
                        //MessageBox.Show("Tela = " + openForm.Name);
                        openForm.Enabled = false;
                    }));
                }
            });
        }

        private void EnableOtherForms()
        {
            Task CloseOtherForms = Task.Factory.StartNew(() =>
            {
                Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => (x.Name != "MessageSync" && x.Name != "")).ToArray();
                foreach (Form openForm in formsList)
                {
                    openForm.Invoke((MethodInvoker)(() =>
                    {
                        //MessageBox.Show("Tela = " + openForm.Name);
                        openForm.Enabled = true;
                    }));
                }
            });
        }

        private void MessageSync_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ForceDisableOthers == true)
                EnableOtherForms();
        }

        private void LBL_IsUpdatingClick_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void LBL_Desc_Click(object sender, EventArgs e)
        {

        }

        private void MessageSync_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                try
                { 
                    if (!string.IsNullOrWhiteSpace(LBL_Desc.Text) && !string.IsNullOrEmpty(LBL_Desc.SelectedText))
                        Clipboard.SetText(LBL_Desc.SelectedText);
                }
                catch
                {
                    // Nada, só nao conseguiu acessar a área de transferência
                }
            }
        }

        private void LBL_Desc_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
