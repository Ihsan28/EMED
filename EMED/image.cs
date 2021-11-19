using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace EMED
{
    class image
    {
        public static string location = null;

        public static Image Add()
        {
            try
            {
                location = Browse();

                FileStream stm = new FileStream(location, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stm);
                byte[] img_byte = brs.ReadBytes((int)stm.Length);
                MemoryStream mstm = new MemoryStream(img_byte);
                Image img = Image.FromStream(mstm);

                return img;
            }
            catch(ArgumentException)
            {
                return null;
            }
        }

        public static byte[] Add_byte()
        {
            location = Browse();
            byte[] img_byte=null;
            if (location!="")
            {
                FileStream stm = new FileStream(location, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stm);
                img_byte = brs.ReadBytes((int)stm.Length);
            }
            
            
            return img_byte;
        }

        public static string Browse()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            //dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName.ToString());
            }

            return dialog.FileName.ToString();
        }

        public static Image Retrieve(string uname)
        {
            Image g = null;

            string q = "select image from UInf where uname='" + uname + "'";
            g = db.Img(q);

            return g;
        }

        public static Image byte_ToImage(byte[] img_byte)
        {
            Image img = null;
            if (img_byte != null)
            {
                MemoryStream mstm = new MemoryStream(img_byte);
                img = Image.FromStream(mstm);
            }

            return img;
        }

        public static byte[] image_ToByte(Image img)
        {
            try
            {
                if (img != null)
                {
                    var ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    return ms.ToArray();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
