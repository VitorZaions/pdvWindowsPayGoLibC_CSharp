namespace LoadingScreen
{
    partial class LoadingPayGo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPayGo));
            Info_Loading = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            SuspendLayout();
            // 
            // Info_Loading
            // 
            Info_Loading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Info_Loading.Location = new System.Drawing.Point(151, 65);
            Info_Loading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Info_Loading.Name = "Info_Loading";
            Info_Loading.Size = new System.Drawing.Size(378, 35);
            Info_Loading.TabIndex = 1;
            Info_Loading.Text = "label1";
            Info_Loading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(471, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(104, 51);
            panel1.TabIndex = 2;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.Animated = true;
            guna2CircleProgressBar1.AnimationSpeed = 1.5F;
            guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.FillThickness = 11;
            guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            guna2CircleProgressBar1.Location = new System.Drawing.Point(47, 37);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            guna2CircleProgressBar1.ProgressThickness = 11;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new System.Drawing.Size(87, 87);
            guna2CircleProgressBar1.TabIndex = 20;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.Value = 20;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = panel1;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // Loading
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(574, 159);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(panel1);
            Controls.Add(Info_Loading);
            DisplayHeader = false;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loading";
            Padding = new System.Windows.Forms.Padding(23, 35, 23, 23);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            ShowInTaskbar = false;
            Style = MetroFramework.MetroColorStyle.White;
            Text = "Loading..";
            FormClosing += Loading_FormClosing;
            Load += Loading_Load;
            Shown += Loading_Shown;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label Info_Loading;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}