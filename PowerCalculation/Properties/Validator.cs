using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerCalculation
{
    public static class Validator  // a collection of static validation methods
    {
        /// <summary>
        ///  Checks if the content of text box is not empty
        /// </summary>
        /// <param name="tb">Text box to check</param>
        /// <param name="name">Name to use in error message</param>
        /// <returns>is it valid</returns>
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true;  // "innocent until proven guilty"
            if(tb.Text == "")  // bad!
            {
                result = false;
                MessageBox.Show(name + " is a required field.", "Input Error");
                tb.Focus();

            }
            return result;
        }

        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int val; // for TryParse
            if(!Int32.TryParse(tb.Text, out val))  // not an int
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }
            else if(val < 0)  //negative
            {
                result = false;
                MessageBox.Show(name + " has to be positive or zero", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }

            return result;
        }
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double val; // for TryParse
            if (!Double.TryParse(tb.Text, out val))  // not an int
            {
                result = false;
                MessageBox.Show(name + " has to be a number", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }
            else if (val < 0)  //negative
            {
                result = false;
                MessageBox.Show(name + " has to be positive or zero", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }

            return result;
        }
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;
            decimal val; // for TryParse
            if (!Decimal.TryParse(tb.Text, out val))  // not a decimal
            {
                result = false;
                MessageBox.Show(name + " has to be a number", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }
            else if (val < 0)  //negative
            {
                result = false;
                MessageBox.Show(name + " has to be positive or zero", "Input Error");
                tb.SelectAll();  // highlight text on the box for easy replacing
                tb.Focus();
            }

            return result;
        }
    }
}
