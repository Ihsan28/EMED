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
    public partial class Patient_list : MaterialForm
    {
        int d_id;
        int pid;
        Image g = null;
        string name = null;
        public Patient_list(int d)
        {
            InitializeComponent();
            this.d_id = d;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Patient_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDBDataSet.Appointment' table. You can move, or remove it, as needed.
            //this.appointmentTableAdapter.Fill(this.medDBDataSet.Appointment);
            string q = "select * from Appointment where d_id='" + d_id+"' and prescribed = '"+false+"'";
            //DataGrid d = new DataGrid();
            //d.DataSource= db.db_table(q);
            
            appointmentDataGridView.DataSource = db.db_table(q);
            appointmentDataGridView.AutoGenerateColumns = false;
            //this.appointmentDataGridView = d;
            // TODO: This line of code loads data into the 'medDBDataSet.Appointment' table. You can move, or remove it, as needed.
            //this.appointmentTableAdapter.Fill(this.medDBDataSet.Appointment);
            //DataSet ds = new DataSet();
            //ds = db.db_set(q);
            //this.appointmentTableAdapter.Fill(ds);

        }
        
        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medDBDataSet);

        }

        private void mbtnPrescrib_Click(object sender, EventArgs e)
        {
            if(mbtnPrescrib.Text!="Not Selected")
            {
                Prescrib p = new Prescrib(d_id,pid,name);
                this.Hide();
                p.Show();
            }
        }

        private void appointmentDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string id = appointmentDataGridView.Rows[e.RowIndex].Cells["p_id"].Value.ToString();
            try
            {
                pid = Convert.ToInt32(id);

                string q = "select image from UInf where id='" + pid + "'";
                name = db.name(pid);
                g = db.Img(q);
                if (g != null&& name != null)
                {
                    pictureBox1.Image = g;
                    mbtnPrescrib.Text = name;
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
                mbtnPrescrib.Text = "Not Selected";
            }

            //MessageBox.Show(id);
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Doctor_Panel d = new Doctor_Panel(d_id);
            this.Hide();
            d.Show();
        }
    }
}
