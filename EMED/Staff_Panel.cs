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
    public partial class Staff_Panel : MaterialForm
    {
        int sid;
        public Staff_Panel(int s)
        {
            InitializeComponent();

            this.sid = s;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.BlueGrey900, Primary.BlueGrey300, Accent.LightBlue200, TextShade.WHITE);

            pictureBox1.Image = db.Image(sid);
            mbtnName.Text = db.name(sid);
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Report_Upload r = new Report_Upload(sid);
            this.Hide();
            r.Show();
        }
    }
}
