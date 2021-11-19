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
    public partial class Report_Upload : MaterialForm
    {
        byte[] pic = null;
        int pid;
        int rid;
        int sid;
        int did;
        //string testType = "";
        //string prescribe = "";
        public Report_Upload(int s)
        {
            InitializeComponent();
            test_reload();
            this.sid = s;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Report_Upload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDBDataSet.report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.medDBDataSet.report);
            // TODO: This line of code loads data into the 'medDBDataSet1.report' table. You can move, or remove it, as needed.

            LoadR();
        }
        private void LoadR()
        {
            this.reportTableAdapter.FillBy_Not_Uploded(this.medDBDataSet.report);
        }

        private void reportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medDBDataSet);
        }

        private void reportDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Image g;
            string id = reportDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string p = reportDataGridView.Rows[e.RowIndex].Cells["p_id"].Value.ToString();
            mBtnTest.Text= reportDataGridView.Rows[e.RowIndex].Cells["rtype"].Value.ToString();
            
            try
            {
                pid = Convert.ToInt32(p);
                rid = Convert.ToInt32(id);

            }
            catch(FormatException)
            {
                rid = 0;
                pictureBox1.Image = null;
                mbtnTestConfirm.Text ="Not Available";
            }

            get_info();
        }

        private void get_info()
        {
            try
            {
                pictureBox1.Image = db.Image(pid);
                mbtnTestConfirm.Text = db.name(pid);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mbtnTestConfirm.Text = "Not Selected";
                pic = null;
                
                pictureBoxReport.Image = null;
                pictureBox1.Image = null;
            }
        }
        private void mbtnTestConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                pic = null;
                string q = "insert into report(report,rtype,date,p_id,upload) VALUES(@pic,'" + mBtnTest.Text + "','" + DateTime.Now + "','" + Convert.ToInt32(txtPId.Text) + "','" + false + "')";
                db.dbc(q, image.image_ToByte(Properties.Resources.unavailable_20px));
                LoadR();
                test_reload();
                combo_reload();
            }
            catch(FormatException)
            {
                MessageBox.Show("Error in patient id");
            }
            
        }

        private void test_reload()
        {
            pictureBox1.Image = null;
            mbtnTestConfirm.Text = "Not Selected";
            mBtnTest.Text = "Not Selected";
            txtPId.Text = "";
        }

        private void combo_reload()
        {
            comboRType.Text = "CELLULAR AND CHEMICAL ANALYSIS";
            comboSType.Text = "DIAGNOSTIC IMAGING";
            comboTType.Text = "GENETIC TESTING";
            comboWType.Text = "MEASUREMENT";
            comboXType.Text = "PHYSICAL AND VISUAL EXAMINATION";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void comboRType_SelectedValueChanged(object sender, EventArgs e)
        {
            select_value_changed(comboRType.Text);
        }

        private void comboSType_SelectedValueChanged(object sender, EventArgs e)
        {
            select_value_changed(comboSType.Text);
        }

        private void comboTType_SelectedValueChanged(object sender, EventArgs e)
        {
            select_value_changed(comboTType.Text);
        }

        private void comboWType_SelectedValueChanged(object sender, EventArgs e)
        {
            select_value_changed(comboWType.Text);

        }

        private void comboXType_SelectedValueChanged(object sender, EventArgs e)
        {
            select_value_changed(comboXType.Text);
            
        }

        private void select_value_changed(string s)
        {
            mBtnTest.Text = s;
            combo_reload();
        }

        private void mBtnUpload_Click(object sender, EventArgs e)
        {
            pic=image.Add_byte();
            pictureBoxReport.Image = image.byte_ToImage(pic);
        }

        private void mBtnSave_Click(object sender, EventArgs e)
        {
            if(pic!=null && rid!=0)
            {
                string q = "update report set report=@pic,upload='" + true + "'  where ID = '" + rid + "' ";
                db.dbc(q, pic);
                pic = null;
                rid = 0;
                pictureBoxReport.Image = null;
                pictureBox1.Image = null;
                mbtnTestConfirm.Text = "Not Selected";
                LoadR();
            }
            else
            {
                MessageBox.Show("Upload report");
            }
        }

        private void report_reload()
        {
            txtPrescription.Text = "";
            txtDId.Text = "";
            pictureBoxReport.Image = null;
        }
        private void mbtnResetAll_Click(object sender, EventArgs e)
        {
            combo_reload();
            test_reload();
            report_reload();
        }

        private void txtPId_Enter(object sender, EventArgs e)
        {
            combo_reload();
            test_reload();
            txtDId.Text = null;
            txtPrescription.Text = null;
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnResetCombo_Click(object sender, EventArgs e)
        {
            combo_reload();
            mBtnTest.Text = "Not Selected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Panel s = new Staff_Panel(sid);
            this.Hide();
            s.Show();
        }

        private void txtDId_Enter(object sender, EventArgs e)
        {
            txtDId.Text = "";
            txtPrescription.Text = "";
        }

        private void txtPId_TextChanged(object sender, EventArgs e)
        {
            pictureBoxReport.Image = null;
            if (txtPId.Text != "")
            {
                try
                {
                    pid = Convert.ToInt32(txtPId.Text);
                    if (db.HasRows("select * from UInf where id='" + pid + "'"))
                    {
                        
                        get_info();
                    }
                    else
                    {
                        mbtnTestConfirm.Text = "Not Found";
                        pic = null;

                        pictureBox1.Image = null;
                    }
                    
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Null not acceptable in ID");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Only 0-9 acceptable in ID");
                }
            }
            else
            {
                mbtnTestConfirm.Text = "Not Selected";
                pic = null;

                mBtnTest.Text = "SELECT A TEST";
                pictureBox1.Image = null;
            }
        }

        private void txtDId_TextChanged(object sender, EventArgs e)
        {
            if (txtPId.Text != "")
            {
                try
                {
                    if (txtDId.Text == "")
                    {
                        txtPrescription.Text = "";
                    }
                    else
                    {
                        did = Convert.ToInt32(txtDId.Text);
                        if(db.HasRows("select * from Appointment where d_id='" + did + "' and p_id = '" + pid + "'"))
                        {
                            txtPrescription.Text = db.prescription(Convert.ToInt32(txtDId.Text), Convert.ToInt32(txtPId.Text));
                        }
                        else
                        {
                            mBtnSearchPrescription.Text = "No Prescription";
                        }   
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Prescription Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("At first fill patient id.");
            }
        }
    }
}
