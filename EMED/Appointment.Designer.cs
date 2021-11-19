namespace EMED
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uInfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.uInfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDBDataSet = new EMED.MedDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.panelmBtnPrescribe = new System.Windows.Forms.Panel();
            this.mbtnAppointment = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblAText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uInfDataGridView = new System.Windows.Forms.DataGridView();
            this.uInfTableAdapter = new EMED.MedDBDataSetTableAdapters.UInfTableAdapter();
            this.tableAdapterManager = new EMED.MedDBDataSetTableAdapters.TableAdapterManager();
            this.dOCTORToolStrip = new System.Windows.Forms.ToolStrip();
            this.dOCTORToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelExit = new System.Windows.Forms.Panel();
            this.mbtnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uInfBindingNavigator)).BeginInit();
            this.uInfBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uInfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).BeginInit();
            this.panelmBtnPrescribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uInfDataGridView)).BeginInit();
            this.dOCTORToolStrip.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.panelStatus);
            this.panel1.Controls.Add(this.txtQualification);
            this.panel1.Controls.Add(this.panelmBtnPrescribe);
            this.panel1.Controls.Add(this.lblAText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.uInfDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 521);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uInfBindingNavigator);
            this.panel2.Location = new System.Drawing.Point(19, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 46);
            this.panel2.TabIndex = 18;
            // 
            // uInfBindingNavigator
            // 
            this.uInfBindingNavigator.AddNewItem = null;
            this.uInfBindingNavigator.BackgroundImage = global::EMED.Properties.Resources.Old_Map__38_;
            this.uInfBindingNavigator.BindingSource = this.uInfBindingSource;
            this.uInfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uInfBindingNavigator.DeleteItem = null;
            this.uInfBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uInfBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uInfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.uInfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uInfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uInfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uInfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uInfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uInfBindingNavigator.Name = "uInfBindingNavigator";
            this.uInfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uInfBindingNavigator.Size = new System.Drawing.Size(594, 46);
            this.uInfBindingNavigator.TabIndex = 1;
            this.uInfBindingNavigator.Text = "bindingNavigator1";
            // 
            // uInfBindingSource
            // 
            this.uInfBindingSource.DataMember = "UInf";
            this.uInfBindingSource.DataSource = this.medDBDataSet;
            // 
            // medDBDataSet
            // 
            this.medDBDataSet.DataSetName = "MedDBDataSet";
            this.medDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 43);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 43);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 43);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.SteelBlue;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 43);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 43);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(968, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "STATUS";
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackgroundImage = global::EMED.Properties.Resources.double_left_100px;
            this.panelStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStatus.Location = new System.Drawing.Point(966, 12);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(65, 66);
            this.panelStatus.TabIndex = 16;
            // 
            // txtQualification
            // 
            this.txtQualification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtQualification.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtQualification.Location = new System.Drawing.Point(629, 401);
            this.txtQualification.Multiline = true;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.ReadOnly = true;
            this.txtQualification.Size = new System.Drawing.Size(320, 112);
            this.txtQualification.TabIndex = 15;
            this.txtQualification.Text = "qualification";
            // 
            // panelmBtnPrescribe
            // 
            this.panelmBtnPrescribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmBtnPrescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelmBtnPrescribe.Controls.Add(this.mbtnAppointment);
            this.panelmBtnPrescribe.Location = new System.Drawing.Point(629, 309);
            this.panelmBtnPrescribe.Name = "panelmBtnPrescribe";
            this.panelmBtnPrescribe.Size = new System.Drawing.Size(320, 49);
            this.panelmBtnPrescribe.TabIndex = 14;
            // 
            // mbtnAppointment
            // 
            this.mbtnAppointment.AutoSize = true;
            this.mbtnAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAppointment.Depth = 0;
            this.mbtnAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnAppointment.Icon = null;
            this.mbtnAppointment.Location = new System.Drawing.Point(0, 0);
            this.mbtnAppointment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAppointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAppointment.Name = "mbtnAppointment";
            this.mbtnAppointment.Primary = false;
            this.mbtnAppointment.Size = new System.Drawing.Size(320, 49);
            this.mbtnAppointment.TabIndex = 3;
            this.mbtnAppointment.Text = "Not Selected";
            this.mbtnAppointment.UseVisualStyleBackColor = true;
            this.mbtnAppointment.Click += new System.EventHandler(this.mbtnAppointment_Click);
            // 
            // lblAText
            // 
            this.lblAText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAText.AutoSize = true;
            this.lblAText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAText.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAText.Location = new System.Drawing.Point(667, 363);
            this.lblAText.Name = "lblAText";
            this.lblAText.Size = new System.Drawing.Size(248, 22);
            this.lblAText.TabIndex = 13;
            this.lblAText.Text = "click button for/cancel an appointment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(629, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // uInfDataGridView
            // 
            this.uInfDataGridView.AllowUserToAddRows = false;
            this.uInfDataGridView.AllowUserToDeleteRows = false;
            this.uInfDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(142)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uInfDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.uInfDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uInfDataGridView.AutoGenerateColumns = false;
            this.uInfDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.uInfDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.uInfDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uInfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uInfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.gender,
            this.qo,
            this.department});
            this.uInfDataGridView.DataSource = this.uInfBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uInfDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.uInfDataGridView.Location = new System.Drawing.Point(19, 12);
            this.uInfDataGridView.Name = "uInfDataGridView";
            this.uInfDataGridView.ReadOnly = true;
            this.uInfDataGridView.RowHeadersWidth = 51;
            this.uInfDataGridView.RowTemplate.Height = 24;
            this.uInfDataGridView.Size = new System.Drawing.Size(594, 427);
            this.uInfDataGridView.TabIndex = 1;
            this.uInfDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.uInfDataGridView_CellEnter);
            // 
            // uInfTableAdapter
            // 
            this.uInfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.UInfTableAdapter = this.uInfTableAdapter;
            this.tableAdapterManager.UpdateOrder = EMED.MedDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dOCTORToolStrip
            // 
            this.dOCTORToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dOCTORToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dOCTORToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOCTORToolStripButton});
            this.dOCTORToolStrip.Location = new System.Drawing.Point(0, 76);
            this.dOCTORToolStrip.Name = "dOCTORToolStrip";
            this.dOCTORToolStrip.Size = new System.Drawing.Size(1050, 27);
            this.dOCTORToolStrip.TabIndex = 2;
            this.dOCTORToolStrip.Text = "dOCTORToolStrip";
            this.dOCTORToolStrip.Visible = false;
            // 
            // dOCTORToolStripButton
            // 
            this.dOCTORToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dOCTORToolStripButton.Name = "dOCTORToolStripButton";
            this.dOCTORToolStripButton.Size = new System.Drawing.Size(71, 24);
            this.dOCTORToolStripButton.Text = "DOCTOR";
            this.dOCTORToolStripButton.Click += new System.EventHandler(this.dOCTORToolStripButton_Click);
            // 
            // panelExit
            // 
            this.panelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExit.Controls.Add(this.mbtnExit);
            this.panelExit.Location = new System.Drawing.Point(981, 28);
            this.panelExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(70, 29);
            this.panelExit.TabIndex = 131;
            // 
            // mbtnExit
            // 
            this.mbtnExit.AutoSize = true;
            this.mbtnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnExit.Depth = 0;
            this.mbtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnExit.Icon = null;
            this.mbtnExit.Location = new System.Drawing.Point(0, 0);
            this.mbtnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Primary = false;
            this.mbtnExit.Size = new System.Drawing.Size(70, 29);
            this.mbtnExit.TabIndex = 126;
            this.mbtnExit.Text = "EXIT";
            this.mbtnExit.UseVisualStyleBackColor = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnBack.BackgroundImage = global::EMED.Properties.Resources.return_40px;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(1, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 29);
            this.btnBack.TabIndex = 47;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 74;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 85;
            // 
            // qo
            // 
            this.qo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qo.DataPropertyName = "qo";
            this.qo.HeaderText = "Qualification";
            this.qo.MinimumWidth = 6;
            this.qo.Name = "qo";
            this.qo.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 111;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 586);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.dOCTORToolStrip);
            this.Controls.Add(this.panel1);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uInfBindingNavigator)).EndInit();
            this.uInfBindingNavigator.ResumeLayout(false);
            this.uInfBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uInfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).EndInit();
            this.panelmBtnPrescribe.ResumeLayout(false);
            this.panelmBtnPrescribe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uInfDataGridView)).EndInit();
            this.dOCTORToolStrip.ResumeLayout(false);
            this.dOCTORToolStrip.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MedDBDataSet medDBDataSet;
        private System.Windows.Forms.BindingSource uInfBindingSource;
        private MedDBDataSetTableAdapters.UInfTableAdapter uInfTableAdapter;
        private MedDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uInfBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView uInfDataGridView;
        private System.Windows.Forms.Panel panelmBtnPrescribe;
        private MaterialSkin.Controls.MaterialFlatButton mbtnAppointment;
        private System.Windows.Forms.Label lblAText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ToolStrip dOCTORToolStrip;
        private System.Windows.Forms.ToolStripButton dOCTORToolStripButton;
        private System.Windows.Forms.Panel panelExit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn qo;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}