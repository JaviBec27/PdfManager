using SwDividePDF.Presentación.Style.Interface;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SwDividePDF.Presentación.Style.StyleCase
{
    public class GreenRainDay : IGlobalStyleStrategy
    {
        Color mainColor = Color.YellowGreen;
        Dictionary<string, (Color, Color)> colorMapping;

        public GreenRainDay()
        {
            colorMapping = new Dictionary<string, (Color backColor, Color flatBackColor)>
            {
                { "Secondary", (Color.FromArgb(64, 64, 67), mainColor) },
                { "Primary", (mainColor, Color.FromArgb(64, 64, 67)) },
                { "Default", (mainColor, Color.FromArgb(64, 64, 67)) }
            };
        }



        public void ApplyStyle(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Panel panel)
                {
                    if (panel.Name.Contains("BorderPanel"))
                    {
                        panel.BackColor = mainColor; // Color de fondo
                    }
                }
                if (control is Button button)
                {
                    var colors = GetButtonColors(button.Name);

                    button.BackColor = colors.backColor;
                    button.ForeColor = Color.White; // Color de texto
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Color.FromArgb(221, 221, 221); // Color del borde
                    button.FlatAppearance.MouseOverBackColor = colors.flatBackColor;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White; // Color de fondo
                    textBox.ForeColor = Color.FromArgb(51, 51, 51); // Color de texto
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.ForeColor = Color.FromArgb(51, 51, 51); // Color del texto del groupbox
                }

                // Aplica los estilos recursivamente a los controles hijos
                if (control.Controls.Count > 0)
                {
                    ApplyStyle(control);
                }
            }
        }

        private (Color backColor, Color flatBackColor) GetButtonColors(string buttonName)
        {


            foreach (var key in colorMapping.Keys)
            {
                if (buttonName.Contains(key))
                {
                    return colorMapping[key];
                }
            }

            // Default colors if no match is found
            return (colorMapping["Default"]);
        }
    }
}
