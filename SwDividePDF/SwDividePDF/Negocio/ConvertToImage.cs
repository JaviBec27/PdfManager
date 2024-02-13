using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SwDividePDF.Negocio
{
    class ConvertToImage : PDFOperation
    {
        public ConvertToImage()
        {
        }

        public override void DividePages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument)
        {
            throw new NotImplementedException();
        }
    }
}
