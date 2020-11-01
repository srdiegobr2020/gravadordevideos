namespace ScreenWareS
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlExtender1 = new TabControlExtender();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_RecStop = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btn_Mic = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_JopList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miPause_Resume = new System.Windows.Forms.ToolStripMenuItem();
            this.miStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlExtender1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlExtender1
            // 
            this.tabControlExtender1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlExtender1.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlExtender1.Controls.Add(this.tabPage2);
            this.tabControlExtender1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlExtender1.HeaderAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabControlExtender1.HeaderBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlExtender1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlExtender1.HeaderForeColor = System.Drawing.Color.White;
            this.tabControlExtender1.HeaderSelectedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabControlExtender1.ItemSize = new System.Drawing.Size(32, 100);
            this.tabControlExtender1.Location = new System.Drawing.Point(0, 40);
            this.tabControlExtender1.Multiline = true;
            this.tabControlExtender1.Name = "tabControlExtender1";
            this.tabControlExtender1.SelectedIndex = 0;
            this.tabControlExtender1.Size = new System.Drawing.Size(803, 393);
            this.tabControlExtender1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlExtender1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblValue);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblStage);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btn_JopList);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gravação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblValue.Location = new System.Drawing.Point(69, 320);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 18;
            this.lblValue.Text = "0";
            this.lblValue.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(11, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Valor:";
            this.label5.Visible = false;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStage.Location = new System.Drawing.Point(69, 294);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(28, 13);
            this.lblStage.TabIndex = 16;
            this.lblStage.Text = ".......";
            this.lblStage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(6, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Progresso:";
            this.label3.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(644, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(647, 254);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btn_RecStop);
            this.panel2.Controls.Add(this.btnEncode);
            this.panel2.Controls.Add(this.btn_Mic);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.btn_Setting);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 29);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(581, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btn_RecStop
            // 
            this.btn_RecStop.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_RecStop.BackgroundImage = global::ScreenWareS.Properties.Resources.rec;
            this.btn_RecStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_RecStop.Location = new System.Drawing.Point(48, 0);
            this.btn_RecStop.Name = "btn_RecStop";
            this.btn_RecStop.Size = new System.Drawing.Size(39, 29);
            this.btn_RecStop.TabIndex = 3;
            this.btn_RecStop.UseVisualStyleBackColor = false;
            this.btn_RecStop.Click += new System.EventHandler(this.btn_RecStop_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEncode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEncode.Location = new System.Drawing.Point(512, 0);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(63, 29);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.Text = "Converter";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btn_Mic
            // 
            this.btn_Mic.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Mic.BackgroundImage = global::ScreenWareS.Properties.Resources.mic_on;
            this.btn_Mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Mic.Location = new System.Drawing.Point(3, 0);
            this.btn_Mic.Name = "btn_Mic";
            this.btn_Mic.Size = new System.Drawing.Size(39, 29);
            this.btn_Mic.TabIndex = 2;
            this.btn_Mic.UseVisualStyleBackColor = false;
            this.btn_Mic.Click += new System.EventHandler(this.btn_Mic_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(443, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 29);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Procurar";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Setting.BackgroundImage = global::ScreenWareS.Properties.Resources.setting;
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Setting.Location = new System.Drawing.Point(93, 0);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(39, 29);
            this.btn_Setting.TabIndex = 1;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_JopList
            // 
            this.btn_JopList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_JopList.BackgroundImage = global::ScreenWareS.Properties.Resources.listicon;
            this.btn_JopList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_JopList.Location = new System.Drawing.Point(43, 71);
            this.btn_JopList.Name = "btn_JopList";
            this.btn_JopList.Size = new System.Drawing.Size(39, 29);
            this.btn_JopList.TabIndex = 0;
            this.btn_JopList.UseVisualStyleBackColor = false;
            this.btn_JopList.Click += new System.EventHandler(this.btn_JopList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 34);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(325, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Screen WareS ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "StateIndicatorModels.Icon.png");
            this.imageList1.Images.SetKeyName(1, "Action_Debug_Start_32x32.png");
            this.imageList1.Images.SetKeyName(2, "play.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HD-Screen Recorder";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPause_Resume,
            this.miStop,
            this.toolStripSeparator1,
            this.miExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 76);
            // 
            // miPause_Resume
            // 
            this.miPause_Resume.Enabled = false;
            this.miPause_Resume.Name = "miPause_Resume";
            this.miPause_Resume.ShowShortcutKeys = false;
            this.miPause_Resume.Size = new System.Drawing.Size(98, 22);
            this.miPause_Resume.Text = "Pause";
            // 
            // miStop
            // 
            this.miStop.Enabled = false;
            this.miStop.Name = "miStop";
            this.miStop.Size = new System.Drawing.Size(98, 22);
            this.miStop.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(98, 22);
            this.miExit.Text = "Exit";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 406);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(755, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(740, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 428);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlExtender1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ScreenWareS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControlExtender1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControlExtender tabControlExtender1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPause_Resume;
        private System.Windows.Forms.ToolStripMenuItem miStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btn_RecStop;
        private System.Windows.Forms.Button btn_Mic;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_JopList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}

