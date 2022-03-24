using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Controls
{
    public class UserTextBox : TextBox
    {
        ErrorProvider err;

        public ErrorProvider Error
        {
            get { return err; }
            set { err = value; }
        }
        public UserTextBox()
        {
            this.Validating += UserTextBox_Validating;
        }

        public bool Kiemtrakitudacbiet(string inputkitu)
        {
            inputkitu = inputkitu ?? string.Empty;
            string strRegex = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputkitu))
                return (true);
            else
                return (false);
        }

        void UserTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!Kiemtrakitudacbiet(this.Text))
            {
                e.Cancel = true;
                this.Focus();
                Error.SetError(this, "Sai dinh dang roi !!!");

            }
            else
            {
                e.Cancel = false;
                Error.SetError(this, null);
            }
        }
    }
}
