namespace YamahaProgramAnalyzer
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;

        private System.Windows.Forms.Panel pnlImportRow;
        private System.Windows.Forms.Label lblImportCaption;
        private System.Windows.Forms.Button btnOpenYGX;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblDatabaseInfo;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Panel pnlCounters;
        private System.Windows.Forms.Panel pnlMountCounter;
        private System.Windows.Forms.Label lblMountCountTitle;
        private System.Windows.Forms.Label lblMountCount;
        private System.Windows.Forms.Panel pnlPartCounter;
        private System.Windows.Forms.Label lblPartCountTitle;
        private System.Windows.Forms.Label lblPartCount;

        private System.Windows.Forms.TableLayoutPanel tlpSplit;

        private System.Windows.Forms.Panel pnlMountBox;
        private System.Windows.Forms.Panel pnlMountHeader;
        private System.Windows.Forms.ComboBox cmbRefDes;
        private System.Windows.Forms.Button btnResetMount;
        private System.Windows.Forms.Button btnSearchMount;
        private System.Windows.Forms.ComboBox cmbMountInstance;
        private System.Windows.Forms.Label lblMountResultInfo;
        private System.Windows.Forms.DataGridView dgvMountParameter;

        private System.Windows.Forms.Panel pnlPartBox;
        private System.Windows.Forms.Panel pnlPartHeader;
        private System.Windows.Forms.ComboBox cmbPartName;
        private System.Windows.Forms.Button btnResetPart;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.ComboBox cmbPartInstance;
        private System.Windows.Forms.Label lblPartResultInfo;
        private System.Windows.Forms.DataGridView dgvPartParameter;

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlImportRow = new System.Windows.Forms.Panel();
            this.lblImportCaption = new System.Windows.Forms.Label();
            this.btnOpenYGX = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblDatabaseInfo = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlCounters = new System.Windows.Forms.Panel();
            this.pnlMountCounter = new System.Windows.Forms.Panel();
            this.lblMountCountTitle = new System.Windows.Forms.Label();
            this.lblMountCount = new System.Windows.Forms.Label();
            this.pnlPartCounter = new System.Windows.Forms.Panel();
            this.lblPartCountTitle = new System.Windows.Forms.Label();
            this.lblPartCount = new System.Windows.Forms.Label();
            this.tlpSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMountBox = new System.Windows.Forms.Panel();
            this.dgvMountParameter = new System.Windows.Forms.DataGridView();
            this.lblMountResultInfo = new System.Windows.Forms.Label();
            this.cmbMountInstance = new System.Windows.Forms.ComboBox();
            this.pnlMountHeader = new System.Windows.Forms.Panel();
            this.cmbRefDes = new System.Windows.Forms.ComboBox();
            this.btnResetMount = new System.Windows.Forms.Button();
            this.btnSearchMount = new System.Windows.Forms.Button();
            this.pnlPartBox = new System.Windows.Forms.Panel();
            this.dgvPartParameter = new System.Windows.Forms.DataGridView();
            this.lblPartResultInfo = new System.Windows.Forms.Label();
            this.cmbPartInstance = new System.Windows.Forms.ComboBox();
            this.pnlPartHeader = new System.Windows.Forms.Panel();
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.btnResetPart = new System.Windows.Forms.Button();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlImportRow.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlCounters.SuspendLayout();
            this.pnlMountCounter.SuspendLayout();
            this.pnlPartCounter.SuspendLayout();
            this.tlpSplit.SuspendLayout();
            this.pnlMountBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountParameter)).BeginInit();
            this.pnlMountHeader.SuspendLayout();
            this.pnlPartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartParameter)).BeginInit();
            this.pnlPartHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.lblAppSubtitle);
            this.pnlTop.Controls.Add(this.lblAppTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1050, 58);
            this.pnlTop.TabIndex = 4;
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.AutoSize = true;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(20, 36);
            this.lblAppSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(335, 15);
            this.lblAppSubtitle.TabIndex = 0;
            this.lblAppSubtitle.Text = "YGX Program Analysis  •  Mount & Part Parameter Management";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(18, 7);
            this.lblAppTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(377, 32);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "YAMAHA PROGRAM ANALYZER";
            // 
            // pnlImportRow
            // 
            this.pnlImportRow.BackColor = System.Drawing.Color.White;
            this.pnlImportRow.Controls.Add(this.lblImportCaption);
            this.pnlImportRow.Controls.Add(this.btnOpenYGX);
            this.pnlImportRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImportRow.Location = new System.Drawing.Point(0, 58);
            this.pnlImportRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlImportRow.Name = "pnlImportRow";
            this.pnlImportRow.Size = new System.Drawing.Size(1050, 46);
            this.pnlImportRow.TabIndex = 3;
            // 
            // lblImportCaption
            // 
            this.lblImportCaption.AutoSize = true;
            this.lblImportCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblImportCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.lblImportCaption.Location = new System.Drawing.Point(12, 16);
            this.lblImportCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImportCaption.Name = "lblImportCaption";
            this.lblImportCaption.Size = new System.Drawing.Size(151, 17);
            this.lblImportCaption.TabIndex = 0;
            this.lblImportCaption.Text = "Import YGX Pnp Program";
            // 
            // btnOpenYGX
            // 
            this.btnOpenYGX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(95)))));
            this.btnOpenYGX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenYGX.FlatAppearance.BorderSize = 0;
            this.btnOpenYGX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenYGX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenYGX.ForeColor = System.Drawing.Color.White;
            this.btnOpenYGX.Location = new System.Drawing.Point(170, 10);
            this.btnOpenYGX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenYGX.Name = "btnOpenYGX";
            this.btnOpenYGX.Size = new System.Drawing.Size(128, 29);
            this.btnOpenYGX.TabIndex = 1;
            this.btnOpenYGX.Text = "OPEN YGX";
            this.btnOpenYGX.UseVisualStyleBackColor = false;
            this.btnOpenYGX.Click += new System.EventHandler(this.btnOpenYGX_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblFileTitle);
            this.pnlInfo.Controls.Add(this.lblFile);
            this.pnlInfo.Controls.Add(this.lblDatabaseInfo);
            this.pnlInfo.Controls.Add(this.lblStatusTitle);
            this.pnlInfo.Controls.Add(this.lblStatus);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 104);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1050, 43);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblFileTitle
            // 
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFileTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblFileTitle.Location = new System.Drawing.Point(12, 5);
            this.lblFileTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(72, 12);
            this.lblFileTitle.TabIndex = 0;
            this.lblFileTitle.Text = "CURRENT FILE";
            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblFile.Location = new System.Drawing.Point(12, 20);
            this.lblFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(315, 16);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "No YGX file loaded";
            // 
            // lblDatabaseInfo
            // 
            this.lblDatabaseInfo.AutoSize = true;
            this.lblDatabaseInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDatabaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblDatabaseInfo.Location = new System.Drawing.Point(338, 20);
            this.lblDatabaseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabaseInfo.Name = "lblDatabaseInfo";
            this.lblDatabaseInfo.Size = new System.Drawing.Size(145, 15);
            this.lblDatabaseInfo.TabIndex = 2;
            this.lblDatabaseInfo.Text = "Database: 0 Mount | 0 Part";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusTitle.Location = new System.Drawing.Point(1845, 5);
            this.lblStatusTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(41, 12);
            this.lblStatusTitle.TabIndex = 3;
            this.lblStatusTitle.Text = "STATUS";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(1845, 20);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "READY";
            // 
            // pnlCounters
            // 
            this.pnlCounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlCounters.Controls.Add(this.pnlMountCounter);
            this.pnlCounters.Controls.Add(this.pnlPartCounter);
            this.pnlCounters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCounters.Location = new System.Drawing.Point(0, 147);
            this.pnlCounters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCounters.Name = "pnlCounters";
            this.pnlCounters.Size = new System.Drawing.Size(1050, 82);
            this.pnlCounters.TabIndex = 1;
            // 
            // pnlMountCounter
            // 
            this.pnlMountCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(67)))), ((int)(((byte)(105)))));
            this.pnlMountCounter.Controls.Add(this.lblMountCountTitle);
            this.pnlMountCounter.Controls.Add(this.lblMountCount);
            this.pnlMountCounter.Location = new System.Drawing.Point(12, 8);
            this.pnlMountCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMountCounter.Name = "pnlMountCounter";
            this.pnlMountCounter.Size = new System.Drawing.Size(135, 58);
            this.pnlMountCounter.TabIndex = 0;
            // 
            // lblMountCountTitle
            // 
            this.lblMountCountTitle.AutoSize = true;
            this.lblMountCountTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMountCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.lblMountCountTitle.Location = new System.Drawing.Point(9, 6);
            this.lblMountCountTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMountCountTitle.Name = "lblMountCountTitle";
            this.lblMountCountTitle.Size = new System.Drawing.Size(114, 15);
            this.lblMountCountTitle.TabIndex = 0;
            this.lblMountCountTitle.Text = "MOUNT DATABASE";
            // 
            // lblMountCount
            // 
            this.lblMountCount.AutoSize = true;
            this.lblMountCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblMountCount.ForeColor = System.Drawing.Color.White;
            this.lblMountCount.Location = new System.Drawing.Point(9, 21);
            this.lblMountCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMountCount.Name = "lblMountCount";
            this.lblMountCount.Size = new System.Drawing.Size(33, 37);
            this.lblMountCount.TabIndex = 1;
            this.lblMountCount.Text = "0";
            // 
            // pnlPartCounter
            // 
            this.pnlPartCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(135)))));
            this.pnlPartCounter.Controls.Add(this.lblPartCountTitle);
            this.pnlPartCounter.Controls.Add(this.lblPartCount);
            this.pnlPartCounter.Location = new System.Drawing.Point(154, 8);
            this.pnlPartCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPartCounter.Name = "pnlPartCounter";
            this.pnlPartCounter.Size = new System.Drawing.Size(135, 58);
            this.pnlPartCounter.TabIndex = 1;
            // 
            // lblPartCountTitle
            // 
            this.lblPartCountTitle.AutoSize = true;
            this.lblPartCountTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPartCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.lblPartCountTitle.Location = new System.Drawing.Point(9, 6);
            this.lblPartCountTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartCountTitle.Name = "lblPartCountTitle";
            this.lblPartCountTitle.Size = new System.Drawing.Size(98, 15);
            this.lblPartCountTitle.TabIndex = 0;
            this.lblPartCountTitle.Text = "PART DATABASE";
            // 
            // lblPartCount
            // 
            this.lblPartCount.AutoSize = true;
            this.lblPartCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPartCount.ForeColor = System.Drawing.Color.White;
            this.lblPartCount.Location = new System.Drawing.Point(9, 21);
            this.lblPartCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartCount.Name = "lblPartCount";
            this.lblPartCount.Size = new System.Drawing.Size(33, 37);
            this.lblPartCount.TabIndex = 1;
            this.lblPartCount.Text = "0";
            // 
            // tlpSplit
            // 
            this.tlpSplit.ColumnCount = 2;
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Controls.Add(this.pnlMountBox, 0, 0);
            this.tlpSplit.Controls.Add(this.pnlPartBox, 1, 0);
            this.tlpSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplit.Location = new System.Drawing.Point(0, 229);
            this.tlpSplit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpSplit.Name = "tlpSplit";
            this.tlpSplit.Padding = new System.Windows.Forms.Padding(12, 10, 12, 13);
            this.tlpSplit.RowCount = 1;
            this.tlpSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSplit.Size = new System.Drawing.Size(1050, 470);
            this.tlpSplit.TabIndex = 0;
            // 
            // pnlMountBox
            // 
            this.pnlMountBox.BackColor = System.Drawing.Color.White;
            this.pnlMountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMountBox.Controls.Add(this.dgvMountParameter);
            this.pnlMountBox.Controls.Add(this.lblMountResultInfo);
            this.pnlMountBox.Controls.Add(this.cmbMountInstance);
            this.pnlMountBox.Controls.Add(this.pnlMountHeader);
            this.pnlMountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMountBox.Location = new System.Drawing.Point(12, 10);
            this.pnlMountBox.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.pnlMountBox.Name = "pnlMountBox";
            this.pnlMountBox.Size = new System.Drawing.Size(507, 447);
            this.pnlMountBox.TabIndex = 0;
            // 
            // dgvMountParameter
            // 
            this.dgvMountParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMountParameter.Location = new System.Drawing.Point(0, 92);
            this.dgvMountParameter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMountParameter.Name = "dgvMountParameter";
            this.dgvMountParameter.Size = new System.Drawing.Size(505, 353);
            this.dgvMountParameter.TabIndex = 0;
            // 
            // lblMountResultInfo
            // 
            this.lblMountResultInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblMountResultInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMountResultInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMountResultInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblMountResultInfo.Location = new System.Drawing.Point(0, 69);
            this.lblMountResultInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMountResultInfo.Name = "lblMountResultInfo";
            this.lblMountResultInfo.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblMountResultInfo.Size = new System.Drawing.Size(505, 23);
            this.lblMountResultInfo.TabIndex = 1;
            this.lblMountResultInfo.Text = "Pilih Reference Designator, lalu klik Mount Parameter.";
            // 
            // cmbMountInstance
            // 
            this.cmbMountInstance.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMountInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMountInstance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMountInstance.Location = new System.Drawing.Point(0, 46);
            this.cmbMountInstance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMountInstance.Name = "cmbMountInstance";
            this.cmbMountInstance.Size = new System.Drawing.Size(505, 23);
            this.cmbMountInstance.TabIndex = 2;
            this.cmbMountInstance.Visible = false;
            this.cmbMountInstance.SelectedIndexChanged += new System.EventHandler(this.cmbMountInstance_SelectedIndexChanged);
            // 
            // pnlMountHeader
            // 
            this.pnlMountHeader.BackColor = System.Drawing.Color.White;
            this.pnlMountHeader.Controls.Add(this.cmbRefDes);
            this.pnlMountHeader.Controls.Add(this.btnResetMount);
            this.pnlMountHeader.Controls.Add(this.btnSearchMount);
            this.pnlMountHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMountHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMountHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMountHeader.Name = "pnlMountHeader";
            this.pnlMountHeader.Size = new System.Drawing.Size(505, 46);
            this.pnlMountHeader.TabIndex = 3;
            // 
            // cmbRefDes
            // 
            this.cmbRefDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRefDes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.cmbRefDes.Location = new System.Drawing.Point(10, 10);
            this.cmbRefDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRefDes.Name = "cmbRefDes";
            this.cmbRefDes.Size = new System.Drawing.Size(114, 27);
            this.cmbRefDes.TabIndex = 0;
            this.cmbRefDes.SelectedIndexChanged += new System.EventHandler(this.cmbRefDes_SelectedIndexChanged);
            // 
            // btnResetMount
            // 
            this.btnResetMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(95)))));
            this.btnResetMount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetMount.FlatAppearance.BorderSize = 0;
            this.btnResetMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetMount.ForeColor = System.Drawing.Color.White;
            this.btnResetMount.Location = new System.Drawing.Point(129, 10);
            this.btnResetMount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetMount.Name = "btnResetMount";
            this.btnResetMount.Size = new System.Drawing.Size(60, 24);
            this.btnResetMount.TabIndex = 1;
            this.btnResetMount.Text = "RESET";
            this.btnResetMount.UseVisualStyleBackColor = false;
            this.btnResetMount.Click += new System.EventHandler(this.btnResetMount_Click);
            // 
            // btnSearchMount
            // 
            this.btnSearchMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(78)))));
            this.btnSearchMount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMount.FlatAppearance.BorderSize = 0;
            this.btnSearchMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearchMount.ForeColor = System.Drawing.Color.White;
            this.btnSearchMount.Location = new System.Drawing.Point(195, 10);
            this.btnSearchMount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchMount.Name = "btnSearchMount";
            this.btnSearchMount.Size = new System.Drawing.Size(128, 24);
            this.btnSearchMount.TabIndex = 2;
            this.btnSearchMount.Text = "Mount Parameter";
            this.btnSearchMount.UseVisualStyleBackColor = false;
            this.btnSearchMount.Click += new System.EventHandler(this.btnSearchMount_Click);
            // 
            // pnlPartBox
            // 
            this.pnlPartBox.BackColor = System.Drawing.Color.White;
            this.pnlPartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartBox.Controls.Add(this.dgvPartParameter);
            this.pnlPartBox.Controls.Add(this.lblPartResultInfo);
            this.pnlPartBox.Controls.Add(this.cmbPartInstance);
            this.pnlPartBox.Controls.Add(this.pnlPartHeader);
            this.pnlPartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPartBox.Location = new System.Drawing.Point(531, 10);
            this.pnlPartBox.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pnlPartBox.Name = "pnlPartBox";
            this.pnlPartBox.Size = new System.Drawing.Size(507, 447);
            this.pnlPartBox.TabIndex = 1;
            // 
            // dgvPartParameter
            // 
            this.dgvPartParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartParameter.Location = new System.Drawing.Point(0, 92);
            this.dgvPartParameter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPartParameter.Name = "dgvPartParameter";
            this.dgvPartParameter.Size = new System.Drawing.Size(505, 353);
            this.dgvPartParameter.TabIndex = 0;
            // 
            // lblPartResultInfo
            // 
            this.lblPartResultInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblPartResultInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPartResultInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPartResultInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.lblPartResultInfo.Location = new System.Drawing.Point(0, 69);
            this.lblPartResultInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartResultInfo.Name = "lblPartResultInfo";
            this.lblPartResultInfo.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblPartResultInfo.Size = new System.Drawing.Size(505, 23);
            this.lblPartResultInfo.TabIndex = 1;
            this.lblPartResultInfo.Text = "Pilih Part Name, lalu klik PartsParameter.";
            // 
            // cmbPartInstance
            // 
            this.cmbPartInstance.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPartInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartInstance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPartInstance.Location = new System.Drawing.Point(0, 46);
            this.cmbPartInstance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPartInstance.Name = "cmbPartInstance";
            this.cmbPartInstance.Size = new System.Drawing.Size(505, 23);
            this.cmbPartInstance.TabIndex = 2;
            this.cmbPartInstance.Visible = false;
            this.cmbPartInstance.SelectedIndexChanged += new System.EventHandler(this.cmbPartInstance_SelectedIndexChanged);
            // 
            // pnlPartHeader
            // 
            this.pnlPartHeader.BackColor = System.Drawing.Color.White;
            this.pnlPartHeader.Controls.Add(this.cmbPartName);
            this.pnlPartHeader.Controls.Add(this.btnResetPart);
            this.pnlPartHeader.Controls.Add(this.btnSearchPart);
            this.pnlPartHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPartHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlPartHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPartHeader.Name = "pnlPartHeader";
            this.pnlPartHeader.Size = new System.Drawing.Size(505, 46);
            this.pnlPartHeader.TabIndex = 3;
            // 
            // cmbPartName
            // 
            this.cmbPartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPartName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.cmbPartName.Location = new System.Drawing.Point(10, 10);
            this.cmbPartName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(114, 27);
            this.cmbPartName.TabIndex = 0;
            this.cmbPartName.SelectedIndexChanged += new System.EventHandler(this.cmbPartName_SelectedIndexChanged);
            // 
            // btnResetPart
            // 
            this.btnResetPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(95)))));
            this.btnResetPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPart.FlatAppearance.BorderSize = 0;
            this.btnResetPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetPart.ForeColor = System.Drawing.Color.White;
            this.btnResetPart.Location = new System.Drawing.Point(129, 10);
            this.btnResetPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetPart.Name = "btnResetPart";
            this.btnResetPart.Size = new System.Drawing.Size(60, 24);
            this.btnResetPart.TabIndex = 1;
            this.btnResetPart.Text = "RESET";
            this.btnResetPart.UseVisualStyleBackColor = false;
            this.btnResetPart.Click += new System.EventHandler(this.btnResetPart_Click);
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(78)))));
            this.btnSearchPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPart.FlatAppearance.BorderSize = 0;
            this.btnSearchPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearchPart.ForeColor = System.Drawing.Color.White;
            this.btnSearchPart.Location = new System.Drawing.Point(195, 10);
            this.btnSearchPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(128, 24);
            this.btnSearchPart.TabIndex = 2;
            this.btnSearchPart.Text = "PartsParameter";
            this.btnSearchPart.UseVisualStyleBackColor = false;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1050, 699);
            this.Controls.Add(this.tlpSplit);
            this.Controls.Add(this.pnlCounters);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlImportRow);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(866, 576);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yamaha Program Analyzer";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlImportRow.ResumeLayout(false);
            this.pnlImportRow.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlCounters.ResumeLayout(false);
            this.pnlMountCounter.ResumeLayout(false);
            this.pnlMountCounter.PerformLayout();
            this.pnlPartCounter.ResumeLayout(false);
            this.pnlPartCounter.PerformLayout();
            this.tlpSplit.ResumeLayout(false);
            this.pnlMountBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMountParameter)).EndInit();
            this.pnlMountHeader.ResumeLayout(false);
            this.pnlPartBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartParameter)).EndInit();
            this.pnlPartHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}