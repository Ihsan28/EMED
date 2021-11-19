namespace EMED
{
    partial class Patient_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_list));
            this.mbtnPrescrib = new MaterialSkin.Controls.MaterialFlatButton();
            this.medDBDataSet = new EMED.MedDBDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new EMED.MedDBDataSetTableAdapters.AppointmentTableAdapter();
            this.tableAdapterManager = new EMED.MedDBDataSetTableAdapters.TableAdapterManager();
            this.appointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPText = new System.Windows.Forms.Label();
            this.lblPListText = new System.Windows.Forms.Label();
            this.panelmBtnPrescribe = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.mbtnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).BeginInit();
            this.appointmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelmBtnPrescribe.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbtnPrescrib
            // 
            this.mbtnPrescrib.AutoSize = true;
            this.mbtnPrescrib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPrescrib.Depth = 0;
            this.mbtnPrescrib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnPrescrib.Icon = null;
            this.mbtnPrescrib.Location = new System.Drawing.Point(0, 0);
            this.mbtnPrescrib.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPrescrib.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPrescrib.Name = "mbtnPrescrib";
            this.mbtnPrescrib.Primary = false;
            this.mbtnPrescrib.Size = new System.Drawing.Size(286, 45);
            this.mbtnPrescrib.TabIndex = 3;
            this.mbtnPrescrib.Text = "Not Selected";
            this.mbtnPrescrib.UseVisualStyleBackColor = true;
            this.mbtnPrescrib.Click += new System.EventHandler(this.mbtnPrescrib_Click);
            // 
            // medDBDataSet
            // 
            this.medDBDataSet.DataSetName = "MedDBDataSet";
            this.medDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.medDBDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.UInfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMED.MedDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentBindingNavigator
            // 
            this.appointmentBindingNavigator.AddNewItem = null;
            this.appointmentBindingNavigator.BindingSource = this.appointmentBindingSource;
            this.appointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentBindingNavigator.DeleteItem = null;
            this.appointmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appointmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.appointmentBindingNavigator.Location = new System.Drawing.Point(0, 639);
            this.appointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentBindingNavigator.Name = "appointmentBindingNavigator";
            this.appointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentBindingNavigator.Size = new System.Drawing.Size(674, 27);
            this.appointmentBindingNavigator.TabIndex = 6;
            this.appointmentBindingNavigator.Text = "bindingNavigator1";
            this.appointmentBindingNavigator.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AllowUserToOrderColumns = true;
            this.appointmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDataGridView.AutoGenerateColumns = false;
            this.appointmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.appointmentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.p_id,
            this.prescription});
            this.appointmentDataGridView.DataSource = this.appointmentBindingSource;
            this.appointmentDataGridView.Location = new System.Drawing.Point(298, 113);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.RowTemplate.Height = 24;
            this.appointmentDataGridView.Size = new System.Drawing.Size(364, 517);
            this.appointmentDataGridView.TabIndex = 6;
            this.appointmentDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(18, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblPText
            // 
            this.lblPText.AutoSize = true;
            this.lblPText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPText.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPText.Location = new System.Drawing.Point(61, 437);
            this.lblPText.Name = "lblPText";
            this.lblPText.Size = new System.Drawing.Size(156, 22);
            this.lblPText.TabIndex = 8;
            this.lblPText.Text = "click button to prescribe";
            // 
            // lblPListText
            // 
            this.lblPListText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPListText.AutoSize = true;
            this.lblPListText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPListText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPListText.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPListText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPListText.Location = new System.Drawing.Point(321, 86);
            this.lblPListText.Name = "lblPListText";
            this.lblPListText.Size = new System.Drawing.Size(308, 23);
            this.lblPListText.TabIndex = 9;
            this.lblPListText.Text = "PATIENT APPOINTMENT LIST";
            // 
            // panelmBtnPrescribe
            // 
            this.panelmBtnPrescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelmBtnPrescribe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelmBtnPrescribe.Controls.Add(this.mbtnPrescrib);
            this.panelmBtnPrescribe.Location = new System.Drawing.Point(4, 375);
            this.panelmBtnPrescribe.Name = "panelmBtnPrescribe";
            this.panelmBtnPrescribe.Size = new System.Drawing.Size(290, 49);
            this.panelmBtnPrescribe.TabIndex = 11;
            // 
            // panelExit
            // 
            this.panelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExit.Controls.Add(this.mbtnExit);
            this.panelExit.Location = new System.Drawing.Point(581, 29);
            this.panelExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(92, 31);
            this.panelExit.TabIndex = 130;
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
            this.mbtnExit.Size = new System.Drawing.Size(92, 31);
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
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 29);
            this.btnBack.TabIndex = 132;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "Patient ID";
            this.p_id.MinimumWidth = 6;
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Width = 98;
            // 
            // prescription
            // 
            this.prescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prescription.DataPropertyName = "prescription";
            this.prescription.HeaderText = "Prescription";
            this.prescription.MinimumWidth = 6;
            this.prescription.Name = "prescription";
            this.prescription.ReadOnly = true;
            // 
            // Patient_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 642);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelmBtnPrescribe);
            this.Controls.Add(this.lblPListText);
            this.Controls.Add(this.lblPText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.appointmentBindingNavigator);
            this.Name = "Patient_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.Patient_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).EndInit();
            this.appointmentBindingNavigator.ResumeLayout(false);
            this.appointmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelmBtnPrescribe.ResumeLayout(false);
            this.panelmBtnPrescribe.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton mbtnPrescrib;
        private MedDBDataSet medDBDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private MedDBDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private MedDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPText;
        private System.Windows.Forms.Label lblPListText;
        private System.Windows.Forms.Panel panelmBtnPrescribe;
        private System.Windows.Forms.Panel panelExit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
    }
}