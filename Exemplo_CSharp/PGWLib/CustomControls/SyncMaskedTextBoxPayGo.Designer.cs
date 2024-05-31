
namespace CustomControls.SyncControls
{
    partial class SyncMaskedTextBoxPayGo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            TextBoxMask = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DarkGray;
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1, 35);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DarkGray;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(1, 34);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(204, 1);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.DarkGray;
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(204, 1);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.DarkGray;
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(204, 1);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1, 33);
            panel4.TabIndex = 4;
            // 
            // TextBoxMask
            // 
            TextBoxMask.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TextBoxMask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBoxMask.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            TextBoxMask.ForeColor = System.Drawing.SystemColors.ControlText;
            TextBoxMask.Location = new System.Drawing.Point(9, 3);
            TextBoxMask.Margin = new System.Windows.Forms.Padding(10);
            TextBoxMask.Name = "TextBoxMask";
            TextBoxMask.Size = new System.Drawing.Size(195, 28);
            TextBoxMask.TabIndex = 5;
            TextBoxMask.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // SyncMaskedTextBoxPayGo
            // 
            Controls.Add(TextBoxMask);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = System.Windows.Forms.Cursors.IBeam;
            Font = new System.Drawing.Font("Segoe UI", 15.75F);
            Name = "SyncMaskedTextBoxPayGo";
            Size = new System.Drawing.Size(205, 35);
            Load += SyncMaskedTextBox_Load;
            EnabledChanged += SyncMaskedTextBox_EnabledChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox TextBoxMask;
    }
}
