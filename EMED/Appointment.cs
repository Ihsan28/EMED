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
    public partial class Appointment : MaterialForm
    {
        int p;
        int d;
        string nam;
        bool old = false;
        bool prescribe=false;
        public Appointment(int p_id)
        {
            InitializeComponent();
            p = p_id;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void uInfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uInfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medDBDataSet);

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDBDataSet.UInf' table. You can move, or remove it, as needed.
            this.uInfTableAdapter.DOCTOR(this.medDBDataSet.UInf);

        }

        private void uInfDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Image g;
            string id = uInfDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
            prescribe = false;
            old = false;
            try
            {
                d = Convert.ToInt32(id);

                //string q = "select image from UInf where id='" + d + "'";
                g = db.Image(d);

                string q1= "select prescribed from Appointment where d_id='" + d + "' and p_id='" + p + "'";
                old = db.HasRows(q1);
                if(old==true)
                {
                    prescribe = db.prescrib(d, p);
                }
                
                nam = db.name(d);

                string qf = db.qo(d);

                if (g != null&& nam != null && qf != null)
                {
                    
                    if(old==true)
                    {
                        if (prescribe == false)
                        {
                            panelStatus.BackgroundImage = Properties.Resources.ok_100px;
                        }
                        else
                        {
                            panelStatus.BackgroundImage = Properties.Resources.icons8_caduceus_100_1_;
                        }
                        
                    }
                    else
                    {
                        panelStatus.BackgroundImage = Properties.Resources.double_left_100px;
                    }
                    pictureBox1.Image = g;
                    mbtnAppointment.Text = nam;
                    txtQualification.Text = qf;
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
                mbtnAppointment.Text = "Not Selected";
            }

        }

        
        private void mbtnAppointment_Click(object sender, EventArgs e)
        {
            if (old == true)
            {
                if(prescribe==true)
                {
                    appointment(false);     // an appointment for old patient
                    panelStatus.BackgroundImage = Properties.Resources.ok_100px;
                    prescribe = false;
                }
                else
                {
                    appointment(true);     // cancel an appointment for old patient
                    panelStatus.BackgroundImage = Properties.Resources.icons8_caduceus_100_1_;
                    prescribe = true;
                }
            }
            else
            {
                string q = "insert into Appointment(p_id,d_id,prescription,prescribed)"+
                    " VALUES('" + p + "','" + d + "','"+"//NEW PATIENT(erase this text before start)"+"','"+false+"') ";// an appointment for new patient
                db.dba(q);

                panelStatus.BackgroundImage = Properties.Resources.ok_100px;
                prescribe = false;
                old = true;

            }
        }
        private void appointment(bool b)
        {
            string q = "update Appointment set prescribed='" + b + "' where d_id='" + d + "' and p_id='" + p + "'";
            db.dba(q);
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

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Patient_Panel pp = new Patient_Panel(p);
            this.Hide();
            pp.Show();
        }
    }
}
