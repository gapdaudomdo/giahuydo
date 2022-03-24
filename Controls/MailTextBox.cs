using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Controls
{
    public class MailTextBox:TextBox
    {
        ErrorProvider err;

        public ErrorProvider Error
        {
            get { return err; }
            set { err = value; }
        }
        public MailTextBox()
        {
            this.Validating += MailTextBox_Validating;
        }
        public  bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        void MailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isEmail(this.Text))
            {
                e.Cancel = true;
                this.Focus();
                Error.SetError(this, "Yêu cầu nhập đúng định dạng");
            }
            else
            {
                e.Cancel = false;
                Error.SetError(this, null);
            }
        }


    }
}
