using SwDividePDF.Presentación.Style.Interface;
using System.Drawing;
using System.Windows.Forms;

namespace SwDividePDF.Presentación.Style.StyleCase
{
    public class DarkStyle : IGlobalStyleStrategy
    {
        public void ApplyStyle(Control parentControl)
        {
            parentControl.BackColor = Color.FromArgb(45, 45, 48);
            parentControl.ForeColor = Color.White;

            foreach (Control childControl in parentControl.Controls)
            {
                ApplyStyle(childControl);
            }
        }
    }
}
