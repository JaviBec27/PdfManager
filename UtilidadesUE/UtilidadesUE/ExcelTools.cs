using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Forms = System.Windows.Forms;


namespace UtilidadesUE
{
    public class ExcelTools
    {
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Permite cargar los datos de un archivo excel en un DataTable
        /// </summary>
        /// <param name="archivo">nombre del archivo xls o xlsx </param>
        /// <param name="nombreTabla">
        /// Nombre de la hoja, seleccion o rango de la tabla en el archivo excel.
        /// Si se quiere cargar todos los valores en la hoja: Hoja1$ español, Sheet1$
        /// Si se quiere cargar la seleccion: NombreSeleccion
        /// Si se quiere cargar un rango de la hoja: Hoja1$A1:C4
        /// </param>
        /// <returns>DataTable con el contenido del rango de seleccion en el archivo excel</returns>
        public System.Data.DataTable LoadExcelFile(string archivo, string nombreTabla)
        {
            if (!File.Exists(archivo))
            {
                ErrorMessage = "el archivo a cargar no existe!";
                return null;
            }

            var conexion = new OleDbConnection();
            //var conexion = "";
            var fi = new FileInfo(archivo.ToLower());

            switch (fi.Extension)
            {
                case ".xls":
                    conexion = new OleDbConnection(string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {0};Extended Properties=Excel 8.0;", archivo));
                    break;
                case ".xlsx":
                    conexion = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};Extended Properties=""Excel 12.0 Macro;HDR=YES;ImpoertMixedTypes=Text;TypeGuessRows=0 """, archivo));
                    break;
            }

            //var conn = string.Format(conexion, archivo);
            var consulta = "SELECT * from [" + nombreTabla + "]";
            var oleDbAdapter = new OleDbDataAdapter(consulta, conexion);
            var dt = new System.Data.DataTable();
            try
            {
                conexion.Open();
                oleDbAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                if (ErrorMessage.Contains(nombreTabla))
                    ErrorMessage = "El nombre de la hoja debe ser Hoja1. " + Environment.NewLine + ErrorMessage;

                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Permite Guardar un archivo excel en una ruta especificada, renderizando la informacion desde un DataGridView
        /// </summary>
        /// <param name="DgData">DataGridView con la información a exportar</param>
        /// <param name="path">directorio y nombre del archivo destino, donde se guardará la informacion. puede enviarse el formato *.xls|*.xlsx</param>
        /// <returns>F/V indicando si se guardo o nó la información</returns>
        public bool SaveExcelFromDataGridView(Forms.DataGridView DgData, string path, Forms.ProgressBar bar = null)
        {
            //Si el grid viene vacío, se aborta el proceso
            if (DgData.Rows.Count <= 0)
            {
                ErrorMessage = "El grid está vacío.";
                return false;
            }

            var xlapp = new Excel.Application();
            xlapp.Application.Workbooks.Add(Type.Missing);
            xlapp.Columns.ColumnWidth = 20;

            try
            {
                //Se crean los encabezados
                for (int i = 1; i < DgData.Columns.Count + 1; i++)
                {
                    var data = DgData.Columns[i - 1].HeaderText;
                    xlapp.Cells[1, i] = data;
                }

                //Se crea el cuerpo de la tabla
                for (int i = 0; i < DgData.Rows.Count; i++)
                {
                    for (int j = 0; j < DgData.Columns.Count; j++)
                    {
                        var data = "";
                        try
                        {
                            data = DgData.Rows[i].Cells[j].Value.ToString();
                            if (bar != null)
                                ShowProgress(ref bar, DgData.Rows.Count, i);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = ex.Message;
                            data = "";
                            break;
                        }

                        xlapp.Cells[i + 2, j + 1] = data;
                    }
                }

                xlapp.ActiveWorkbook.SaveCopyAs(Versionamiento.GetFullPathVersioning(path, Versionamiento.VersioningType.Identity));
                xlapp.ActiveWorkbook.Saved = true;
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
            finally
            {
                xlapp.Quit();
            }
        }

        /// <summary>
        /// Permite Guardar un archivo excel en una ruta especificada, Procesando la informacion almacenada en una tabla de datos DataTable
        /// </summary>
        /// <param name="dt">DataTable con la información a exportar</param>
        /// <param name="path">directorio y nombre del archivo destino, donde se guardará la informacion. puede enviarse el formato *.xls|*.xlsx</param>
        /// <returns>F/V indicando si se guardo o nó la información</returns>
        public bool SaveExcelFromDataTable(DataTable dt, string path, Forms.ProgressBar bar = null)
        {
            var cantidadFilas = dt.Rows.Count;
            //Si la tabla viene vacía, se aborta el proceso
            if (cantidadFilas <= 0)
            {
                ErrorMessage = "La tabla está vacía.";
                return false;
            }

            var xlapp = new Excel.Application();
            xlapp.Application.Workbooks.Add(Type.Missing);
            xlapp.Columns.ColumnWidth = 20;
            var cantidadColumnas = dt.Columns.Count;


            try
            {
                //Se crean los encabezados
                for (int i = 1; i < cantidadColumnas + 1; i++)
                {
                    var data = dt.Columns[i - 1].ToString();
                    xlapp.Cells[1, i] = data;
                }

                //Se crea el cuerpo de la tabla con su respectiva información
                for (int i = 0; i < cantidadFilas; i++)
                {
                    for (int j = 0; j < cantidadColumnas; j++)
                    {
                        var data = "";
                        try
                        {
                            data = dt.Rows[i][j].ToString();
                            if (bar != null)
                                ShowProgress(ref bar, cantidadFilas - 1, i);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = ex.Message;
                            data = "";
                            break;
                        }

                        xlapp.Cells[i + 2, j + 1] = data;
                    }
                }

                //se guarda la información en la ruta especificada
                xlapp.ActiveWorkbook.SaveCopyAs(Versionamiento.GetFullPathVersioning(path, Versionamiento.VersioningType.Identity));
                xlapp.ActiveWorkbook.Saved = true;
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
            finally
            {
                xlapp.Quit();
            }
        }

        /// <summary>
        /// Permite guardar un data table en un archivo csv con codificacion ANSI
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="path"></param>
        /// <param name="bar"></param>
        /// <returns></returns>
        public bool SaveCsvFromDataTable(DataTable dt, string path,System.ComponentModel.DoWorkEventArgs e, System.ComponentModel.BackgroundWorker worker=null )// Forms.ProgressBar bar = null)
        {
            var cantidadFilas = dt.Rows.Count;
            //Si la tabla viene vacía, se aborta el proceso
            if (cantidadFilas <= 0)
            {
                ErrorMessage = "La tabla está vacía.";
                return false;
            }

            var fi = new FileInfo(path);

            using (var SW = new StreamWriter(File.Create(path.Replace(fi.Extension, ".csv")), Encoding.Default))
            {
                try
                {
                    //bar.Value = 0;
                    var cantidadColumnas = dt.Columns.Count;

                    StringBuilder sb = new StringBuilder();
                    //Se crean los encabezados
                    for (int i = 1; i < cantidadColumnas + 1; i++)
                    {
                        var data = dt.Columns[i - 1].ToString();
                        sb.Append(data).Append(";");
                    }

                    SW.WriteLine(sb.ToString());

                    ////Se crea el cuerpo de la tabla con su respectiva información
                    for (int i = 0; i < cantidadFilas; i++)
                    {
                        sb.Clear();
                        for (int j = 0; j < cantidadColumnas; j++)
                        {
                            //El formato que se crea es  ="data";  para configurar que la información del archivo csv sea de tipo string y 
                            //cuando se abra el excel no convierta automáticamente a numero
                            sb.Append("=\"").Append(dt.Rows[i][j].ToString()).Append("\";");
                        }

                        SW.WriteLine(sb.ToString());

                        if (worker != null)
                            worker.ReportProgress((i * 100) / (cantidadFilas - 1));
                            //ShowProgress(ref bar, , i);
                    }
                    SW.Flush();
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message;
                    return false;
                }
                finally
                {
                    SW.Close();
                }
            }
        }

        public void UpdateItemFromExcel(string archivo, string nombreTabla, string columnaAtualizar, string columnaFiltro, string condicion, string data)
        {
            try
            {
                if (!File.Exists(archivo))
                {
                    ErrorMessage = "el archivo a cargar no existe!";
                    return;
                }

                OleDbConnection conexion = new OleDbConnection();
                //var conexion = "";
                var fi = new FileInfo(archivo.ToLower());

                switch (fi.Extension)
                {
                    case ".xls":
                        conexion = new OleDbConnection(string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {0};Extended Properties=Excel 8.0;", archivo));
                        break;
                    case ".xlsx":
                        conexion = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= {0};Extended Properties=""Excel 12.0 Macro;HDR=YES;ImpoertMixedTypes=Text;TypeGuessRows=0 """, archivo));
                        break;
                }

                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                conexion.Open();
                myCommand.Connection = conexion;
                sql = "Update [" + nombreTabla + "] set " + columnaAtualizar + " = '" + data + "' where " + columnaFiltro + " = '" + condicion + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

        }

        /// <summary>
        /// Sirve para visualizar el progreso de un proceso en un progressBar
        /// </summary>
        /// <param name="bar"></param>
        /// <param name="total"></param>
        /// <param name="partial"></param>
        public static void ShowProgress(ref Forms.ProgressBar bar, int total, int partial)
        {
            bar.Value = ((partial * 100) / total);
        }
    }
}
