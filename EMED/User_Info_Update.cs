using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMED
{
    public partial class User_Info_Update : MaterialForm
    {
        int id=9;
        string password = null;
        string[] a = new string[100];
        byte[] img=null;
        user s = new user();

        public User_Info_Update(int id)
        {
            InitializeComponent(); 

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE);

            user_initialize();
            this.id = id;

        }
        private void user_initialize()
        {
            s = db.user_inf(id);
            pictureBoxProfile.Image = s.pic;
            password = s.password;
            
            lblAge.Text = eMedService.current_age(s.birthdate)+" old";

            lblUType.Text = s.utype;
            txtUName.Text = s.uname;
            mtxtName.Text =lblName.Text= s.name;
            mtxtFather.Text = s.fname;
            txtDOB.Text = s.birthdate;
            txtGender.Text = s.gender;
            mtxtContact.Text =lblContact.Text= s.contact;
            txtEmail.Text =mtxtMail.Text= s.email;
            txtBGroup.Text = s.blood;
            mtxtQO.Text = s.qo;
            txtAddress.Text = s.address;
            mtxtRemark.Text = s.remark;

            if(s.utype=="PATIENT")
            {
                lblQO.Text = "OCCUPATION";
            }

            //MessageBox.Show(a[1]+a[2]+"");


        }
        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            img = image.Add_byte();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string contact = mtxtContact.Text;
            string q = "update UInf set name='" + mtxtName.Text + "'," +"father='" + mtxtFather.Text + "'," +
                "contact='" + lblContact.Text + "',qo='" + mtxtQO.Text + "'," +
                "address='" + txtAddress.Text + "',remark='" + mtxtRemark.Text + "'  where id='" +id + "'  ";
            if (img != null)
            {
                string q1 = "update UInf set image = @pic where id='" + id + "'";
                db.dbc(q1, img);
            }
            db.dba(q);
            MessageBox.Show("Updated");
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            user_initialize();
        }

        private void contact()
        {
            lblContact.Text=eMedService.internationalPhonenumber(mtxtContact.Text, combContact.Text);
        }

        private void mtxtContact_Leave(object sender, EventArgs e)
        {
            contact();
        }

        private void combContact_SelectedValueChanged(object sender, EventArgs e)
        {
            contact();
        }

        private void mtxtMail_TextChanged(object sender, EventArgs e)
        {
            if(sendemail.check(mtxtMail.Text))
            {
                lblMail.Visible = false;
                
            }
            else
            {
                lblMail.Visible = true;
                
            }
        }

        
        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            if(mtxtCurrPassword.Text==s.password)
            {
                string q;
                if (mtxtNewPassword.Text==mtxtConfirmNew.Text && mtxtConfirmNew.Text!="")
                {
                    q= "update UInf set password='" + mtxtConfirmNew.Text + "'," + "gmail='" + mtxtMail.Text + "' ";
                }
                else
                {
                    q = "update UInf set gmail='" + mtxtMail.Text + "'";
                }
                
                int code = eMedService.genarate_code();

                if(sendemail.isemail("Information update confirmation code", "Code: " + code, mtxtMail.Text))
                {
                    Code_Confirm c = new Code_Confirm(q, code, null, mtxtMail.Text);
                    this.Hide();
                    c.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect password.");
            }
        }

        private void mbtnReset_Click(object sender, EventArgs e)
        {
            if(s.utype=="DOCTOR")
            {
                Doctor_Panel d = new Doctor_Panel(id);
                this.Hide();
                d.Show();

            }
            else if (s.utype == "PATIENT")
            {
                Patient_Panel d = new Patient_Panel(id);
                this.Hide();
                d.Show();
            }
            else if (s.utype == "STAFF")
            {
                Staff_Panel d = new Staff_Panel(id);
                this.Hide();
                d.Show();
            }
        }
    }
}
