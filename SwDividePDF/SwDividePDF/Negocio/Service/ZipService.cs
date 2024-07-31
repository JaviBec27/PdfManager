using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwDividePDF.Negocio.Service
{
    public static class ZipService
    {
        /// <summary>
        /// Agrega un 
        /// </summary>
        /// <param name="originalFilePath"></param>
        /// <param name="filesToAddZipPath"></param>
        public static void AddFilesToZip(string originalFilePath, string filesToAddZipPath)
        {
            try
            {
                var originalFileName = UtilidadesUE.DirectoryManager.GetOriginalFileName(originalFilePath);
                var files = UtilidadesUE.DirectoryManager.GetFilesFromFolder(filesToAddZipPath);
                var zipPath = UtilidadesUE.DirectoryManager.GetZipOutputFilePath(filesToAddZipPath, originalFileName);
                UtilidadesUE.CompressionTools.Compression.AddZipFiles(files, zipPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
