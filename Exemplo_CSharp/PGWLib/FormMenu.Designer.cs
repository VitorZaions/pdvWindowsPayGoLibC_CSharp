namespace PGWLib
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            LblHeader = new System.Windows.Forms.Label();
            LstMenu = new System.Windows.Forms.ListBox();
            btnOK = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            LblHeader.Location = new System.Drawing.Point(25, 69);
            LblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new System.Drawing.Size(506, 50);
            LblHeader.TabIndex = 0;
            LblHeader.Text = "Selecione uma opção de menu:";
            LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LstMenu
            // 
            LstMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            LstMenu.FormattingEnabled = true;
            LstMenu.ItemHeight = 30;
            LstMenu.Location = new System.Drawing.Point(25, 130);
            LstMenu.Margin = new System.Windows.Forms.Padding(2);
            LstMenu.Name = "LstMenu";
            LstMenu.Size = new System.Drawing.Size(506, 184);
            LstMenu.TabIndex = 1;
            LstMenu.MouseClick += LstMenu_MouseClick;
            LstMenu.KeyDown += KeyPressed;
            // 
            // btnOK
            // 
            btnOK.BorderColor = System.Drawing.Color.Silver;
            btnOK.BorderThickness = 1;
            btnOK.CustomizableEdges = customizableEdges1;
            btnOK.FillColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.ImageOffset = new System.Drawing.Point(-3, 0);
            btnOK.IndicateFocus = true;
            btnOK.Location = new System.Drawing.Point(356, 328);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOK.Size = new System.Drawing.Size(175, 40);
            btnOK.TabIndex = 5;
            btnOK.Text = "Ok";
            btnOK.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.maquina_de_cartao;
            pictureBox1.Location = new System.Drawing.Point(25, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 33);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(556, 388);
            Controls.Add(pictureBox1);
            Controls.Add(btnOK);
            Controls.Add(LstMenu);
            Controls.Add(LblHeader);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "     Selecione uma Opção";
            Load += FormMenu_Load;
            KeyUp += KeyPressed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.ListBox LstMenu;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}