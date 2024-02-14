using iTextSharp.text;
using iTextSharp.text.pdf;


namespace SwDividePDF.Negocio.Interface
{
    public interface IPdfJoin
    {
        void JoinPages(string sourcePath, string outputPdfPath);
    }
}
