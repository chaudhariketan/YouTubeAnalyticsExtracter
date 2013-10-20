namespace YouTubeAnalyticsExtracter
{
    partial class Analytics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmitQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dgYouTubeResponse = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.lblRefreshToken = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.lblClientSecret = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblResourceId = new System.Windows.Forms.Label();
            this.txtResourceId = new System.Windows.Forms.TextBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.lblMetric = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbResourceType = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lstMetrics = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYouTubeResponse)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitQuery
            // 
            this.btnSubmitQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitQuery.Location = new System.Drawing.Point(141, 269);
            this.btnSubmitQuery.Name = "btnSubmitQuery";
            this.btnSubmitQuery.Size = new System.Drawing.Size(75, 33);
            this.btnSubmitQuery.TabIndex = 8;
            this.btnSubmitQuery.Text = "Submit";
            this.btnSubmitQuery.UseVisualStyleBackColor = true;
            this.btnSubmitQuery.Click += new System.EventHandler(this.btnSubmitQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelProgress);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.dgYouTubeResponse);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 636);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YouTube Analytics";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(784, 222);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 18);
            this.labelProgress.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(778, 134);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 80);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // dgYouTubeResponse
            // 
            this.dgYouTubeResponse.AllowUserToAddRows = false;
            this.dgYouTubeResponse.AllowUserToDeleteRows = false;
            this.dgYouTubeResponse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgYouTubeResponse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgYouTubeResponse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgYouTubeResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYouTubeResponse.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgYouTubeResponse.Location = new System.Drawing.Point(19, 331);
            this.dgYouTubeResponse.Name = "dgYouTubeResponse";
            this.dgYouTubeResponse.ReadOnly = true;
            this.dgYouTubeResponse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgYouTubeResponse.Size = new System.Drawing.Size(942, 288);
            this.dgYouTubeResponse.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.Controls.Add(this.txtRefreshToken, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRefreshToken, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClientId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClientSecret, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClientSecret, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClientId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResourceId, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtResourceId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblResourceType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMetric, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmitQuery, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblEndDate, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbResourceType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpStartDate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lstMetrics, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 319);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Location = new System.Drawing.Point(141, 68);
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.Size = new System.Drawing.Size(484, 24);
            this.txtRefreshToken.TabIndex = 2;
            // 
            // lblRefreshToken
            // 
            this.lblRefreshToken.AutoSize = true;
            this.lblRefreshToken.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRefreshToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshToken.Location = new System.Drawing.Point(21, 65);
            this.lblRefreshToken.Name = "lblRefreshToken";
            this.lblRefreshToken.Size = new System.Drawing.Size(114, 32);
            this.lblRefreshToken.TabIndex = 4;
            this.lblRefreshToken.Text = "Refresh Token :";
            this.lblRefreshToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(141, 3);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(484, 24);
            this.txtClientId.TabIndex = 0;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(141, 37);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(484, 24);
            this.txtClientSecret.TabIndex = 1;
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.AutoSize = true;
            this.lblClientSecret.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientSecret.Location = new System.Drawing.Point(35, 34);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(100, 31);
            this.lblClientSecret.TabIndex = 3;
            this.lblClientSecret.Text = "Client Secret :";
            this.lblClientSecret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(67, 0);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClientId.Size = new System.Drawing.Size(68, 34);
            this.lblClientId.TabIndex = 2;
            this.lblClientId.Text = "Client Id :";
            this.lblClientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResourceId
            // 
            this.lblResourceId.AutoSize = true;
            this.lblResourceId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResourceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceId.Location = new System.Drawing.Point(39, 97);
            this.lblResourceId.Name = "lblResourceId";
            this.lblResourceId.Size = new System.Drawing.Size(96, 31);
            this.lblResourceId.TabIndex = 6;
            this.lblResourceId.Text = "Resource Id :";
            this.lblResourceId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResourceId
            // 
            this.txtResourceId.Location = new System.Drawing.Point(141, 100);
            this.txtResourceId.Name = "txtResourceId";
            this.txtResourceId.Size = new System.Drawing.Size(484, 24);
            this.txtResourceId.TabIndex = 3;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblResourceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceType.Location = new System.Drawing.Point(22, 128);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(113, 31);
            this.lblResourceType.TabIndex = 8;
            this.lblResourceType.Text = "ResourceType :";
            this.lblResourceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMetric
            // 
            this.lblMetric.AutoSize = true;
            this.lblMetric.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric.Location = new System.Drawing.Point(78, 159);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(57, 48);
            this.lblMetric.TabIndex = 10;
            this.lblMetric.Text = "Metric :";
            this.lblMetric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(53, 207);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 30);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date :";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(58, 237);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 29);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "End Date :";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbResourceType
            // 
            this.cmbResourceType.FormattingEnabled = true;
            this.cmbResourceType.Items.AddRange(new object[] {
            "channel"});
            this.cmbResourceType.Location = new System.Drawing.Point(141, 131);
            this.cmbResourceType.Name = "cmbResourceType";
            this.cmbResourceType.Size = new System.Drawing.Size(257, 26);
            this.cmbResourceType.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "\"ddd dd MMM yyyy\"";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(141, 210);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(209, 24);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "ddd dd MMM yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(141, 240);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(209, 24);
            this.dtpEndDate.TabIndex = 7;
            // 
            // lstMetrics
            // 
            this.lstMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMetrics.FormattingEnabled = true;
            this.lstMetrics.ItemHeight = 18;
            this.lstMetrics.Items.AddRange(new object[] {
            "favoritesAdded",
            "favoritesRemoved",
            "views",
            "comments",
            "likes",
            "dislikes",
            "shares",
            "estimatedMinutesWatched",
            "averageViewDuration",
            "averageViewPercentage",
            "annotationClickThroughRate",
            "annotationCloseRate",
            "subscribersGained",
            "subscribersLost"});
            this.lstMetrics.Location = new System.Drawing.Point(141, 164);
            this.lstMetrics.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lstMetrics.Name = "lstMetrics";
            this.lstMetrics.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMetrics.Size = new System.Drawing.Size(257, 40);
            this.lstMetrics.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1004, 660);
            this.Controls.Add(this.groupBox1);
            this.Name = "Analytics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYouTubeResponse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label lblClientSecret;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtRefreshToken;
        private System.Windows.Forms.Label lblRefreshToken;
        private System.Windows.Forms.Label lblResourceId;
        private System.Windows.Forms.TextBox txtResourceId;
        private System.Windows.Forms.Label lblResourceType;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DataGridView dgYouTubeResponse;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cmbResourceType;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox lstMetrics;
        private System.Windows.Forms.Label labelProgress;
    }
}

