using SwDividePDF.Presentación.Style.Interface;
using System.Drawing;
using System.Windows.Forms;

namespace SwDividePDF.Presentación.Style.StyleCase
{
    public class LightStyle : IGlobalStyleStrategy
    {
        public void ApplyStyle(Control parentControl)
        {
            parentControl.BackColor = Color.White;
            parentControl.ForeColor = Color.Black;

            foreach (Control childControl in parentControl.Controls)
            {
                ApplyStyle(childControl);
            }
        }
    }
}
