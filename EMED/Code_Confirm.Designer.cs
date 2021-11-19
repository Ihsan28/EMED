namespace EMED
{
    partial class Code_Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code_Confirm));
            this.panelCode = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mpbConfirm = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.panelX = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.mbtnConfirmCode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnBackSignIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBackSignIn = new System.Windows.Forms.Panel();
            this.panelCode.SuspendLayout();
            this.panelBackSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCode
            // 
            this.panelCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelCode.Controls.Add(this.lblEmail);
            this.panelCode.Controls.Add(this.panel1);
            this.panelCode.Controls.Add(this.mpbConfirm);
            this.panelCode.Controls.Add(this.lblWrongCode);
            this.panelCode.Controls.Add(this.panelX);
            this.panelCode.Controls.Add(this.lblCode);
            this.panelCode.Controls.Add(this.txtCode);
            this.panelCode.Controls.Add(this.mbtnConfirmCode);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCode.Location = new System.Drawing.Point(0, 80);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(457, 672);
            this.panelCode.TabIndex = 105;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmail.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(95, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 21);
            this.lblEmail.TabIndex = 133;
            this.lblEmail.Text = "email";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EMED.Properties.Resources.icons8_gmail_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(37, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 40);
            this.panel1.TabIndex = 134;
            // 
            // mpbConfirm
            // 
            this.mpbConfirm.AccessibleName = "txtCode";
            this.mpbConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.mpbConfirm.Depth = 0;
            this.mpbConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mpbConfirm.Location = new System.Drawing.Point(0, 631);
            this.mpbConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpbConfirm.Name = "mpbConfirm";
            this.mpbConfirm.Size = new System.Drawing.Size(457, 5);
            this.mpbConfirm.Step = 4;
            this.mpbConfirm.TabIndex = 132;
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCode.ForeColor = System.Drawing.Color.Maroon;
            this.lblWrongCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWrongCode.Location = new System.Drawing.Point(73, 530);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(299, 44);
            this.lblWrongCode.TabIndex = 130;
            this.lblWrongCode.Text = "WRONG CODE";
            this.lblWrongCode.Visible = false;
            // 
            // panelX
            // 
            this.panelX.BackgroundImage = global::EMED.Properties.Resources.icons8_delete_128;
            this.panelX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelX.Location = new System.Drawing.Point(113, 296);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(220, 220);
            this.panelX.TabIndex = 131;
            this.panelX.Visible = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblCode.Location = new System.Drawing.Point(97, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(250, 85);
            this.lblCode.TabIndex = 129;
            this.lblCode.Text = "CODE";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCode.Location = new System.Drawing.Point(94, 234);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(253, 47);
            this.txtCode.TabIndex = 128;
            this.txtCode.Tag = "";
            this.txtCode.Text = "Enter CODE";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            // 
            // mbtnConfirmCode
            // 
            this.mbtnConfirmCode.AutoSize = true;
            this.mbtnConfirmCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnConfirmCode.Depth = 0;
            this.mbtnConfirmCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mbtnConfirmCode.Icon = null;
            this.mbtnConfirmCode.Location = new System.Drawing.Point(0, 636);
            this.mbtnConfirmCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConfirmCode.Name = "mbtnConfirmCode";
            this.mbtnConfirmCode.Primary = true;
            this.mbtnConfirmCode.Size = new System.Drawing.Size(457, 36);
            this.mbtnConfirmCode.TabIndex = 127;
            this.mbtnConfirmCode.Text = "Comfirm Code";
            this.mbtnConfirmCode.UseVisualStyleBackColor = true;
            this.mbtnConfirmCode.Click += new System.EventHandler(this.mbtnConfirmCode_Click);
            // 
            // mbtnBackSignIn
            // 
            this.mbtnBackSignIn.AutoSize = true;
            this.mbtnBackSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnBackSignIn.Depth = 0;
            this.mbtnBackSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbtnBackSignIn.Icon = null;
            this.mbtnBackSignIn.Location = new System.Drawing.Point(0, 0);
            this.mbtnBackSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnBackSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnBackSignIn.Name = "mbtnBackSignIn";
            this.mbtnBackSignIn.Primary = false;
            this.mbtnBackSignIn.Size = new System.Drawing.Size(457, 27);
            this.mbtnBackSignIn.TabIndex = 106;
            this.mbtnBackSignIn.Text = "Back to Sign In";
            this.mbtnBackSignIn.UseVisualStyleBackColor = true;
            this.mbtnBackSignIn.Click += new System.EventHandler(this.mbtnBackSignIn_Click);
            // 
            // panelBackSignIn
            // 
            this.panelBackSignIn.Controls.Add(this.mbtnBackSignIn);
            this.panelBackSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackSignIn.Location = new System.Drawing.Point(0, 0);
            this.panelBackSignIn.Name = "panelBackSignIn";
            this.panelBackSignIn.Size = new System.Drawing.Size(457, 27);
            this.panelBackSignIn.TabIndex = 133;
            // 
            // Code_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(457, 752);
            this.Controls.Add(this.panelBackSignIn);
            this.Controls.Add(this.panelCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Code_Confirm";
            this.Text = "Gmail Verification";
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panelBackSignIn.ResumeLayout(false);
            this.panelBackSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Label lblWrongCode;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnConfirmCode;
        private MaterialSkin.Controls.MaterialProgressBar mpbConfirm;
        private MaterialSkin.Controls.MaterialFlatButton mbtnBackSignIn;
        private System.Windows.Forms.Panel panelBackSignIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
    }
}