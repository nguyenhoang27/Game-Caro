using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public static class MaterialMessageBoxInfo
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = DialogResult.None;
            frmInfo info = new frmInfo();
            info.Text = caption;
            info.Message = message;
            result = info.ShowDialog();
            return result;
        }
    }
}
