using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace PGWLib
{
    public partial class FormDisplayMessage : MetroForm
    {
        System.Windows.Forms.Timer timer;
        bool _userAborted;
        private Thread _uiThread;

        public FormDisplayMessage()
        {
            InitializeComponent();
            _userAborted = false;
            this.TopMost = true;
        }

        // Inicia a exibição da janela de mensagens no modo permanente numa thread STA
        public void Start()
        {
            _uiThread = new Thread(() =>
            {
                // Mostra o form modal nesta thread STA
                this.ShowDialog();
            });
            _uiThread.SetApartmentState(ApartmentState.STA);
            _uiThread.IsBackground = true;
            _uiThread.Start();
        }

        // Para a exibição da janela de mensagens no modo permanente
        public void Stop()
        {
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
                    this.Close();
            }
        }

        // Atualiza o texto exibido da janela de mensagens no modo permanente
        public void ChangeText(string newText)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    this.LblMessage.Text = newText.TrimStart('\r').Replace("\r", "\n");
                    this.Focus();
                }));
            }
            else
            {
                if (this.IsDisposed)
                    throw new ObjectDisposedException("Control is already disposed.");
                else
                {
                    this.LblMessage.Text = newText.TrimStart('\r').Replace("\r", "\n");
                    this.Focus();
                }
            }
        }

        // Exibe a janela de mensagem com timeout (este método roda na thread que chamar)
        public void ShowDialog(string message, int timeout)
        {
            if (string.IsNullOrEmpty(message))
                return;

            this.LblMessage.Text = message.Replace("\r", "\n");

            timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Dispose();
            this.Close();
        }

        // Caso o operador pressione ESC para abortar
        private void FormDisplayMessage_KeyUp(object sender, KeyEventArgs e)
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

        private void FormDisplayMessage_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.Activate();
        }
    }
}