namespace ScreenWareS
{
    partial class frmSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboCaptureRect = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFollowMC = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCaptureMC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkShowFashing = new System.Windows.Forms.CheckBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShowCountdown = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFrameRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 34);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(188, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configurações";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(465, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(499, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cboCaptureRect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkFollowMC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboCaptureMC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkShowFashing);
            this.groupBox1.Controls.Add(this.txtQuality);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkShowCountdown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboFrameRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(366, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 24);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(189, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 24);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Salvar as Alterações";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(6, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 24);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Resetar as Configurações";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboCaptureRect
            // 
            this.cboCaptureRect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboCaptureRect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureRect.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureRect.ForeColor = System.Drawing.Color.White;
            this.cboCaptureRect.FormattingEnabled = true;
            this.cboCaptureRect.Items.AddRange(new object[] {
            "Tela Cheia",
            "Area de Trabalho"});
            this.cboCaptureRect.Location = new System.Drawing.Point(416, 78);
            this.cboCaptureRect.Name = "cboCaptureRect";
            this.cboCaptureRect.Size = new System.Drawing.Size(113, 21);
            this.cboCaptureRect.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(287, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Retângulo de captura:";
            // 
            // chkFollowMC
            // 
            this.chkFollowMC.AutoSize = true;
            this.chkFollowMC.ForeColor = System.Drawing.Color.White;
            this.chkFollowMC.Location = new System.Drawing.Point(101, 116);
            this.chkFollowMC.Name = "chkFollowMC";
            this.chkFollowMC.Size = new System.Drawing.Size(15, 14);
            this.chkFollowMC.TabIndex = 18;
            this.chkFollowMC.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Seguir os Curso:";
            // 
            // cboCaptureMC
            // 
            this.cboCaptureMC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboCaptureMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureMC.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureMC.ForeColor = System.Drawing.Color.White;
            this.cboCaptureMC.FormattingEnabled = true;
            this.cboCaptureMC.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboCaptureMC.Location = new System.Drawing.Point(101, 81);
            this.cboCaptureMC.Name = "cboCaptureMC";
            this.cboCaptureMC.Size = new System.Drawing.Size(99, 21);
            this.cboCaptureMC.TabIndex = 16;
            this.cboCaptureMC.SelectedIndexChanged += new System.EventHandler(this.cboCaptureMC_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cursor do mouse:";
            // 
            // chkShowFashing
            // 
            this.chkShowFashing.AutoSize = true;
            this.chkShowFashing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkShowFashing.Location = new System.Drawing.Point(290, 49);
            this.chkShowFashing.Name = "chkShowFashing";
            this.chkShowFashing.Size = new System.Drawing.Size(90, 17);
            this.chkShowFashing.TabIndex = 14;
            this.chkShowFashing.Text = "Mostrar limite ";
            this.chkShowFashing.UseVisualStyleBackColor = true;
            // 
            // txtQuality
            // 
            this.txtQuality.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtQuality.ForeColor = System.Drawing.Color.White;
            this.txtQuality.Location = new System.Drawing.Point(101, 46);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(81, 20);
            this.txtQuality.TabIndex = 13;
            this.txtQuality.Text = "95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Qualidade (1-100) :";
            // 
            // chkShowCountdown
            // 
            this.chkShowCountdown.AutoSize = true;
            this.chkShowCountdown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkShowCountdown.Location = new System.Drawing.Point(290, 15);
            this.chkShowCountdown.Name = "chkShowCountdown";
            this.chkShowCountdown.Size = new System.Drawing.Size(239, 17);
            this.chkShowCountdown.TabIndex = 11;
            this.chkShowCountdown.Text = "Mostrar contagem regressiva antes de gravar";
            this.chkShowCountdown.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(206, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "FPS";
            // 
            // cboFrameRate
            // 
            this.cboFrameRate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrameRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrameRate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboFrameRate.ForeColor = System.Drawing.Color.White;
            this.cboFrameRate.FormattingEnabled = true;
            this.cboFrameRate.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "60"});
            this.cboFrameRate.Location = new System.Drawing.Point(101, 13);
            this.cboFrameRate.Name = "cboFrameRate";
            this.cboFrameRate.Size = new System.Drawing.Size(99, 21);
            this.cboFrameRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frame Rate :";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowCountdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowFashing;
        private System.Windows.Forms.ComboBox cboCaptureMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkFollowMC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCaptureRect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
    }
}