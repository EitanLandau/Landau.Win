﻿using System;
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
        public static bool isValidPhoneNumber(string phone, ErrorProvider ep, MaskedTextBox mtxb, string error)
        {
            bool a1 = (phone.Trim().Length == 10);
            bool a2 = phone.Any(Char.IsDigit);
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
    }
}
