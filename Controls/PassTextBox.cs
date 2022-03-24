using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Controls
{
    public class PassTextBox:TextBox
    {
        ErrorProvider err;

        public ErrorProvider Error
        {
            get { return err; }
            set { err = value; }
        }

        public PassTextBox()
        {
            this.Validating += PassTextBox_Validating;
        }

        public bool Kiemtrapass(string pass)
        {
            if (!pass.Any(t => !Char.IsLetterOrDigit(t)) || pass.Length < 6)
                return false;

            return true;

        }
        void PassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!Kiemtrapass(this.Text))
            {
                e.Cancel = true;
                this.Focus();
                Error.SetError(this, "Thieu ki tu dac biet hoac it hon 6 ki tu kiaaaa");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(this, null);

            }
        }
    }
}
