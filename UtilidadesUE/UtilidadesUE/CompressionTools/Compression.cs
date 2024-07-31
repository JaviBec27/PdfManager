using System;
using System.IO.Compression;

namespace UtilidadesUE.CompressionTools
{
    public static class Compression //: ICompressionFile
    {
        public static void AddZipFiles(System.IO.FileInfo[] filesPath, string outFilePath)
        {
            //Obtiene info de la ruta de salida
            var outputFileInfo = new System.IO.FileInfo(outFilePath);

            //si el directorio no existe, lo crea
            if (!System.IO.Directory.Exists(outputFileInfo.DirectoryName))
                System.IO.Directory.CreateDirectory(outputFileInfo.DirectoryName);

            if (System.IO.File.Exists(outputFileInfo.FullName))
                System.IO.File.Delete(outputFileInfo.FullName);

            using (var zipFile = ZipFile.Open(outFilePath, ZipArchiveMode.Create))
            {
                try
                {
                    foreach (var pdfFile in filesPath)
                        zipFile.CreateEntryFromFile(pdfFile.FullName, pdfFile.Name);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }//


    public interface ICompressionFile
    {
        void AddZipFiles(string[] filesPath, string outFilePath);
    }
}


