namespace PGWLib
{
    partial class FormDisplayQRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayQRcode));
            lblMessage = new System.Windows.Forms.Label();
            pbQRcode = new System.Windows.Forms.PictureBox();
            tbQRcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pbQRcode).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMessage.Location = new System.Drawing.Point(55, 10);
            lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(461, 166);
            lblMessage.TabIndex = 0;
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbQRcode
            // 
            pbQRcode.Location = new System.Drawing.Point(55, 182);
            pbQRcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pbQRcode.Name = "pbQRcode";
            pbQRcode.Size = new System.Drawing.Size(461, 456);
            pbQRcode.TabIndex = 1;
            pbQRcode.TabStop = false;
            // 
            // tbQRcode
            // 
            tbQRcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbQRcode.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbQRcode.Location = new System.Drawing.Point(55, 182);
            tbQRcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbQRcode.Multiline = true;
            tbQRcode.Name = "tbQRcode";
            tbQRcode.ReadOnly = true;
            tbQRcode.Size = new System.Drawing.Size(461, 456);
            tbQRcode.TabIndex = 2;
            tbQRcode.TabStop = false;
            tbQRcode.KeyUp += tbQRcode_KeyUp;
            // 
            // FormDisplayQRcode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(587, 706);
            Controls.Add(lblMessage);
            Controls.Add(pbQRcode);
            Controls.Add(tbQRcode);
            DisplayHeader = false;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormDisplayQRcode";
            Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "FormDisplayQRcode";
            KeyUp += FormDisplayQRcode_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbQRcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbQRcode;
        private System.Windows.Forms.TextBox tbQRcode;
    }
}