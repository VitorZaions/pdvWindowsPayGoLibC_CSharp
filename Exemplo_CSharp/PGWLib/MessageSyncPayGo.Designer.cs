
namespace PGWLib
{
    partial class MessageSyncPayGo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageSyncPayGo));
            LBL_Header = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            BTN_Confirmar = new Guna.UI2.WinForms.Guna2Button();
            BTN_Cancelar = new Guna.UI2.WinForms.Guna2Button();
            PB_Icone = new System.Windows.Forms.PictureBox();
            HeaderBG_Default = new System.Windows.Forms.Panel();
            LBL_IsUpdating = new System.Windows.Forms.Label();
            LBL_IsUpdatingClick = new System.Windows.Forms.Label();
            LBL_Desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ovCBX_NaoAvisarNovamente = new Guna.UI2.WinForms.Guna2CheckBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Icone).BeginInit();
            SuspendLayout();
            // 
            // LBL_Header
            // 
            LBL_Header.AutoSize = true;
            LBL_Header.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_Header.Location = new System.Drawing.Point(27, 26);
            LBL_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LBL_Header.Name = "LBL_Header";
            LBL_Header.Size = new System.Drawing.Size(118, 37);
            LBL_Header.TabIndex = 59;
            LBL_Header.Text = "$Header";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(BTN_Confirmar);
            flowLayoutPanel1.Controls.Add(BTN_Cancelar);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(392, 165);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(324, 52);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // BTN_Confirmar
            // 
            BTN_Confirmar.BorderColor = System.Drawing.Color.Silver;
            BTN_Confirmar.BorderThickness = 1;
            BTN_Confirmar.CustomizableEdges = customizableEdges1;
            BTN_Confirmar.FillColor = System.Drawing.Color.FromArgb(238, 238, 238);
            BTN_Confirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_Confirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_Confirmar.Image = Properties.Resources.ok_24px;
            BTN_Confirmar.ImageOffset = new System.Drawing.Point(-3, 0);
            BTN_Confirmar.IndicateFocus = true;
            BTN_Confirmar.Location = new System.Drawing.Point(170, 3);
            BTN_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Confirmar.Name = "BTN_Confirmar";
            BTN_Confirmar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BTN_Confirmar.Size = new System.Drawing.Size(150, 40);
            BTN_Confirmar.TabIndex = 2;
            BTN_Confirmar.Text = "Confirmar";
            BTN_Confirmar.Click += BTN_Confirmar_Click;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.BorderColor = System.Drawing.Color.Silver;
            BTN_Cancelar.BorderThickness = 1;
            BTN_Cancelar.CustomizableEdges = customizableEdges3;
            BTN_Cancelar.FillColor = System.Drawing.Color.FromArgb(238, 238, 238);
            BTN_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            BTN_Cancelar.Image = Properties.Resources.button_cancelar2;
            BTN_Cancelar.ImageOffset = new System.Drawing.Point(-3, 0);
            BTN_Cancelar.IndicateFocus = true;
            BTN_Cancelar.Location = new System.Drawing.Point(12, 3);
            BTN_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BTN_Cancelar.Size = new System.Drawing.Size(150, 40);
            BTN_Cancelar.TabIndex = 1;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // PB_Icone
            // 
            PB_Icone.Location = new System.Drawing.Point(34, 79);
            PB_Icone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PB_Icone.Name = "PB_Icone";
            PB_Icone.Size = new System.Drawing.Size(40, 38);
            PB_Icone.TabIndex = 62;
            PB_Icone.TabStop = false;
            // 
            // HeaderBG_Default
            // 
            HeaderBG_Default.BackColor = System.Drawing.Color.FromArgb(84, 144, 249);
            HeaderBG_Default.Location = new System.Drawing.Point(0, 0);
            HeaderBG_Default.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HeaderBG_Default.Name = "HeaderBG_Default";
            HeaderBG_Default.Size = new System.Drawing.Size(735, 6);
            HeaderBG_Default.TabIndex = 63;
            HeaderBG_Default.Visible = false;
            // 
            // LBL_IsUpdating
            // 
            LBL_IsUpdating.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LBL_IsUpdating.AutoSize = true;
            LBL_IsUpdating.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_IsUpdating.Location = new System.Drawing.Point(30, 126);
            LBL_IsUpdating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LBL_IsUpdating.Name = "LBL_IsUpdating";
            LBL_IsUpdating.Size = new System.Drawing.Size(485, 16);
            LBL_IsUpdating.TabIndex = 64;
            LBL_IsUpdating.Text = "Caso ocorra algum problema na atualização, clique  aqui para destravar o sistema.";
            LBL_IsUpdating.Visible = false;
            // 
            // LBL_IsUpdatingClick
            // 
            LBL_IsUpdatingClick.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LBL_IsUpdatingClick.AutoSize = true;
            LBL_IsUpdatingClick.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_IsUpdatingClick.ForeColor = System.Drawing.Color.FromArgb(84, 144, 249);
            LBL_IsUpdatingClick.Location = new System.Drawing.Point(331, 126);
            LBL_IsUpdatingClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LBL_IsUpdatingClick.Name = "LBL_IsUpdatingClick";
            LBL_IsUpdatingClick.Size = new System.Drawing.Size(31, 16);
            LBL_IsUpdatingClick.TabIndex = 65;
            LBL_IsUpdatingClick.Text = "aqui";
            LBL_IsUpdatingClick.Visible = false;
            LBL_IsUpdatingClick.Click += LBL_IsUpdatingClick_Click;
            // 
            // LBL_Desc
            // 
            LBL_Desc.AutoSize = false;
            LBL_Desc.AutoSizeHeightOnly = true;
            LBL_Desc.BackColor = System.Drawing.Color.Transparent;
            LBL_Desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LBL_Desc.Location = new System.Drawing.Point(81, 79);
            LBL_Desc.Name = "LBL_Desc";
            LBL_Desc.Size = new System.Drawing.Size(627, 22);
            LBL_Desc.TabIndex = 216;
            LBL_Desc.Text = "#Desc";
            LBL_Desc.KeyDown += LBL_Desc_KeyDown;
            // 
            // ovCBX_NaoAvisarNovamente
            // 
            ovCBX_NaoAvisarNovamente.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ovCBX_NaoAvisarNovamente.AutoSize = true;
            ovCBX_NaoAvisarNovamente.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            ovCBX_NaoAvisarNovamente.CheckedState.BorderRadius = 0;
            ovCBX_NaoAvisarNovamente.CheckedState.BorderThickness = 0;
            ovCBX_NaoAvisarNovamente.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            ovCBX_NaoAvisarNovamente.Location = new System.Drawing.Point(34, 165);
            ovCBX_NaoAvisarNovamente.Name = "ovCBX_NaoAvisarNovamente";
            ovCBX_NaoAvisarNovamente.Size = new System.Drawing.Size(147, 19);
            ovCBX_NaoAvisarNovamente.TabIndex = 0;
            ovCBX_NaoAvisarNovamente.Text = "Não avisar novamente.";
            ovCBX_NaoAvisarNovamente.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
            ovCBX_NaoAvisarNovamente.UncheckedState.BorderRadius = 0;
            ovCBX_NaoAvisarNovamente.UncheckedState.BorderThickness = 0;
            ovCBX_NaoAvisarNovamente.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);
            ovCBX_NaoAvisarNovamente.Visible = false;
            // 
            // MessageSync
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(734, 228);
            Controls.Add(ovCBX_NaoAvisarNovamente);
            Controls.Add(LBL_Desc);
            Controls.Add(LBL_IsUpdatingClick);
            Controls.Add(LBL_IsUpdating);
            Controls.Add(HeaderBG_Default);
            Controls.Add(PB_Icone);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(LBL_Header);
            DisplayHeader = false;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MessageSync";
            Padding = new System.Windows.Forms.Padding(23, 35, 23, 23);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            Style = MetroFramework.MetroColorStyle.Default;
            Text = "Aviso";
            Activated += MessageSync_Activated;
            FormClosing += MessageSync_FormClosing;
            Load += MessageSync_Load;
            KeyDown += MessageSync_KeyDown;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_Icone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label LBL_Header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PB_Icone;
        private System.Windows.Forms.Panel HeaderBG_Default;
        private System.Windows.Forms.Label LBL_IsUpdating;
        private System.Windows.Forms.Label LBL_IsUpdatingClick;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBL_Desc;
        private Guna.UI2.WinForms.Guna2CheckBox ovCBX_NaoAvisarNovamente;
        private Guna.UI2.WinForms.Guna2Button BTN_Confirmar;
        private Guna.UI2.WinForms.Guna2Button BTN_Cancelar;
    }
}