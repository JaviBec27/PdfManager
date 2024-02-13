using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwDividePDF
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void dividePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DividePDF();
            Show(frm);
        }

        private void unePDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UnePDFs();
            Show(frm);
        }

        private void DivideByPatternMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DividePdfByPattern();
            Show(frm);
        }


        private void Show(Form frm)
        {
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            if (Validation(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private bool Validation(Form frmOpen)
        {
            return (Application.OpenForms.Count <= 1);
            
                
            

            foreach (Form frm in Application.OpenForms)
            {   
                if (frm.GetType() == frmOpen.GetType())
                {
                    UtilidadesUE.Mensajes.Mostrar("Ya se está ejecutando un proceso, cierre primero la ventana antes de iniciar un nuevo proceso.", UtilidadesUE.Mensajes.Tipos.Info, UtilidadesUE.Mensajes.Visualizacion.PopUp);

                    frm.Focus();
                    return false;
                }
            }


            return true;
        }

        private void agregarVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AddVersionAndDate();
            Show(frm);
        }
    }
}
