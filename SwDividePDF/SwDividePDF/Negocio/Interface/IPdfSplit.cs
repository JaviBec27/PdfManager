using System.Collections.Generic;

namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfSplit
    {
        void SplitPages(string sourcePdfPath, string outputPdfPath, int LengthPagexDocument);
        void SplitPages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument);
    }
}
