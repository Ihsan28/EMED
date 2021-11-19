namespace EMED
{
    partial class UControl_User
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(118, 99);
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Monotxt", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 49);
            this.textBox1.TabIndex = 2;
            // 
            // UControl_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBoxUser);
            this.Name = "UControl_User";
            this.Size = new System.Drawing.Size(118, 169);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
    }
}
