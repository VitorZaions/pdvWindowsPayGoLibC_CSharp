namespace CustomControls.SyncControls
{
    partial class SyncTextBox
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
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            textBox1.Location = new System.Drawing.Point(10, 8);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(328, 18);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.KeyUp += textBox1_KeyUp;
            textBox1.Leave += textBox1_Leave;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.Validating += textBox1_Validating;
            // 
            // SyncTextBox
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.SystemColors.Window;
            Controls.Add(textBox1);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            Name = "SyncTextBox";
            Padding = new System.Windows.Forms.Padding(10, 8, 10, 7);
            Size = new System.Drawing.Size(348, 33);
            Load += SyncTextBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
