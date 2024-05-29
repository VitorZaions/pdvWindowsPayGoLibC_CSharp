 namespace PGWLib
{
    partial class FormTypedData
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypedData));
            LblHeader = new System.Windows.Forms.Label();
            lblCurrency = new System.Windows.Forms.Label();
            btnOK = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            txtValue = new CustomControls.SyncControls.SyncMaskedTextBoxPayGo();
            SuspendLayout();
            // 
            // LblHeader
            // 
            LblHeader.AllowDrop = true;
            LblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblHeader.Location = new System.Drawing.Point(3, 26);
            LblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new System.Drawing.Size(575, 55);
            LblHeader.TabIndex = 2;
            LblHeader.Text = "Insira ldsadas";
            LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrency
            // 
            lblCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCurrency.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            lblCurrency.Location = new System.Drawing.Point(31, 75);
            lblCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new System.Drawing.Size(0, 36);
            lblCurrency.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.BorderColor = System.Drawing.Color.Silver;
            btnOK.BorderThickness = 1;
            btnOK.CustomizableEdges = customizableEdges1;
            btnOK.FillColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOK.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.ImageOffset = new System.Drawing.Point(-3, 0);
            btnOK.IndicateFocus = true;
            btnOK.Location = new System.Drawing.Point(385, 150);
            btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOK.Size = new System.Drawing.Size(175, 40);
            btnOK.TabIndex = 4;
            btnOK.Text = "Ok";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = System.Drawing.Color.Silver;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.FillColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancel.Image = Properties.Resources.button_cancelar2;
            btnCancel.ImageOffset = new System.Drawing.Point(-3, 0);
            btnCancel.IndicateFocus = true;
            btnCancel.Location = new System.Drawing.Point(202, 150);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new System.Drawing.Size(175, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += btnCancel_Click;
            // 
            // txtValue
            // 
            txtValue.BorderColor = System.Drawing.Color.DarkGray;
            txtValue.BorderColorSelected = System.Drawing.Color.FromArgb(94, 148, 255);
            txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtValue.Location = new System.Drawing.Point(19, 89);
            txtValue.Mask = "00,000,000/0000-00";
            txtValue.Name = "txtValue";
            txtValue.PasswordChar = '\0';
            txtValue.Size = new System.Drawing.Size(541, 48);
            txtValue.Font = new System.Drawing.Font("Segoe UI", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtValue.TabIndex = 6;
            txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txtValue.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FormTypedData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            ClientSize = new System.Drawing.Size(581, 214);
            Controls.Add(txtValue);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblCurrency);
            Controls.Add(LblHeader);
            DisplayHeader = false;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTypedData";
            Padding = new System.Windows.Forms.Padding(23, 39, 23, 23);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            ShowIcon = false;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "Insira a informação solicitada";
            TopMost = true;
            Load += FormTypedData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label lblCurrency;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private CustomControls.SyncControls.SyncMaskedTextBoxPayGo txtValue;
    }
}