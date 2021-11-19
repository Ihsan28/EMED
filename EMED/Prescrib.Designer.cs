namespace EMED
{
    partial class Prescrib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescrib));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCurrPrescription = new System.Windows.Forms.Button();
            this.btnPrevPrescription = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDBDataSet = new EMED.MedDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelmBtnName = new System.Windows.Forms.Panel();
            this.mbtnPrescrib = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxtPrescription = new System.Windows.Forms.RichTextBox();
            this.panelPrescriebed = new System.Windows.Forms.Panel();
            this.mbtnPrescriebed = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelExit = new System.Windows.Forms.Panel();
            this.mbtnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.reportTableAdapter = new EMED.MedDBDataSetTableAdapters.reportTableAdapter();
            this.tableAdapterManager = new EMED.MedDBDataSetTableAdapters.TableAdapterManager();
            this.rtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).BeginInit();
            this.reportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).BeginInit();
            this.panelmBtnName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrescriebed.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCurrPrescription);
            this.panel1.Controls.Add(this.btnPrevPrescription);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelmBtnName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportDataGridView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rtxtPrescription);
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 517);
            this.panel1.TabIndex = 0;
            // 
            // btnCurrPrescription
            // 
            this.btnCurrPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCurrPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCurrPrescription.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrPrescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCurrPrescription.Location = new System.Drawing.Point(1140, 13);
            this.btnCurrPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrPrescription.Name = "btnCurrPrescription";
            this.btnCurrPrescription.Size = new System.Drawing.Size(67, 27);
            this.btnCurrPrescription.TabIndex = 21;
            this.btnCurrPrescription.Text = "CURR";
            this.btnCurrPrescription.UseVisualStyleBackColor = false;
            this.btnCurrPrescription.Click += new System.EventHandler(this.btnCurrPrescription_Click);
            // 
            // btnPrevPrescription
            // 
            this.btnPrevPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPrevPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevPrescription.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPrescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevPrescription.Location = new System.Drawing.Point(833, 15);
            this.btnPrevPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevPrescription.Name = "btnPrevPrescription";
            this.btnPrevPrescription.Size = new System.Drawing.Size(67, 27);
            this.btnPrevPrescription.TabIndex = 20;
            this.btnPrevPrescription.Text = "PREV";
            this.btnPrevPrescription.UseVisualStyleBackColor = false;
            this.btnPrevPrescription.Click += new System.EventHandler(this.btnPrevPrescription_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel3.Controls.Add(this.btnDate);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(7, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 27);
            this.panel3.TabIndex = 18;
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDate.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDate.Location = new System.Drawing.Point(3, 0);
            this.btnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(139, 27);
            this.btnDate.TabIndex = 19;
            this.btnDate.Text = "DATE";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 2);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportBindingNavigator);
            this.panel2.Location = new System.Drawing.Point(7, 127);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 33);
            this.panel2.TabIndex = 16;
            // 
            // reportBindingNavigator
            // 
            this.reportBindingNavigator.AddNewItem = null;
            this.reportBindingNavigator.BackgroundImage = global::EMED.Properties.Resources._732884_amazing_inspirational_wallpaper;
            this.reportBindingNavigator.BindingSource = this.reportBindingSource;
            this.reportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportBindingNavigator.DeleteItem = null;
            this.reportBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.reportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.reportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportBindingNavigator.Name = "reportBindingNavigator";
            this.reportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportBindingNavigator.Size = new System.Drawing.Size(459, 33);
            this.reportBindingNavigator.TabIndex = 1;
            this.reportBindingNavigator.Text = "bindingNavigator1";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.medDBDataSet;
            // 
            // medDBDataSet
            // 
            this.medDBDataSet.DataSetName = "MedDBDataSet";
            this.medDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 30);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 30);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 30);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 30);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(578, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "REPORT";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAge.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAge.Location = new System.Drawing.Point(84, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(65, 25);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "AGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "AGE : ";
            // 
            // panelmBtnName
            // 
            this.panelmBtnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelmBtnName.Controls.Add(this.mbtnPrescrib);
            this.panelmBtnName.Location = new System.Drawing.Point(7, 49);
            this.panelmBtnName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmBtnName.Name = "panelmBtnName";
            this.panelmBtnName.Size = new System.Drawing.Size(457, 41);
            this.panelmBtnName.TabIndex = 12;
            // 
            // mbtnPrescrib
            // 
            this.mbtnPrescrib.AutoSize = true;
            this.mbtnPrescrib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPrescrib.Depth = 0;
            this.mbtnPrescrib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnPrescrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnPrescrib.Icon = null;
            this.mbtnPrescrib.Location = new System.Drawing.Point(0, 0);
            this.mbtnPrescrib.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPrescrib.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPrescrib.Name = "mbtnPrescrib";
            this.mbtnPrescrib.Primary = false;
            this.mbtnPrescrib.Size = new System.Drawing.Size(457, 41);
            this.mbtnPrescrib.TabIndex = 3;
            this.mbtnPrescrib.Text = "Not Selected";
            this.mbtnPrescrib.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(919, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRESCRIPTION";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(60)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.reportDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.reportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.reportDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.reportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rtype,
            this.date,
            this.ID});
            this.reportDataGridView.DataSource = this.reportBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(34)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.reportDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportDataGridView.Location = new System.Drawing.Point(5, 158);
            this.reportDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.RowHeadersVisible = false;
            this.reportDataGridView.RowHeadersWidth = 20;
            this.reportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.reportDataGridView.RowTemplate.Height = 24;
            this.reportDataGridView.Size = new System.Drawing.Size(459, 353);
            this.reportDataGridView.TabIndex = 2;
            this.reportDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDataGridView_CellEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(472, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtPrescription
            // 
            this.rtxtPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtPrescription.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtxtPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPrescription.ForeColor = System.Drawing.Color.White;
            this.rtxtPrescription.Location = new System.Drawing.Point(833, 50);
            this.rtxtPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtPrescription.Name = "rtxtPrescription";
            this.rtxtPrescription.ReadOnly = true;
            this.rtxtPrescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtPrescription.Size = new System.Drawing.Size(404, 461);
            this.rtxtPrescription.TabIndex = 0;
            this.rtxtPrescription.Text = "";
            // 
            // panelPrescriebed
            // 
            this.panelPrescriebed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPrescriebed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelPrescriebed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrescriebed.Controls.Add(this.mbtnPrescriebed);
            this.panelPrescriebed.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelPrescriebed.Location = new System.Drawing.Point(463, 30);
            this.panelPrescriebed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPrescriebed.Name = "panelPrescriebed";
            this.panelPrescriebed.Size = new System.Drawing.Size(364, 38);
            this.panelPrescriebed.TabIndex = 16;
            // 
            // mbtnPrescriebed
            // 
            this.mbtnPrescriebed.AutoSize = true;
            this.mbtnPrescriebed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPrescriebed.Depth = 0;
            this.mbtnPrescriebed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnPrescriebed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnPrescriebed.Icon = null;
            this.mbtnPrescriebed.Location = new System.Drawing.Point(0, 0);
            this.mbtnPrescriebed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPrescriebed.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPrescriebed.Name = "mbtnPrescriebed";
            this.mbtnPrescriebed.Primary = false;
            this.mbtnPrescriebed.Size = new System.Drawing.Size(360, 34);
            this.mbtnPrescriebed.TabIndex = 3;
            this.mbtnPrescriebed.Text = "PRESCRIEBED";
            this.mbtnPrescriebed.UseVisualStyleBackColor = true;
            this.mbtnPrescriebed.Click += new System.EventHandler(this.mbtnPrescriebed_Click);
            // 
            // panelExit
            // 
            this.panelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExit.Controls.Add(this.mbtnExit);
            this.panelExit.Location = new System.Drawing.Point(1146, 29);
            this.panelExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(100, 37);
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
            this.mbtnExit.Size = new System.Drawing.Size(100, 37);
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
            this.btnBack.Location = new System.Drawing.Point(0, -4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 30);
            this.btnBack.TabIndex = 48;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reportTableAdapter = this.reportTableAdapter;
            this.tableAdapterManager.UInfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMED.MedDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rtype
            // 
            this.rtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rtype.DataPropertyName = "rtype";
            this.rtype.HeaderText = "NAME OF THE TEST";
            this.rtype.MinimumWidth = 6;
            this.rtype.Name = "rtype";
            this.rtype.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 6;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 2;
            // 
            // Prescrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1247, 587);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelPrescriebed);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prescrib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRESCRIPTION DIALOG";
            this.Load += new System.EventHandler(this.Prescrib_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).EndInit();
            this.reportBindingNavigator.ResumeLayout(false);
            this.reportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).EndInit();
            this.panelmBtnName.ResumeLayout(false);
            this.panelmBtnName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrescriebed.ResumeLayout(false);
            this.panelPrescriebed.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtxtPrescription;
        private MedDBDataSet medDBDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private MedDBDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private MedDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reportBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelmBtnName;
        private MaterialSkin.Controls.MaterialFlatButton mbtnPrescrib;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPrescriebed;
        private MaterialSkin.Controls.MaterialFlatButton mbtnPrescriebed;
        private System.Windows.Forms.Panel panelExit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnCurrPrescription;
        private System.Windows.Forms.Button btnPrevPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}