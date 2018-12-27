using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Game_Caro
{
    public static class MaterialMessageBoxOK
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = DialogResult.None;
            frmOK oKCancel = new frmOK();
            oKCancel.Text = caption;
            oKCancel.Message = message;
            result = oKCancel.ShowDialog();
            return result;
        }

    }
}
