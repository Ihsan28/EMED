using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMED
{
    public partial class Code_Confirm : MaterialForm
    {
        private string q;
        private int code;
        private byte[] pic;
        public Code_Confirm(string q, int code,byte[] pic,string email)
        {
            InitializeComponent();

            this.q = q;
            this.code = code;
            this.pic = pic;
            lblEmail.Text = email;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Grey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void mbtnConfirmCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (code == Convert.ToInt32(txtCode.Text))
                {
                    if(pic!=null)
                    {
                        db.dbc(q, pic);
                    }
                    else
                    {
                        db.dba(q);
                    }
                    
                    MessageBox.Show("CODE CONFIRMED.","CONFIRMATION");

                    Form1 f = new Form1();
                    this.Dispose();
                    f.Show();
                }
                else
                {
                    panelX.Visible = true;
                    lblWrongCode.Visible = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input. Only 0-9 acceptable.");
                
                txtCode.Text = eMedService.deleteLast(txtCode.Text);
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.Clear();
            panelX.Visible = false;
            lblWrongCode.Visible = false;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if(txtCode.Text!="")
            {
                try
                {
                    string s = txtCode.Text;
                    long i = Convert.ToInt64(s);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong input. Only 0-9 acceptable.");
                    string s = txtCode.Text;
                    s = s.Remove(s.Length - 1);
                    txtCode.Text = s;
                }
            }  
        }

        private void mbtnBackSignIn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
