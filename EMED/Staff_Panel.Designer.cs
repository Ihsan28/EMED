namespace EMED
{
    partial class Staff_Panel
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAText = new System.Windows.Forms.Label();
            this.panelmBtnPrescribe = new System.Windows.Forms.Panel();
            this.mbtnName = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Panel();
            this.mbtnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelmBtnPrescribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAText);
            this.panel1.Controls.Add(this.panelmBtnPrescribe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 376);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(3, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "SIGN OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.BackgroundImage = global::EMED.Properties.Resources.IPD;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Location = new System.Drawing.Point(420, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 145);
            this.panel2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.materialFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton1.Icon = global::EMED.Properties.Resources.icons8_treatment_64;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(326, 141);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(451, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "MANAGE REPORT";
            // 
            // lblAText
            // 
            this.lblAText.AutoSize = true;
            this.lblAText.BackColor = System.Drawing.Color.Transparent;
            this.lblAText.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAText.Location = new System.Drawing.Point(32, 276);
            this.lblAText.Name = "lblAText";
            this.lblAText.Size = new System.Drawing.Size(164, 37);
            this.lblAText.TabIndex = 28;
            this.lblAText.Text = "WELCOME";
            // 
            // panelmBtnPrescribe
            // 
            this.panelmBtnPrescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelmBtnPrescribe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelmBtnPrescribe.Controls.Add(this.mbtnName);
            this.panelmBtnPrescribe.Location = new System.Drawing.Point(4, 232);
            this.panelmBtnPrescribe.Name = "panelmBtnPrescribe";
            this.panelmBtnPrescribe.Size = new System.Drawing.Size(240, 40);
            this.panelmBtnPrescribe.TabIndex = 27;
            // 
            // mbtnName
            // 
            this.mbtnName.AutoSize = true;
            this.mbtnName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnName.Depth = 0;
            this.mbtnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnName.Icon = null;
            this.mbtnName.Location = new System.Drawing.Point(0, 0);
            this.mbtnName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnName.Name = "mbtnName";
            this.mbtnName.Primary = false;
            this.mbtnName.Size = new System.Drawing.Size(236, 36);
            this.mbtnName.TabIndex = 3;
            this.mbtnName.Text = "Not Selected";
            this.mbtnName.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EMED.Properties.Resources.icons8_staff_100_2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 42);
            this.label2.TabIndex = 32;
            this.label2.Text = "STAFF PANEL";
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.mbtnExit);
            this.panelExit.Location = new System.Drawing.Point(731, -2);
            this.panelExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(72, 32);
            this.panelExit.TabIndex = 129;
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
            this.mbtnExit.Size = new System.Drawing.Size(72, 32);
            this.mbtnExit.TabIndex = 126;
            this.mbtnExit.Text = "EXIT";
            this.mbtnExit.UseVisualStyleBackColor = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // Staff_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelmBtnPrescribe.ResumeLayout(false);
            this.panelmBtnPrescribe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAText;
        private System.Windows.Forms.Panel panelmBtnPrescribe;
        private MaterialSkin.Controls.MaterialFlatButton mbtnName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelExit;
        private MaterialSkin.Controls.MaterialFlatButton mbtnExit;
        private System.Windows.Forms.Button button1;
    }
}