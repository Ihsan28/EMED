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
    public partial class Prescrib : MaterialForm
    {
        int d=9, p=8;
        string prev = "";
        string curr = "";
        string name = "";
        //Image img = null;
        //string reoprt="";
        public Prescrib(int d_id,int pid,string name)
        {
            InitializeComponent();
            //int d_id, int p_id, string name
            d = d_id;
            p = pid;
            this.name = name;
            
            initialize();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }
        
        private void initialize()
        {
            //d = 9; p = 8;name = "unknown";
            prev= db.prescription(d, p);
            rtxtPrescription.Text = prev;
            lblAge.Text = eMedService.current_age(db.DOB(p));
            mbtnPrescrib.Text = name;
        }

        

        private void Report_initialize(string id)
        {
            try
            {
                int r = Convert.ToInt32(id);
                Image g = db.report_img(r);
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
            catch (FormatException)
            {
                MessageBox.Show("Null value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void reportDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string id = reportDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            Report_initialize(id);
        }

        private void mbtnPrescriebed_Click(object sender, EventArgs e)
        {
            curr_info_prescription();

            MessageBox.Show(rtxtPrescription.Text);
            curr = rtxtPrescription.Text;

            string prescription = prev + Environment.NewLine+"___________________=____________________" 
                                  + Environment.NewLine + Environment.NewLine + curr;

            string q = "update Appointment set prescription='" + prescription + "',prescribed='" + false + "'  where d_id='" + d + "' and p_id = '" + p + "' ";
            
            db.dba(q);

            PatientList();
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientList();
        }

        private void PatientList()
        {
            Patient_list p = new Patient_list(d);
            this.Hide();
            p.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            Add_Current_info();

        }
        private void Add_Current_info()
        {
            if(!rtxtPrescription.ReadOnly)
            {
                DateTime date = System.DateTime.Now;
                string s =  Environment.MachineName + Environment.NewLine
                           + Environment.UserName +"  DOCTOR ID: "+d+ Environment.NewLine + Environment.OSVersion + Environment.NewLine
                           + Environment.UserDomainName + Environment.NewLine + "DATETIME :" 
                           + date.ToString() + Environment.NewLine+"----------------------------------------------------"
                           + Environment.NewLine + Environment.NewLine;
                rtxtPrescription.Text = s;
            }
            
        }

        private void btnCurrPrescription_Click(object sender, EventArgs e)
        {
            curr_info_prescription();
        }

        private void curr_info_prescription()
        {
            if (rtxtPrescription.ReadOnly)
            {
                rtxtPrescription.ReadOnly = false;
                rtxtPrescription.Text = curr;
                if (curr == "")
                {
                    Add_Current_info();
                }
            }
        }

        private void btnPrevPrescription_Click(object sender, EventArgs e)
        {
            if(!rtxtPrescription.ReadOnly)
            {
                curr = rtxtPrescription.Text;
                rtxtPrescription.Text = prev;
                rtxtPrescription.ReadOnly = true;
            }
        }

        private void Prescrib_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDBDataSet.report' table. You can move, or remove it, as needed.
            //this.reportTableAdapter.Fill(this.medDBDataSet.report);
            //this.reportTableAdapter.FillByPid(this.medDBDataSet.report, ((int)(System.Convert.ChangeType(pToolStripTextBox.Text, typeof(int)))));
            try
            {
                this.reportTableAdapter.FillByPid(this.medDBDataSet.report, ((int)p));
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //private void prescription()
        //{
        //    string q = "select * from Appointment where p_id='" + p + "' and d_id='" + d + "'";

        //    System.Data.SqlClient.SqlDataReader reader = db.db_reader(q);

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            prescript = reader["prescription"].ToString();
        //            //MessageBox.Show("ID: " + reader.GetValue(0).ToString());
        //            //id = (int)reader["id"];
        //            //byte[] pic = (byte[])reader["image"];
        //            //System.IO.MemoryStream stream = new System.IO.MemoryStream(pic);
        //            //img = Image.FromStream(stream);
        //        }


        //    }

        //    reader.Close();
        //    db.con.Close();

        //    string q1 = "select * from report where p_id='" + p + "'";
        //    System.Data.SqlClient.SqlDataReader reader1 = db.db_reader(q1);

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            prescript = reader["prescription"].ToString();
        //            //MessageBox.Show("ID: " + reader.GetValue(0).ToString());
        //            //id = (int)reader["id"];
        //            //byte[] pic = (byte[])reader["image"];
        //            //System.IO.MemoryStream stream = new System.IO.MemoryStream(pic);
        //            //img = Image.FromStream(stream);
        //        }
        //    }

        //    reader1.Close();
        //    db.con.Close();
        //}
    }
}
