namespace DailyTask
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_NavistarTrucks = new System.Windows.Forms.Button();
            this.btn_OchoSeis = new System.Windows.Forms.Button();
            this.btn_picdb = new System.Windows.Forms.Button();
            this.btn_efeq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estaOkimgPic = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estaOkimgNav = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estaOkimgF = new System.Windows.Forms.PictureBox();
            this.estaOkimg866 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgPic)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimg866)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Opciones";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_NavistarTrucks);
            this.flowLayoutPanel1.Controls.Add(this.btn_OchoSeis);
            this.flowLayoutPanel1.Controls.Add(this.btn_picdb);
            this.flowLayoutPanel1.Controls.Add(this.btn_efeq);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 149);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btn_NavistarTrucks
            // 
            this.btn_NavistarTrucks.Image = ((System.Drawing.Image)(resources.GetObject("btn_NavistarTrucks.Image")));
            this.btn_NavistarTrucks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_NavistarTrucks.Location = new System.Drawing.Point(3, 3);
            this.btn_NavistarTrucks.Name = "btn_NavistarTrucks";
            this.btn_NavistarTrucks.Size = new System.Drawing.Size(118, 38);
            this.btn_NavistarTrucks.TabIndex = 0;
            this.btn_NavistarTrucks.Text = "Navistar Truck ";
            this.btn_NavistarTrucks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NavistarTrucks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_NavistarTrucks.UseVisualStyleBackColor = true;
            this.btn_NavistarTrucks.Click += new System.EventHandler(this.btn_NavistarTrucks_Click);
            // 
            // btn_OchoSeis
            // 
            this.btn_OchoSeis.Image = global::DailyTask.Properties.Resources.ReversSort_32x32;
            this.btn_OchoSeis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OchoSeis.Location = new System.Drawing.Point(127, 3);
            this.btn_OchoSeis.Name = "btn_OchoSeis";
            this.btn_OchoSeis.Size = new System.Drawing.Size(118, 38);
            this.btn_OchoSeis.TabIndex = 1;
            this.btn_OchoSeis.Text = "866";
            this.btn_OchoSeis.UseVisualStyleBackColor = true;
            this.btn_OchoSeis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_picdb
            // 
            this.btn_picdb.Image = global::DailyTask.Properties.Resources.Expired_50;
            this.btn_picdb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_picdb.Location = new System.Drawing.Point(3, 47);
            this.btn_picdb.Name = "btn_picdb";
            this.btn_picdb.Size = new System.Drawing.Size(118, 38);
            this.btn_picdb.TabIndex = 2;
            this.btn_picdb.Text = "Pic DB";
            this.btn_picdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_picdb.UseVisualStyleBackColor = true;
            this.btn_picdb.Click += new System.EventHandler(this.btn_picdb_Click);
            // 
            // btn_efeq
            // 
            this.btn_efeq.Image = global::DailyTask.Properties.Resources.Navigate_32x32;
            this.btn_efeq.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_efeq.Location = new System.Drawing.Point(127, 47);
            this.btn_efeq.Name = "btn_efeq";
            this.btn_efeq.Size = new System.Drawing.Size(118, 38);
            this.btn_efeq.TabIndex = 3;
            this.btn_efeq.Text = "F45";
            this.btn_efeq.UseVisualStyleBackColor = true;
            this.btn_efeq.Click += new System.EventHandler(this.btn_efeq_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estaOkimgPic);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(3, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status de Archivos";
            // 
            // estaOkimgPic
            // 
            this.estaOkimgPic.Image = global::DailyTask.Properties.Resources.A_32x32;
            this.estaOkimgPic.Location = new System.Drawing.Point(207, 17);
            this.estaOkimgPic.Name = "estaOkimgPic";
            this.estaOkimgPic.Size = new System.Drawing.Size(30, 32);
            this.estaOkimgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.estaOkimgPic.TabIndex = 4;
            this.estaOkimgPic.TabStop = false;
            this.estaOkimgPic.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.estaOkimgNav);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.estaOkimgF);
            this.groupBox3.Controls.Add(this.estaOkimg866);
            this.groupBox3.Location = new System.Drawing.Point(6, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 32);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(176, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(109, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trucks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(55, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "F45";
            // 
            // estaOkimgNav
            // 
            this.estaOkimgNav.Image = global::DailyTask.Properties.Resources.A_32x32;
            this.estaOkimgNav.Location = new System.Drawing.Point(146, 0);
            this.estaOkimgNav.Name = "estaOkimgNav";
            this.estaOkimgNav.Size = new System.Drawing.Size(30, 32);
            this.estaOkimgNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.estaOkimgNav.TabIndex = 3;
            this.estaOkimgNav.TabStop = false;
            this.estaOkimgNav.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "866";
            // 
            // estaOkimgF
            // 
            this.estaOkimgF.Image = global::DailyTask.Properties.Resources.A_32x32;
            this.estaOkimgF.Location = new System.Drawing.Point(79, 0);
            this.estaOkimgF.Name = "estaOkimgF";
            this.estaOkimgF.Size = new System.Drawing.Size(30, 32);
            this.estaOkimgF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.estaOkimgF.TabIndex = 2;
            this.estaOkimgF.TabStop = false;
            this.estaOkimgF.Visible = false;
            // 
            // estaOkimg866
            // 
            this.estaOkimg866.Image = global::DailyTask.Properties.Resources.A_32x32;
            this.estaOkimg866.Location = new System.Drawing.Point(25, 0);
            this.estaOkimg866.Name = "estaOkimg866";
            this.estaOkimg866.Size = new System.Drawing.Size(30, 32);
            this.estaOkimg866.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.estaOkimg866.TabIndex = 1;
            this.estaOkimg866.TabStop = false;
            this.estaOkimg866.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(283, 58);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.toolsToolStripMenuItem.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "&Ayuda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "&Ayuda Visual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tareas Diarias de Control de Produccion";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(498, 14);
            this.progressBar1.TabIndex = 4;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Salir...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 242);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tareas Diarias V.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgPic)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimgF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estaOkimg866)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_NavistarTrucks;
        private System.Windows.Forms.Button btn_OchoSeis;
        private System.Windows.Forms.Button btn_picdb;
        private System.Windows.Forms.Button btn_efeq;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox estaOkimgPic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox estaOkimgNav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox estaOkimgF;
        private System.Windows.Forms.PictureBox estaOkimg866;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

