using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControls.SyncControls
{
    public class EditDecimalGuna2PayGo : Guna.UI2.WinForms.Guna2NumericUpDown
    {
        private Label mLabel;
        private TextBox mBox;

        public bool Marcado = false;
        private bool arredondar = true;
        private bool updownbuttonvisible = true;

        public EditDecimalGuna2PayGo()
        {
            // Remove a adição pelo scroll, controle 1 é do label do numeric.
            Controls[1].MouseWheel += Ctl_MouseWheel;
            Controls[0].TabStop = false;

            this.Leave += delegate (Object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.Value = this.Minimum <= 0 ? 0 : this.Minimum;
                    this.Text = this.Value <= 0 ? "0" : this.Value.ToString();
                }
                else
                {
                    if (arredondar)
                    {
                        if (this.Value < 0)
                        {
                            //Transforma em positivo
                            decimal UltimoNumero = this.Value * -1;
                            decimal Arredondado = Convert.ToDecimal(Math.Round(Convert.ToDouble(UltimoNumero), this.DecimalPlaces));
                            this.Value = Arredondado * -1;
                        }
                        else
                        {
                            this.Value = Convert.ToDecimal(Math.Round(Convert.ToDouble(this.Value), this.DecimalPlaces)); // Suporta somente números positivos.
                        }
                    }
                    //else
                    //    this.Text = this.Value >= 99.995m ? "99,99" : this.Value.ToString();
                }
            };

            /*
            this.ValueChanged += delegate (object sender, EventArgs e)
            {
                // Sempre a mais
                this.Value = Convert.ToDecimal(Math.Round(Convert.ToDouble(this.Value), this.DecimalPlaces)); // Suporta somente números positivos.
            };*/

            ThousandsSeparator = true;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        [Category("SyncDecimal")]
        public bool Arredondar
        {
            get { return arredondar; }
            set { arredondar = value; }
        }

        public bool UpDownButtonVisible
        {
            get { return updownbuttonvisible; }
            set
            {
                Controls[0].Visible = value;
                updownbuttonvisible = value; 
            }
        }

        private void Ctl_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
