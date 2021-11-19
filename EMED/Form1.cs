
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
using libphonenumber;
using System.Resources;
using System.Data.SqlTypes;



namespace EMED
{
    public partial class Form1 : MaterialForm
    {
        /// <summary>
        /// class variables
        /// </summary>

        int random;
        bool info1 = false, info2 = false, info3 = false, info4 = false, info5 = false, info6 = false,
             info7 = false, info8 = false, info9 = false, info10 = false, info11 = false, info12 = false,
             info13 = false;

        string utype = "";
        
        string qo = "";

        byte[] pic = null;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            panelUName.Visible = true;
        }
        private void utype_initialize(string p,string r, string s)
        {
            utype = p;
            lblUType.Text = utype;

            //table = q;
            
            qo = r;
            txtQualifications.Text = "Enter your " + qo;

            lblQualification.Text = s;
            mbtnReset.Visible = true;

            
        }
        private void mRbtnDoctor_CheckedChanged(object sender, EventArgs e)
        {
            utype_initialize("DOCTOR","qualification", "Qualifications");
            combDepartment.Visible = true;
        }
        private void mRBtnPatient_CheckedChanged(object sender, EventArgs e)
        {
            utype_initialize("PATIENT","occupation", "Occupations");
            combDepartment.Visible = false;
        }
        private void mRBtnStaff_CheckedChanged(object sender, EventArgs e)
        {
            utype_initialize("STAFF","qualification", "Qualifications");
            combDepartment.Visible = false;
        }


        // ENTER METHODES

        private void txtUName_Enter(object sender, EventArgs e)
        {
            if (txtUName.Text == "Enter your name")
            {
                txtUName.Clear();
            }
            groupBUtype.Visible = false;
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password")
                txtPassword.Clear();
        }
        private void txtCPassword_Enter(object sender, EventArgs e)
        {
            if (txtCPassword.Text == "Confirm your password")
            {
                txtCPassword.Clear();
            }
            else if (txtCPassword.Text == txtPassword.Text)
            {
                lblCText.Visible = false;
            }
        }
        private void txtFName_Enter(object sender, EventArgs e)
        {
            if (txtFName.Text == "First Name")
            {
                txtFName.Clear();
            }
        }
        private void txtLName_Enter(object sender, EventArgs e)
        {
            if (txtLName.Text == "Last Name")
            {
                txtLName.Clear();
            }
        }
        private void txtFather_Enter(object sender, EventArgs e)
        {
            if (txtFather.Text == "Enter your father name")
            {
                txtFather.Clear();
            }
        }
        private void txtContact_Enter(object sender, EventArgs e)
        {
            if (txtContact.Text == "Phone Number")
                txtContact.Clear();
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter your gmail")
                txtEmail.Clear();
        }
        private void txtQualification_Enter(object sender, EventArgs e)
        {
            if (txtQualifications.Text == "Enter your " + qo)
            {
                txtQualifications.Clear();
            }
        }
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Write your address")
            {
                txtAddress.Clear();
            }
        }
        private void txtRemark_Enter(object sender, EventArgs e)
        {
            if (txtRemark.Text == "Write your remark")
            {
                txtRemark.Clear();
            }
        }


        //LEAVE METHODES


        private void txtUName_Leave(object sender, EventArgs e)
        {
            if (txtUName.Text == "")
            {
                txtUName.Text = "Enter your name";
                panelUName.Visible = false;
                groupBUtype.Visible = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password";
                panelCPassword.Visible = false;
                lblCText.Visible = false;
            }
        }
        private void txtCPassword_Leave(object sender, EventArgs e)
        {
            if (txtCPassword.Text == "")
            {
                txtCPassword.Text = "Confirm your password";
            }
        }
        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                txtFName.Text = "First Name";
            }
        }
        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                txtLName.Text = "Last Name";
            }
        }
        private void txtFather_Leave(object sender, EventArgs e)
        {
            if (txtFather.Text == "")
            {
                txtFather.Text = "Enter your father name";
            }
        }
        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text == "")
            {
                txtContact.Text = "Phone Number";
            }
            else
            {
                lblCContact.Text = eMedService.internationalPhonenumber(txtContact.Text,combContact.Text);
            }
        }
        
        //private string internationalPhonenumber(string c)
        //{
        //    string localPhoneNumber =c ;
        //    PhoneNumber pn = PhoneNumberUtil.Instance.Parse(localPhoneNumber, combContact.Text);
        //    string internationalPhoneNumber = pn.Format(PhoneNumberUtil.PhoneNumberFormat.INTERNATIONAL);   //CONTACT NUMBER CONVERSION TO INTERNATIONAL FORMAT

        //    return internationalPhoneNumber;
        //}
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your gmail";
            } 
        }
        private void txtQualifications_Leave(object sender, EventArgs e)
        {
            if (txtQualifications.Text == "")
            {
                txtQualifications.Text = "Enter your " + qo;
            }
        }
        private void combDepartment_Leave(object sender, EventArgs e)
        {
            if (combDepartment.Text == "")
            {
                combDepartment.Text = "DEPARTMENT";
            }
        }
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Write your address";
            }
        }
        private void txtRemark_Leave(object sender, EventArgs e)
        {
            if (txtRemark.Text == "")
            {
                txtRemark.Text = "Write your remark";

            }
        }


            //TEXT CHANGED & OTHER VALUE CHANGED METHODES
        private void txtUName_TextChanged(object sender, EventArgs e)
        {
            if (txtUName.Text != "" && txtUName.Text != "Enter your name")
            {
                panelPassword.Visible = true;
                if(db.HasRows("select * from UInf where uname='"+txtUName.Text+"'"))
                {
                    info1 = false;
                    lblUText.Visible = true;
                }
                else
                {
                    info1 = true;
                    lblUText.Visible = false;
                }
                
            }
            else if (txtUName.Text == "")
            {
                panelPassword.Visible = false;
                info1 = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtPassword.Text != "Enter password")
            {
                panelCPassword.Visible = true;
                info2 = true;
            }
            else if (txtPassword.Text == "")
            {
                panelCPassword.Visible = false;
                info2 = false;
            }

            if (txtCPassword.Text != "Confirm your password" || txtCPassword.Text == txtPassword.Text)
            {
                lblCText.Visible = true;
            }
        }

        private void txtCPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCPassword.Text != "" && txtCPassword.Text != "Confirm your password" && txtCPassword.Text != txtPassword.Text)
            {
                lblCText.Visible = true;
                info3 = false;
            }
            else if (txtCPassword.Text == txtPassword.Text)
            {
                lblCText.Visible = false;
                panelName.Visible = true;
                info3 = true;
            }
            else if (txtCPassword.Text == "")
            {
                panelName.Visible = false;
                info3 = false;
            }
        }
        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "" && txtFName.Text != "First Name" && txtLName.Text != "Last Name")
            {
                panelFather.Visible = true;
                info4 = true;
            }
            else //if (txtFName.Text == "" || txtLName.Text == "" || txtFName.Text == "First Name" || txtLName.Text == "Last Name")
            {
                panelFather.Visible = false;
                info4 = false;
            }
        }
        private void txtFather_TextChanged(object sender, EventArgs e)
        {
            if (txtFather.Text != "" && txtFather.Text != "Enter your father name")
            {
                panelDOB.Visible = true;
                info5 = true;
            }
            else if (txtFather.Text == "")
            {
                panelDOB.Visible = false;
                info5 = false;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            panelGender.Visible = true;
            txtDOB.Text = Convert.ToString(Convert.ToDateTime(dateTimePicker1.Text));
            info6 = true;
        }
        private void RbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            panelContact.Visible = true;
            info7 = true;
        }
        private void combContact_SelectedValueChanged(object sender, EventArgs e)
        {
            lblCContact.Text =eMedService.internationalPhonenumber(txtContact.Text,combContact.Text);
        }
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text != "" && txtContact.Text != "Phone Number")
            {
                panelEmail.Visible = true;
                info8 = true;

                try
                {
                    string s = txtContact.Text;
                    long i = Convert.ToInt64(s);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong input. Only 0-9 acceptable.");
                    txtContact.Text = txtContact.Text.Remove(txtContact.Text.Length - 1);
                }
            }
            else if (txtContact.Text == "")
            {
                panelEmail.Visible = false;
                info8 = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            
            if (sendemail.check(txtEmail.Text))
            {
                    panelBGroup.Visible = true;
                    lblEText.Visible = false;
                    info9 = true;
            }
            else
            {
                lblEText.Visible = true;
                panelBGroup.Visible = false;
                info9 = false;
            }
        }

        private void combBGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            panelQualifications.Visible = true;
            info10 = true;
        }
        private void combBGroup_TextChanged(object sender, EventArgs e)
        {
            if (combBGroup.Text == "" || combBGroup.Text == "Select your blood group")
            {
                if (combBGroup.Text == "")
                {
                    combBGroup.Text = "Select your blood group";
                }
                panelQualifications.Visible = false;
                info10 = false;
            }
        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {
            if (txtQualifications.Text == "Enter your " + qo || txtQualifications.Text == "")
            {
                panelAddress.Visible = false;
                info11 = false;
            }
            else
            {
                panelAddress.Visible = true;
                info11 = true;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Write your address" || txtAddress.Text == "")
            {
                panelRemark.Visible = false;
                info12 = false;
            }
            else
            {
                panelRemark.Visible = true;
                info12 = true;
            }
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {
            if (txtRemark.Text == "Write your remark" || txtRemark.Text == "")
            {
                //panelInfoConfirm.Visible = false;
                panelProfilePic.Visible = false;
                info13 = false;
            }
            else
            {
                //panelInfoConfirm.Visible = true;
                panelProfilePic.Visible = true;
                info13 = true;
            }
        }

        private void profilepictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            panelInfoConfirm.Visible = true;
        }

        private void mbtnPPicture_Click(object sender, EventArgs e)
        {
            pic = image.Add_byte();
            profilepictureBox.BackgroundImage =image.byte_ToImage(pic); 
        }

        /// <summary>
        /// RESET CLICK ON SIGN UP PAGE
        /// </summary>
        
        private void mbtnReset_Click(object sender, EventArgs e)
        {
            mRbtnDoctor.Checked = false;
            mRbtnPatient.Checked = false;
            mRbtnStaff.Checked = false;
            lblUType.Text = "???";

            txtUName.Text = "Enter your name";

            txtPassword.Text = "Enter password";
            txtCPassword.Text = "Confirm your password";

            txtLName.Text = "Last Name";
            txtFName.Text = "First Name";

            txtFather.Text = "Enter your father name";

            txtDOB.Text = "Select your date of birth";
            //dateTimePicker1.ResetText();

            RbtnMale.Checked = false;
            RbtnFemale.Checked = false;

            combContact.Text = "BD";
            txtContact.Text = "Phone Number";

            txtEmail.Text = "Enter your gmail";
            combBGroup.Text = "Select your blood group";
            txtQualifications.Text = "Enter your qualifications";
            combDepartment.Text = "DEPARTMENT";
            txtAddress.Text = "Write your address";
            txtRemark.Text = "Write your remark";

            lblUText.Visible = false;
            lblEText.Visible = false;
            lblCText.Visible = false;

            panelUName.Visible = false;
            panelPassword.Visible = false;
            panelCPassword.Visible = false;
            panelName.Visible = false;
            panelFather.Visible = false;
            panelDOB.Visible = false;
            panelGender.Visible = false;
            panelContact.Visible = false;
            panelEmail.Visible = false;
            panelBGroup.Visible = false;
            panelQualifications.Visible = false;
            combDepartment.Visible = false;
            panelAddress.Visible = false;
            panelRemark.Visible = false;
            panelInfoConfirm.Visible = false;

            profilepictureBox.Image = null;

            groupBUtype.Visible = true;

            mbtnReset.Visible = false;
        }

        private void btnCInfo_MouseEnter(object sender, EventArgs e)
        {
            panelInfoConfirm.BackColor = Color.Transparent;
        }

        private void btnCInfo_MouseLeave(object sender, EventArgs e)
        {
            panelInfoConfirm.BackColor = Color.FromArgb(21, 101, 192);
        }

        /// <summary>
        /// CONFIRM CLICK ON SIGN UP PAGE
        /// </summary>
        
        private void btnCInfo_Click(object sender, EventArgs e)
        {
            panelInfoConfirm.BackColor = Color.Green;
            btnCInfo.Text = "CONFIRMED";
            btnCInfo.ForeColor = Color.LightGreen;

            if (info1 == true && info2 == true && info3 == true && info4 == true && info5 == true && info6 == true &&
            info7 == true && info8 == true && info9 == true && info10 == true && info11 == true && info12 == true &&
            info13 == true)
            {
                panelInfo.Visible = false;
                panelInfo1.Visible = false;
                lblWaitText.Visible = true;
                DateTime dob = Convert.ToDateTime(dateTimePicker1.Text);

                string gender = "";
                if (RbtnMale.Checked)
                    gender = "Male";
                else if (RbtnFemale.Checked)
                    gender = "Female";

                string name = txtFName.Text + " " + txtLName.Text;
                string department = "";
                if (combDepartment.Text!="DEPARTMENT")
                {
                    department = combDepartment.Text;
                }
                
                string q = "insert into UInf(utype,uname,password,name,father,dob,gender,contact,gmail,blood,qo,address,remark,department,image)" +
                " VALUES('"+utype+"','" + txtUName.Text + "','" + txtPassword.Text + "','" + name + "','" + txtFather.Text + "','" + dob + "'," +
                "'" + gender + "','" + lblCContact.Text + "','" + txtEmail.Text + "','" + combBGroup.Text + "','" + txtQualifications.Text +
                "','" + txtAddress.Text + "','" + txtRemark.Text + "','" + department + "',@pic)";
                //MessageBox.Show(q);

                
                random = eMedService.genarate_code();

                string eMessage = "User name: " + txtUName.Text + "\n" +
                                  "DOB: " + dob + "\n" +
                                  "Gender: " + gender + "\n" +
                                  "Address: " + txtAddress.Text + "\n"
                                  + "\n\n\n\nCONFIRMATION CODE: " + random + "\n";

                confirmation(eMessage, q);
            }
            else
            {
                MessageBox.Show("FILL ALL INFORMATION CORRECTLY","WARNING");
            }
        }

        private void confirmation(string eMessage,string q)
        {
            MessageBox.Show(eMessage, "Registerd Info");

            //panelConfirmation.Visible = true;
            if (sendemail.isemail("Verification", eMessage, txtEmail.Text))
            {
                MessageBox.Show("You will recieve a confirmation code.");

                Code_Confirm c = new Code_Confirm(q, random, pic,txtEmail.Text);
                this.Hide();
                c.Show();
            }
            else
            {
                DialogResult f = MessageBox.Show("Network connection problem. Confirmation Code can't send.", "WARNING", MessageBoxButtons.AbortRetryIgnore);

                if (f == DialogResult.Ignore)
                {
                    random = 1111;
                    Code_Confirm c = new Code_Confirm(q, random, pic,"UNAVAILABLE");
                    this.Hide();
                    c.Show();
                }
                else if (f == DialogResult.Retry)
                {
                    confirmation(eMessage,q);//btnCInfo_Click(object sender, EventArgs e);
                }
                else if (f == DialogResult.Abort)
                {
                    panelInfo.Visible = true;
                    panelInfo1.Visible = true;
                    lblWaitText.Visible = false;
                }
            }
        }



        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// //SIGN IN PAGE METHODES
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>




        int i = 0;
        private void mtxtInUName_TextChanged(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pictureBox1.Image =Properties.Resources.icons8_round_128;
                i = 1;
            }
            else if (i == 1)
            {
                pictureBox1.Image = Properties.Resources.icons8_round_128_Rotate_Right_1;
                i = 2;
            }
            else if (i == 2)
            {
                pictureBox1.Image = Properties.Resources.icons8_round_128_Rotate_Right_2;
                i = 3;
            }
            else if (i == 3)
            {
                pictureBox1.Image = Properties.Resources.icons8_round_128_Rotate_Right_3;
                i = 0;
            }
        }

        private void mtxtInUName_Enter(object sender, EventArgs e)
        {
            if (mtxtInUName.Text == "Enter your user name")
            {
                mtxtInUName.Text = "";
            }
        }

        private void mtxtInUName_Leave(object sender, EventArgs e)
        {
            
            if (mtxtInUName.Text != "")
            {
                string q = "select image from UInf where uname='" + mtxtInUName.Text + "'";
                Image g = null;
                g = db.Img(q);

                if (g != null)
                {
                    pictureBox1.Image = g;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.unavailable_96px;
                    //  MessageBox.Show("Invalid User Name!!!");
                }

            }
            else if (mtxtInUName.Text == "")
            {
                mtxtInUName.Text = "Enter your user name";
            }
            
        }

        private void mtxtInPassword_Enter(object sender, EventArgs e)
        {
            mtxtInPassword.Clear();
        }

        private void mtxtInPassword_Leave(object sender, EventArgs e)
        {
            if (mtxtInPassword.Text == "")
            {
                mtxtInPassword.Text = "password";
            }
        }
        private void mbtnSignIn_MouseEnter(object sender, EventArgs e)
        {
            if (mtxtInUName.Text != "Enter your user name")
            {
                pictureBox3.Image = Properties.Resources.icons8_caduceus_100;
            }
            else if (mtxtInUName.Text == "Enter your user name")
            {
                pictureBox3.Image = Properties.Resources.icons8_delete_128;
            }
        }

        private void mbtnSignIn_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
        }
        private void mbtnSignIn_Click(object sender, EventArgs e)
        {
            utype = null;
            int id = 0;
                id=db.id(mtxtInUName.Text,mtxtInPassword.Text);
            //MessageBox.Show(id+"");
            if(id!=0 && mtxtInUName.Text!="admin")
            {
                utype = db.utype(id);
                //MessageBox.Show(utype + "");

                string q = "select * from UInf where [authorization]='"+true+"' and uname='"+mtxtInUName.Text+"'";

                if(db.HasRows(q))
                {
                    if (utype == "DOCTOR")
                    {
                        Doctor_Panel d = new Doctor_Panel(id);
                        this.Hide();
                        d.Show();
                    }
                    else if (utype == "PATIENT")
                    {
                        Patient_Panel p = new Patient_Panel(id);
                        this.Hide();
                        p.Show();
                    }
                    else if (utype == "STAFF")
                    {
                        Staff_Panel s = new Staff_Panel(id);
                        this.Hide();
                        s.Show();
                    }
                }
                else
                    MessageBox.Show("You are not authorize yet","info",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else if(mtxtInUName.Text=="admin" && mtxtInPassword.Text=="admin")
            {
                Authorization a = new Authorization();
                this.Hide();
                a.Show();
            }
            else
            {
                //MessageBox.Show("password is incorrect","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mbtnExit_MouseEnter(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Red;
        }

        private void mbtnExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.FromArgb(18, 30, 49);
        }
    }
}
