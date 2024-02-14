using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfExtract
    {
        void ExtractPages(string sourcePdfPath, string outputPdfPath, int pageNumber);
        void ExtractPages(string sourcePdfPath, string outputPdfPath, int startPage, int endPage);
    }
}
