namespace PGWLib
{
    partial class FormDisplayMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayMessage));
            LblMessage = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // LblMessage
            // 
            LblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            LblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblMessage.Location = new System.Drawing.Point(0, 8);
            LblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LblMessage.Name = "LblMessage";
            LblMessage.Size = new System.Drawing.Size(461, 154);
            LblMessage.TabIndex = 0;
            LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDisplayMessage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(461, 166);
            Controls.Add(LblMessage);
            DisplayHeader = false;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDisplayMessage";
            Padding = new System.Windows.Forms.Padding(23, 39, 23, 23);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            ShowIcon = false;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "FormDisplayMessage";
            TopMost = true;
            KeyUp += FormDisplayMessage_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
    }
}