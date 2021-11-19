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
    public partial class Authorization : MaterialForm
    {
        public Authorization()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void uInfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uInfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medDBDataSet);

        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDBDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.medDBDataSet.Appointment);
            // TODO: This line of code loads data into the 'medDBDataSet.report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.medDBDataSet.report);
            // TODO: This line of code loads data into the 'medDBDataSet.UInf' table. You can move, or remove it, as needed.
            this.uInfTableAdapter.Fill(this.medDBDataSet.UInf);

        }

        private void tabPageDoctor_Enter(object sender, EventArgs e)
        {
            
        }

        private void dOCTORToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.DOCTOR(this.medDBDataSet.UInf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.FillBy(this.medDBDataSet.UInf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aLLToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.ALL(this.medDBDataSet.UInf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pATIENTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.PATIENT(this.medDBDataSet.UInf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sTAFFToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.STAFF(this.medDBDataSet.UInf);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void uNAUTHORIZE_USERToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uInfTableAdapter.UNAUTHORIZE_USER(this.medDBDataSet.UInf);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void rtxtMailSubject_Enter(object sender, EventArgs e)
        {
            if(rtxtMailSubject.Text=="Subject")
            {
                rtxtMailSubject.Clear();
            }
            
        }

        private void rtxtMailSubject_Leave(object sender, EventArgs e)
        {
            if(rtxtMailSubject.Text=="")
            {
                rtxtMailSubject.Text = "Subject";
            }
        }

        private void rtxtMailBody_Enter(object sender, EventArgs e)
        {
            if(rtxtMailBody.Text=="Mail Body")
            {
                rtxtMailBody.Clear();
            }
            
        }

        private void rtxtMailBody_Leave(object sender, EventArgs e)
        {
            if (rtxtMailBody.Text == "")
            {
                rtxtMailBody.Text = "Mail Body";
            }
        }

        private void mBtnEmail_Click(object sender, EventArgs e)
        {
            if(mBtnEmail.Text!="Not Selected")
            {
                if(sendemail.isemail(rtxtMailSubject.Text,rtxtMailBody.Text,mBtnEmail.Text))
                {
                    MessageBox.Show("Mail Sent");
                }
            }
        }

        private void uInfDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string id = uInfDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            try
            {
                int d = Convert.ToInt32(id);
                user r = new user();
                r = db.user_inf(d);

                if (r != null)
                {
                    pictureBox1.Image = r.pic;
                    mbtnCompose.Text = r.name;
                    mBtnEmail.Text = r.email;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.unavailable_96px;
                    //  MessageBox.Show("Invalid User Name!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Null value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mbtnCompose.Text = "Not Selected";
            }
           
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void reportDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        { 
            string serial = reportDataGridView.Rows[e.RowIndex].Cells["report_id"].Value.ToString();
            string id = reportDataGridView.Rows[e.RowIndex].Cells["p_id"].Value.ToString();
            
            try
            {
                //int s = Convert.ToInt32(serial);
                int d = Convert.ToInt32(id);
                user r = new user();
                r = db.user_inf(d);
                
                if (r != null)
                {
                    pictureBoxReportPatient.Image = r.pic;
                    mbtnRName.Text = r.name;
                    lblRUName.Text=r.uname;
                    mbtnREmail.Text = r.email;
                    //pictureBoxReport.Image = db.report_img(s);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.unavailable_96px;
                    //  MessageBox.Show("Invalid User Name!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Null value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mbtnCompose.Text = "Not Selected";
            }
        }

        private void appointmentDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string id = appointmentDataGridView.Rows[e.RowIndex].Cells["appointment_id"].Value.ToString();
            string p = appointmentDataGridView.Rows[e.RowIndex].Cells["pid"].Value.ToString();
            string d = appointmentDataGridView.Rows[e.RowIndex].Cells["did"].Value.ToString();

            try
            {
                int s = Convert.ToInt32(id);
                int did = Convert.ToInt32(d);
                int pid = Convert.ToInt32(p);

                user patient = new user();
                patient = db.user_inf(pid);

                user doctor = new user();
                doctor = db.user_inf(did);

                if (patient != null && doctor != null)
                {
                    pictureBoxAppointmentDoctor.Image = doctor.pic;
                    lblUNameAppointmentDoctor.Text = doctor.uname;
                    mbtnNameAppointmentDoctor.Text = doctor.name;

                    pictureBoxAppointmentPatient.Image = patient.pic;
                    lblUNameAppointmentPatient.Text = patient.uname;
                   
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.unavailable_96px;
                    //  MessageBox.Show("Invalid User Name!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Null value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mbtnCompose.Text = "Not Selected";
            }
        }
    }
}
