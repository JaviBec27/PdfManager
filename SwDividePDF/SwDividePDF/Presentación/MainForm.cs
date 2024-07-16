using SwDividePDF.Presentación.Style.Interface;
using SwDividePDF.Presentación.Style.StyleCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwDividePDF.Presentación
{
    public partial class MainForm :Form
    {
        protected StyleContext styleContext;
        protected IGlobalStyleStrategy _globalStyleStrategy = new BlueCore();
        public MainForm()
        {
            
            InitializeComponent();
            styleContext = new StyleContext();
            styleContext.SetStyleStrategy(_globalStyleStrategy);
            ApplyGlobalStyles();

        }

        protected virtual void ApplyGlobalStyles()
        {
            // Aquí se aplica el estilo seleccionado
            styleContext.ApplyStyle(this);
        }
    }
}
