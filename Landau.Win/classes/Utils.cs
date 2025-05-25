using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Landau.Win
{
    public static class Utils
    {
        public static bool isValidName(string name, ErrorProvider ep, TextBox txb, string error)
        {
            if (name == null)
            {
                ep.SetError(txb, error);
                return false;
            }
            bool a1 = name.Trim().Length > 1;
            bool a2 = !name.Any(Char.IsDigit);
            if (a1 && a2)
            {
                ep.SetError(txb, "");
                return true;
            }
            else
            {
                ep.SetError(txb, error);
                return false;

            }
        }
        public static bool isValidInstitution(string institution, ErrorProvider ep, TextBox txb, string error)
        {
            if (institution == null)
            {
                ep.SetError(txb, error);
                return false;
            }
            bool a1 = institution.Trim().Length > 2;
            if (a1)
            {
                ep.SetError(txb, "");
                return true;
            }
            else
            {
                ep.SetError(txb, error);
                return false;

            }
        }
        public static bool isValidPhoneNumber(string phone, ErrorProvider ep, MaskedTextBox mtxb, string error)
        {
            bool a1 = phone.Any(Char.IsDigit);
            bool a2 = phone.Length == 14;
            if (a1 && a2)
            {
                ep.SetError(mtxb, "");
                return true;
            }
            else
            {
                ep.SetError(mtxb, error);
                return false;
            }
        }
        public static bool isValidEmail(string email, ErrorProvider ep, TextBox txb, string error)
        {
            bool a1 = email.Trim().Length > 10;
            if (a1)
            {
                ep.SetError(txb, "");
                return true;
            }
            else
            {
                ep.SetError(txb, error);
                return false;
            }
        }
        public static bool isNotNull(object obj , ErrorProvider ep , ComboBox cmbx , string error)
        {
            if (obj != null )
            {
                ep.SetError(cmbx, "");
                return true;
            }
            else
            {
                ep.SetError(cmbx, error);
                return false;
            }
        }
        public static bool isNotEmpty(string str, ErrorProvider ep, TextBox txb, string error)
        {
            if(str != null && str != "")
            {
                ep.SetError(txb, "");
                return true;
            }
            else
            {
                ep.SetError(txb, error);
                return false;
            }
        }
    }
}
