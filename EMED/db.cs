using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace EMED
{
    class db
    {
        private static DataTable dt;
        private static DataSet ds;
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-66AO60K\SQLEXPRESS;Initial Catalog=MedDB;Integrated Security=True");



        public static DataTable db_table(string q)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sdp.Fill(ds);
                dt = new DataTable();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public static DataSet db_set(string q)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sdp.Fill(ds);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public static SqlDataReader db_reader(string q)
        {
            
            SqlDataReader reader = null;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                reader = cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //reader.close();
                //con.Close();
            }
            return reader;
        }
        public static void dbc(string q,byte[] img)                //UPLOAD IMAGE
        {
            
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.Add(new SqlParameter("pic", img));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void dba(string q)                            //EXECUTE NON QUERY
        {

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static bool HasRows(string q)
        {
           
            SqlDataReader reader = null;
            bool i = false;

            try
            {
                
                reader = db_reader(q); 
                
                if (reader.HasRows)
                {
                    i= true;
                    //MessageBox.Show("User already exist!!!", "WARNING");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            finally
            {
                reader.Close();
                con.Close();
            }

            return i;
        }

        

        /// <summary>
        /// RETURN VALUE FROM REPORT TABLE
        /// </summary>
        public static Image report_img(int id)
        {
            Image g = null;
            SqlDataReader reader = null;
            string q = "select report from report where ID='" + id + "'";

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader["report"];

                        if (img == null)
                        {
                            return null;
                        }
                        else
                        {
                            g = image.byte_ToImage(img);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return g;
        }
        public static string report_name(int i)
        {
            string q = "select rtype from report where ID='" + i + "'";
            string s = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        s = (string)reader["rtype"];

                        if (s == null)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Report ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return s;
        }




        /// <summary>
        /// RETURN VALUE FROM UInf TABLE
        /// </summary>
        public static string name(int i)
        {
            string q = "select name from UInf where id='" + i + "'";
            string s= null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        s = (string)reader["name"];

                        if (s == null)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return s;
        }
        public static int id(string user,string pass)
        {
            string q = "select id from UInf where uname = '" + user + "' and password = '" + pass + "'";
            int i = 0;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        i = (int)reader["id"];

                        if (i == 0)
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User password is not correct!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }
           
            return i;
        }
        public static string utype(int i)
        {
            string q = "select utype from UInf where id='" + i + "'";
            string s = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        s = (string)reader["utype"];

                        if (s == null)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return s;
        }
        public static string patient_name(int i)
        {
            string q = "select name from UInf where id='" + i + "' and utype='" + "PATIENT" + "'";
            string s = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        s = (string)reader["name"];

                        if (s == null)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return s;
        }
        public static Image Image(int id)                           //RETURN BY ID FROM UInf
        {
            string q = "select image from UInf where id='" + id + "'";
            Image g = null;
            SqlDataReader reader = null;

            try
            {
                
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader["image"];

                        if (img == null)
                        {
                            return null;
                        }
                        else
                        {
                            g = image.byte_ToImage(img);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return g;
        }
        public static Image Img(string q)                           //RETURN BY QUERY FROM UInf
        {
            Image g = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader["image"];

                        if (img == null)
                        {
                            return null;
                        }
                        else
                        {
                            g = image.byte_ToImage(img);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return g;
        }

        public static string DOB(int i)
        {
            string q = "select dob from UInf where id='" + i + "'";
            DateTime t=new DateTime();
            SqlDataReader reader = null;

            try
            {
                
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        t = (DateTime)reader["dob"];
                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return t.ToString();
        }

        public static string prescription(int d,int p)
        {
            string q = "select prescription from Appointment where d_id='" + d + "' and p_id = '" + p + "'";
            string b = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        b = (string)reader["prescription"];
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return b;
        }

        public static string qo(int d)
        {
            string q = "select qo from UInf where id='" + d + "'";
            string b = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        b = (string)reader["qo"];
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return b;
        }

        public static bool prescrib(int d, int p)
        {
            string q = "select prescribed from Appointment where d_id='" + d + "' and p_id = '" + p + "'";
            bool b = false;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        b = (bool)reader["prescribed"];
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return b;
        }
        public static string email(int i)
        {
            string q = "select gmail from UInf where id='" + i + "'";
            string s = null;
            SqlDataReader reader = null;

            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand(q, con);
                reader = db_reader(q); //cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        s = (string)reader["gmail"];

                        if (s == null)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return s;
        }

        public static string[] user_info(int id)                           //RETURN BY ID USING string array FROM UInf
        {
            string q = "select * from UInf where id='" + id + "'";
            string[] a=new string[100];
            SqlDataReader reader = null;

            try
            {
                reader = db_reader(q); 

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        a[0] = (string)reader["uname"];
                        a[1] = (string)reader["name"];
                        a[2] = (string)reader["father"];
                        a[3] = Convert.ToString((DateTime)reader["dob"]);
                        a[4] = (string)reader["gender"];
                        a[5] = (string)reader["contact"];
                        a[6] = (string)reader["gmail"];
                        a[7] = (string)reader["blood"];
                        a[8] = (string)reader["qo"];
                        a[9] = (string)reader["address"];
                        a[10] = (string)reader["remark"];

                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return a;
        }

        public static user user_inf(int id)                           //RETURN ALL BY ID USING user FROM UInf
        {
            string q = "select * from UInf where id='" + id + "'";
            user u = new user();
            SqlDataReader reader = null;

            try
            {
                reader = db_reader(q);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        byte[] img = (byte[])reader["image"];

                        if (img == null)
                        {
                            u.pic= null;
                        }
                        else
                        {
                            u.pic = image.byte_ToImage(img);
                        }
                        u.utype = (string)reader["utype"];
                        u.uname = (string)reader["uname"];
                        u.name = (string)reader["name"];
                        u.password= (string)reader["password"];
                        u.fname = (string)reader["father"];
                        u.birthdate = Convert.ToString((DateTime)reader["dob"]);
                        u.gender = (string)reader["gender"];
                        u.contact = (string)reader["contact"];
                        u.email = (string)reader["gmail"];
                        u.blood = (string)reader["blood"];
                        u.qo = (string)reader["qo"];
                        u.address = (string)reader["address"];
                        u.remark = (string)reader["remark"];

                    }
                }
                else
                {
                    MessageBox.Show("User name is not valid!!!", "???", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Close();
            }

            return u;
        }

    }
}
