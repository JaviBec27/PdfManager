using System.Collections.Generic;

namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfSplit
    {
        void SplitPages(string sourcePdfPath, string outputPdfPath, int LengthPagexDocument);
        void SplitPages(string sourcePdfPath, string outputPdfPath, int startPage, int LengthPagexDocument);

        void SplitPagesByPattern(string sourcePdfPath, Dictionary<int, int> divisorPattern, string pref, string name);
        void SplitPagesByPattern2(string sourcePdfPath, List<FilePatternManagement> filePatterns, string name);
    }
}
