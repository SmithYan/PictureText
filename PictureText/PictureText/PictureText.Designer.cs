namespace PictureText
{
    partial class PictureText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureText));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sSMain = new System.Windows.Forms.StatusStrip();
            this.tSSLFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSCenter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSMain = new System.Windows.Forms.ToolStrip();
            this.tSBOpenExcel = new System.Windows.Forms.ToolStripButton();
            this.tSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBDelete = new System.Windows.Forms.ToolStripButton();
            this.tSBClear = new System.Windows.Forms.ToolStripButton();
            this.tSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBStart = new System.Windows.Forms.ToolStripButton();
            this.tSBPause = new System.Windows.Forms.ToolStripButton();
            this.tSBStop = new System.Windows.Forms.ToolStripButton();
            this.tSS3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSSShowFile = new System.Windows.Forms.ToolStripButton();
            this.sCMain = new System.Windows.Forms.SplitContainer();
            this.pCPicture = new System.Windows.Forms.SplitContainer();
            this.pBOutput = new System.Windows.Forms.PictureBox();
            this.pBSource = new System.Windows.Forms.PictureBox();
            this.dGVShow = new System.Windows.Forms.DataGridView();
            this.cMSTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示输出文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.tSSLFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSMain.SuspendLayout();
            this.tSMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).BeginInit();
            this.sCMain.Panel1.SuspendLayout();
            this.sCMain.Panel2.SuspendLayout();
            this.sCMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPicture)).BeginInit();
            this.pCPicture.Panel1.SuspendLayout();
            this.pCPicture.Panel2.SuspendLayout();
            this.pCPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).BeginInit();
            this.cMSTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // sSMain
            // 
            this.sSMain.AutoSize = false;
            this.sSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLFolder,
            this.tSSLFont,
            this.tSSLLocation,
            this.tSCenter});
            this.sSMain.Location = new System.Drawing.Point(0, 550);
            this.sSMain.Name = "sSMain";
            this.sSMain.Size = new System.Drawing.Size(1091, 45);
            this.sSMain.TabIndex = 0;
            // 
            // tSSLFolder
            // 
            this.tSSLFolder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tSSLFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.tSSLFolder.Name = "tSSLFolder";
            this.tSSLFolder.Size = new System.Drawing.Size(172, 36);
            this.tSSLFolder.Text = "请配置输出文件夹";
            this.tSSLFolder.Click += new System.EventHandler(this.tSSFolder_Click);
            // 
            // tSCenter
            // 
            this.tSCenter.AutoSize = false;
            this.tSCenter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tSCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tSCenter.Name = "tSCenter";
            this.tSCenter.Size = new System.Drawing.Size(457, 45);
            this.tSCenter.Spring = true;
            // 
            // tSMain
            // 
            this.tSMain.AutoSize = false;
            this.tSMain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBOpenExcel,
            this.tSS1,
            this.tSBDelete,
            this.tSBClear,
            this.tSS2,
            this.tSBStart,
            this.tSBPause,
            this.tSBStop,
            this.tSS3,
            this.tSSShowFile});
            this.tSMain.Location = new System.Drawing.Point(0, 0);
            this.tSMain.Name = "tSMain";
            this.tSMain.Size = new System.Drawing.Size(1091, 59);
            this.tSMain.TabIndex = 2;
            this.tSMain.Text = "工具栏";
            // 
            // tSBOpenExcel
            // 
            this.tSBOpenExcel.AutoSize = false;
            this.tSBOpenExcel.Image = ((System.Drawing.Image)(resources.GetObject("tSBOpenExcel.Image")));
            this.tSBOpenExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBOpenExcel.Name = "tSBOpenExcel";
            this.tSBOpenExcel.Size = new System.Drawing.Size(135, 45);
            this.tSBOpenExcel.Text = "打开Excel文件";
            this.tSBOpenExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSBOpenExcel.Click += new System.EventHandler(this.tSBOpenExcel_Click);
            // 
            // tSS1
            // 
            this.tSS1.Name = "tSS1";
            this.tSS1.Size = new System.Drawing.Size(6, 59);
            // 
            // tSBDelete
            // 
            this.tSBDelete.AutoSize = false;
            this.tSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("tSBDelete.Image")));
            this.tSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDelete.Name = "tSBDelete";
            this.tSBDelete.Size = new System.Drawing.Size(75, 45);
            this.tSBDelete.Text = " 移除";
            this.tSBDelete.Click += new System.EventHandler(this.tSBDelete_Click);
            // 
            // tSBClear
            // 
            this.tSBClear.AutoSize = false;
            this.tSBClear.AutoToolTip = false;
            this.tSBClear.Image = global::PictureText.Properties.Resources.清除;
            this.tSBClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBClear.Name = "tSBClear";
            this.tSBClear.Size = new System.Drawing.Size(75, 45);
            this.tSBClear.Text = " 清除";
            this.tSBClear.ToolTipText = "清除";
            this.tSBClear.Click += new System.EventHandler(this.tSBClear_Click);
            // 
            // tSS2
            // 
            this.tSS2.Name = "tSS2";
            this.tSS2.Size = new System.Drawing.Size(6, 59);
            // 
            // tSBStart
            // 
            this.tSBStart.AutoSize = false;
            this.tSBStart.Image = global::PictureText.Properties.Resources.开始;
            this.tSBStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBStart.Name = "tSBStart";
            this.tSBStart.Size = new System.Drawing.Size(75, 45);
            this.tSBStart.Text = " 开始";
            this.tSBStart.Click += new System.EventHandler(this.tSBStart_Click);
            // 
            // tSBPause
            // 
            this.tSBPause.AutoSize = false;
            this.tSBPause.Image = global::PictureText.Properties.Resources.暂停;
            this.tSBPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBPause.Name = "tSBPause";
            this.tSBPause.Size = new System.Drawing.Size(75, 45);
            this.tSBPause.Text = "暂停";
            this.tSBPause.Click += new System.EventHandler(this.tSBPause_Click);
            // 
            // tSBStop
            // 
            this.tSBStop.AutoSize = false;
            this.tSBStop.Image = global::PictureText.Properties.Resources.停止;
            this.tSBStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBStop.Name = "tSBStop";
            this.tSBStop.Size = new System.Drawing.Size(75, 45);
            this.tSBStop.Text = " 停止";
            this.tSBStop.Click += new System.EventHandler(this.tSBStop_Click);
            // 
            // tSS3
            // 
            this.tSS3.Name = "tSS3";
            this.tSS3.Size = new System.Drawing.Size(6, 59);
            // 
            // tSSShowFile
            // 
            this.tSSShowFile.AutoSize = false;
            this.tSSShowFile.Image = global::PictureText.Properties.Resources.文件夹;
            this.tSSShowFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSSShowFile.Name = "tSSShowFile";
            this.tSSShowFile.Size = new System.Drawing.Size(120, 45);
            this.tSSShowFile.Text = "输出文件夹";
            this.tSSShowFile.Click += new System.EventHandler(this.tSSShowFile_Click);
            // 
            // sCMain
            // 
            this.sCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCMain.Location = new System.Drawing.Point(0, 59);
            this.sCMain.Name = "sCMain";
            // 
            // sCMain.Panel1
            // 
            this.sCMain.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sCMain.Panel1.Controls.Add(this.pCPicture);
            // 
            // sCMain.Panel2
            // 
            this.sCMain.Panel2.Controls.Add(this.dGVShow);
            this.sCMain.Size = new System.Drawing.Size(1091, 491);
            this.sCMain.SplitterDistance = 363;
            this.sCMain.TabIndex = 3;
            // 
            // pCPicture
            // 
            this.pCPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCPicture.Location = new System.Drawing.Point(0, 0);
            this.pCPicture.Name = "pCPicture";
            this.pCPicture.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pCPicture.Panel1
            // 
            this.pCPicture.Panel1.Controls.Add(this.pBOutput);
            // 
            // pCPicture.Panel2
            // 
            this.pCPicture.Panel2.Controls.Add(this.pBSource);
            this.pCPicture.Size = new System.Drawing.Size(363, 491);
            this.pCPicture.SplitterDistance = 242;
            this.pCPicture.SplitterWidth = 6;
            this.pCPicture.TabIndex = 0;
            // 
            // pBOutput
            // 
            this.pBOutput.BackColor = System.Drawing.Color.DimGray;
            this.pBOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBOutput.Location = new System.Drawing.Point(0, 0);
            this.pBOutput.Name = "pBOutput";
            this.pBOutput.Size = new System.Drawing.Size(363, 242);
            this.pBOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBOutput.TabIndex = 0;
            this.pBOutput.TabStop = false;
            // 
            // pBSource
            // 
            this.pBSource.BackColor = System.Drawing.Color.DodgerBlue;
            this.pBSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBSource.Location = new System.Drawing.Point(0, 0);
            this.pBSource.Name = "pBSource";
            this.pBSource.Size = new System.Drawing.Size(363, 243);
            this.pBSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSource.TabIndex = 0;
            this.pBSource.TabStop = false;
            // 
            // dGVShow
            // 
            this.dGVShow.AllowUserToAddRows = false;
            this.dGVShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGVShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dGVShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVShow.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.content,
            this.state});
            this.dGVShow.ContextMenuStrip = this.cMSTask;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVShow.DefaultCellStyle = dataGridViewCellStyle43;
            this.dGVShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVShow.Location = new System.Drawing.Point(0, 0);
            this.dGVShow.Name = "dGVShow";
            this.dGVShow.ReadOnly = true;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dGVShow.RowHeadersVisible = false;
            this.dGVShow.RowTemplate.Height = 27;
            this.dGVShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVShow.Size = new System.Drawing.Size(724, 491);
            this.dGVShow.TabIndex = 0;
            // 
            // cMSTask
            // 
            this.cMSTask.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMSTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.结束ToolStripMenuItem,
            this.移除ToolStripMenuItem,
            this.清除所有ToolStripMenuItem,
            this.显示输出文件夹ToolStripMenuItem});
            this.cMSTask.Name = "cMSTask";
            this.cMSTask.Size = new System.Drawing.Size(184, 148);
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.tSBStart_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.tSBPause_Click);
            // 
            // 结束ToolStripMenuItem
            // 
            this.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem";
            this.结束ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.结束ToolStripMenuItem.Text = "结束";
            this.结束ToolStripMenuItem.Click += new System.EventHandler(this.tSBStop_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.tSBDelete_Click);
            // 
            // 清除所有ToolStripMenuItem
            // 
            this.清除所有ToolStripMenuItem.Name = "清除所有ToolStripMenuItem";
            this.清除所有ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.清除所有ToolStripMenuItem.Text = "清除所有";
            this.清除所有ToolStripMenuItem.Click += new System.EventHandler(this.tSBClear_Click);
            // 
            // 显示输出文件夹ToolStripMenuItem
            // 
            this.显示输出文件夹ToolStripMenuItem.Name = "显示输出文件夹ToolStripMenuItem";
            this.显示输出文件夹ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.显示输出文件夹ToolStripMenuItem.Text = "显示输出文件夹";
            this.显示输出文件夹ToolStripMenuItem.Click += new System.EventHandler(this.tSSShowFile_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.Color.Red;
            this.fontDialog.Font = new System.Drawing.Font("华文新魏", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            this.fontDialog.ShowHelp = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // tSSLFont
            // 
            this.tSSLFont.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tSSLFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.tSSLFont.Name = "tSSLFont";
            this.tSSLFont.Size = new System.Drawing.Size(112, 36);
            this.tSSLFont.Text = "请配置字体";
            this.tSSLFont.Click += new System.EventHandler(this.tSSLFont_Click);
            // 
            // tSSLLocation
            // 
            this.tSSLLocation.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tSSLLocation.Margin = new System.Windows.Forms.Padding(3, 4, 6, 5);
            this.tSSLLocation.Name = "tSSLLocation";
            this.tSSLLocation.Size = new System.Drawing.Size(112, 36);
            this.tSSLLocation.Text = "请配置位置";
            this.tSSLLocation.Click += new System.EventHandler(this.tSSLLocation_Click);
            // 
            // id
            // 
            dataGridViewCellStyle37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.DefaultCellStyle = dataGridViewCellStyle37;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // content
            // 
            dataGridViewCellStyle38.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.content.DefaultCellStyle = dataGridViewCellStyle38;
            this.content.HeaderText = "content";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // state
            // 
            dataGridViewCellStyle42.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.state.DefaultCellStyle = dataGridViewCellStyle42;
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // PictureText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1091, 595);
            this.Controls.Add(this.sCMain);
            this.Controls.Add(this.tSMain);
            this.Controls.Add(this.sSMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureText";
            this.Text = "图片文字合成";
            this.Resize += new System.EventHandler(this.PictureText_Resize);
            this.sSMain.ResumeLayout(false);
            this.sSMain.PerformLayout();
            this.tSMain.ResumeLayout(false);
            this.tSMain.PerformLayout();
            this.sCMain.Panel1.ResumeLayout(false);
            this.sCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).EndInit();
            this.sCMain.ResumeLayout(false);
            this.pCPicture.Panel1.ResumeLayout(false);
            this.pCPicture.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCPicture)).EndInit();
            this.pCPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).EndInit();
            this.cMSTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tSMain;
        private System.Windows.Forms.ToolStripButton tSBDelete;
        private System.Windows.Forms.ToolStripButton tSBClear;
        private System.Windows.Forms.ToolStripButton tSBOpenExcel;
        private System.Windows.Forms.ToolStripSeparator tSS1;
        private System.Windows.Forms.ToolStripSeparator tSS2;
        private System.Windows.Forms.ToolStripButton tSBStart;
        private System.Windows.Forms.ToolStripButton tSBStop;
        private System.Windows.Forms.SplitContainer sCMain;
        private System.Windows.Forms.SplitContainer pCPicture;
        private System.Windows.Forms.PictureBox pBOutput;
        private System.Windows.Forms.PictureBox pBSource;
        private System.Windows.Forms.DataGridView dGVShow;
        private System.Windows.Forms.ToolStripSeparator tSS3;
        private System.Windows.Forms.ContextMenuStrip cMSTask;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除所有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示输出文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tSBPause;
        private System.Windows.Forms.ToolStripButton tSSShowFile;
        private System.Windows.Forms.ToolStripStatusLabel tSSLFolder;
        private System.Windows.Forms.ToolStripStatusLabel tSCenter;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripStatusLabel tSSLFont;
        private System.Windows.Forms.ToolStripStatusLabel tSSLLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        public System.Windows.Forms.StatusStrip sSMain;
    }
}