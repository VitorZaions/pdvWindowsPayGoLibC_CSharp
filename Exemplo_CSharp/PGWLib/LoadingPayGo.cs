using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace LoadingScreen
{
    public partial class LoadingPayGo : MetroForm
    {
        private bool finished = false;
        public LoadingPayGo(string info)
        {
            InitializeComponent();
            Info_Loading.Text = info;
        }

        public void Finish()
        {
            finished = true;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
        }
        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finished == false)
            {
                e.Cancel = true;
            }
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            Activate();
        }
    }
}
