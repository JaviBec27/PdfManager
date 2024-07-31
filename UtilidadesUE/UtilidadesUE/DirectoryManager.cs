using System.IO;

namespace UtilidadesUE
{

    public static class DirectoryManager
    {
        /// <summary>
        /// Devuelve un la ruta de Asegura que el directorio especificado exista. Si el directorio ya existe y se indica, será eliminado y recreado.
        /// </summary>
        /// <param name="path">Ruta del directorio a asegurar</param>
        /// <param name="deleteIfExists">Indica si el directorio existente debe ser eliminado antes de crear uno nuevo, true por default</param>
        /// <returns>Ruta del directorio asegurado</returns>
        public static string EnsureDirectoryExists(string path, bool deleteIfExists = true)
        {
            if (deleteIfExists && Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        /// <summary>
        /// Obtiene la ruta del directorio de salida combinando la ruta del archivo fuente con la nueva carpeta especificada.
        /// El directorio se asegura de existir, eliminándolo si es necesario.
        /// </summary>
        /// <param name="sourcePath">Ruta del archivo de entrada</param>
        /// <param name="newFolder">Nombre de la nueva carpeta de salida</param>
        /// <param name="deleteIfExists">Indica si el directorio existente debe ser eliminado antes de crear uno nuevo</param>
        /// <returns>Ruta del directorio de salida</returns>
        public static string GetOutputDirectoryPath(string sourcePath, string newFolder, bool deleteIfExists = true)
        {
            var originPathInfo = new FileInfo(sourcePath);

            if (!originPathInfo.Exists)
            {
                throw new FileNotFoundException("Archivo no encontrado", sourcePath);
            }

            var outputPath = Path.Combine(originPathInfo.DirectoryName, newFolder);
            return EnsureDirectoryExists(outputPath, deleteIfExists);
        }

        /// <summary>
        /// Obtiene el nombre del archivo a partir de la ruta del archivo fuente.
        /// </summary>
        /// <param name="sourcePath">Ruta del archivo de entrada</param>
        /// <returns>Nombre del archivo</returns>
        public static string GetOriginalFileName(string sourcePath)
        {
            var originPathInfo = new FileInfo(sourcePath);

            if (!originPathInfo.Exists)
            {
                throw new FileNotFoundException("Archivo no encontrado", sourcePath);
            }

            return originPathInfo.Name;
        }

        /// <summary>
        /// Obtiene una ruta completa de salida combinando la ruta del directorio de salida y el nombre del archivo original.
        /// </summary>
        /// <param name="sourcePath">Ruta del archivo de entrada</param>
        /// <param name="newFolder">Nombre de la nueva carpeta de salida</param>
        /// <returns>Ruta completa de salida</returns>
        public static string GetOutputFullDirectoryPath(string sourcePath, string newFolder)
        {
            var outputPath = GetOutputDirectoryPath(sourcePath, newFolder);
            var fileName = GetOriginalFileName(sourcePath);
            return Path.Combine(outputPath, fileName);
        }

        /// <summary>
        /// Devuelve un array de objetos FileInfo que representan los archivos en la carpeta especificada.
        /// </summary>
        /// <param name="folderPath">Ruta del directorio que contiene los archivos</param>
        /// <returns>Array de objetos FileInfo representando los archivos en la carpeta</returns>
        public static FileInfo[] GetFilesFromFolder(string folderPath)
        {
            var directoryInfo = new DirectoryInfo(folderPath);

            if (!directoryInfo.Exists)
            {
                throw new DirectoryNotFoundException("Directorio no encontrado: " + folderPath);
            }

            return directoryInfo.GetFiles();
        }

        /// <summary>
        /// Devuelve la ruta de un archivo .zip para almacenar los archivos generados, basado en el archivo original.
        /// Si el directorio no existe, será creado.
        /// </summary>
        /// <param name="directoryFilesGeneratedPath">Ruta del directorio donde se generará el archivo .zip</param>
        /// <param name="originalFileName">Nombre del archivo base, por ejemplo, "mi_archivo.pdf"</param>
        /// <returns>Ruta completa del archivo .zip</returns>
        public static string GetZipOutputFilePath(string directoryFilesGeneratedPath, string originalFileName)
        {
            var outputPath = EnsureDirectoryExists(directoryFilesGeneratedPath, false);

            var fileInfo = new FileInfo(originalFileName);
            var zipFileName = Path.ChangeExtension(fileInfo.Name, ".zip");

            return Path.Combine(outputPath, zipFileName);
        }
    }
}


