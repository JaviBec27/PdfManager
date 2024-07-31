using System.Collections.Generic;

namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfSplit
    {
        //void SplitPages(string sourcePdfPath, string outputPdfPath, int LengthPagexDocument);
        //void SplitPages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument);
        void SplitPages(string sourcePdfPath, int startPage, int LengthPagexDocument);
    }

    public interface IpdfSplitZipOutput
    {
        void SplitPages(string sourcePdfPath, int LengthPagexDocument);
    }
}
