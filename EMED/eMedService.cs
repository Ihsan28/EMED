using System;
using System.Collections.Generic;
using System.Linq;
/*https://www.nuget.org/packages/libphonenumber-csharp/
 * Install-Package libphonenumber-csharp -Version 8.12.1*/
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libphonenumber;

//using com.google.i18n.phonenumbers;

namespace EMED
{
    class eMedService
    {
        public static string internationalPhonenumber(string contact, string region)
        {
            string internationalPhoneNumber=null;
            try
            {
                string localPhoneNumber = contact;
                PhoneNumber pn = PhoneNumberUtil.Instance.Parse(localPhoneNumber, region);
                internationalPhoneNumber = pn.Format(PhoneNumberUtil.PhoneNumberFormat.INTERNATIONAL);
                //MessageBox.Show(internationalPhoneNumber);
            }
            catch(Exception)
            {
                MessageBox.Show("made an except");
                return contact;
            }
               //CONTACT NUMBER CONVERSION TO INTERNATIONAL FORMAT

            return internationalPhoneNumber;
        }


        public static string current_age(string birthdate)
        {

            TimeSpan t = DateTime.Now - Convert.ToDateTime(birthdate);
            //MessageBox.Show(t.ToString());
            int d = Convert.ToInt32(t.Days.ToString());

            if (d > 365)
            {
                d = d / 365;

                return d.ToString() + " years";
            }
            else if (d > 30)
            {
                d = d / 30;

                return d.ToString() + " months";
            }
            else if (d > 1)
            {

                return d.ToString() + " days";
            }
            else
                return t.ToString();
        }

        public static int genarate_code()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }

        /*   public static int findCountryCode(String countryShortCode)
          {

              com.google.i18n.phonenumbers.PhoneNumberUtil phoneUtil = com.google.i18n.phonenumbers.PhoneNumberUtil.getInstance();
              return phoneUtil.getCountryCodeForRegion(countryShortCode.ToUpper());

          } */

        public static string deleteLast(string s)
        {
            return s.Remove(s.Length - 1);
        }
    }
}
