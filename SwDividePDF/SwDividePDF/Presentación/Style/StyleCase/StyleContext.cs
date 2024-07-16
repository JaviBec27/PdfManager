using SwDividePDF.Presentación.Style.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwDividePDF.Presentación.Style.StyleCase
{
    public class StyleContext
    {
        public IGlobalStyleStrategy globalStyleStrategy;

        public void SetStyleStrategy(IGlobalStyleStrategy styleStrategy)
        {
            globalStyleStrategy = styleStrategy;
        }

        public void ApplyStyle(Control control)
        {
            globalStyleStrategy?.ApplyStyle(control);
        }
    }
}
