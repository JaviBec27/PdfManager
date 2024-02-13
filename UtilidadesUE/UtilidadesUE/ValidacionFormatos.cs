using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace UtilidadesUE
{
    public class ValidacionFormatos
    {
        public const string ExprMonth = @"(([0][0-9])|([1][0-2]))";
        public const string ExprDay = @"(([0-2][0-9])|([3][01]))";
        public const string ExprYear = @"([0-9][0-9])";
        public const string ExprHour = @"(([01][0-9])|([2][0-4]))";
        public const string ExprMin = @"([0-5][0-9])";
        public const string ExprSec = @"([0-5][0-9])";

        /// <summary>
        /// Valida una cadena simplemente en su tamaño, sin importar si es númerica  o alfabetica
        /// </summary>
        /// <param name="input">texto a validar</param>
        /// <param name="rango">longitud a comparar</param>
        /// <param name="exacto">determina si es una comparación exacta, o si solo importa que no supere el rango</param>
        /// <returns>True: Si está dentro del rango, False: si está por fuera del Rango</returns>
        public static bool ValidarRango(string input, int rango, bool exacto)
        {
            if (exacto)
                return input.Length == rango;
            else
                return input.Length <= rango;
        }

        /// <summary>
        /// Valida que una cadena contenga solo caracteres numéricos de un rango determinado
        /// </summary>
        /// <param name="input">cadena que se validará</param>
        /// <param name="rango">indica el rango que debe contener la cadena</param>
        /// <returns></returns>
        public static bool ValidarRangoNumerico(string input, int rango)
        {
            var expReg = "^[0-9]{" + rango + "}$";
            Regex re = new Regex(@expReg);
            return re.IsMatch(input);
        }

        /// <summary>
        /// Valida que una cadena contenga solo caracteres numéricos de un rango determinado
        /// </summary>
        /// <param name="input">cadena que se validará</param>
        /// <param name="rangoMinimo">indica el rango inicial que puede tener la cadena/param>
        /// <param name="rangoMaximo">indica el rango final que puede tener la cadena</param>
        /// <returns></returns>
        public static bool ValidarRangoNumerico(string input, int rangoMinimo, int rangoMaximo)
        {
            var expReg = "^[0-9]{" + Math.Abs(rangoMinimo) + "," + Math.Abs(rangoMaximo) + "}$";
            Regex re = new Regex(@expReg);
            return re.IsMatch(input);
        }

        /// <summary>
        /// Valida que una cadena contenga solo caracteres del alfabeto de un rango determinado
        /// </summary>
        /// <param name="input">cadena que se validará</param>
        /// <param name="rango">indica el rango que debe contener la cadena</param>
        /// <returns></returns>
        public static bool ValidarRangoAlfabetico(string input, int rango)
        {
            var expReg = "^[a-zA-Z]{" + rango + "}$";
            Regex re = new Regex(@expReg);
            return re.IsMatch(input);
        }

        /// <summary>
        /// Valida que una cadena contenga solo caracteres del alfabeto de un rango determinado
        /// </summary>
        /// <param name="input">cadena que se validará</param>
        /// <param name="rangoMinimo">indica el rango inicial que puede tener la cadena/param>
        /// <param name="rangoMaximo">indica el rango final que puede tener la cadena</param>
        /// <returns></returns>
        public static bool ValidarRangoAlfabetico(string input, int rangoMinimo, int rangoMaximo)
        {
            var expReg = "^[a-zA-Z]{" + Math.Abs(rangoMinimo) + "," + Math.Abs(rangoMaximo) + "}$";
            Regex re = new Regex(@expReg);
            return re.IsMatch(input);
        }

        /// <summary>
        /// Valida que una cadena contenga caracteres alfanuméricos de un rango determinado
        /// </summary>
        /// <param name="input">cadena que se validará</param>
        /// <param name="rangoMinimo">indica el rango inicial que puede tener la cadena</param>
        /// <param name="rangoMaximo">indica el rango final que puede tener la cadena</param>
        /// <param name="isEsp">permite definir si la validacion abarca caracteres especiales o no, true: incluir caracteres especiales, false: no incluir caracteres especiales a-zA-Z0-9 </param>
        /// <returns></returns>
        public static bool ValidarRangoAlfanumerico(string input, int rangoMinimo, int rangoMaximo, bool isEsp)
        {
            //var expReg = isEsp ? @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\-\.\,\ \(\)\/\u0022\´\!\¡\u00C3\“\'\`\#\%]" : @"^[a-zA-Z0-9]";//Caracteres simulacro digitalizacion
            string expReg = isEsp ? @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\-\–\.\,\ \(\)\/\u0022\!\¡\'\#\%\:\\]" : @"^[a-zA-Z0-9]";
            
            expReg += "{" + rangoMinimo + "," + rangoMaximo + "}$";
            Regex re = new Regex(expReg);

            if (re.IsMatch(input))
            {
                
            }
            return re.IsMatch(input);
        }

        public static bool ValidarRangoAnyString(string input, int rangoMinimo, int rangoMaximo)
        {
            return (input.Length >= rangoMinimo && input.Length <= rangoMaximo);
            
        }

        public static bool NoValidar()
        {
            return true;
        }

        public static bool ValidarPatron(string input, string pattern, int rango)
        {
            var expReg = @"^[" + pattern + "]";
            expReg += "{" + rango + "}$";
            Regex re = new Regex(expReg);
            return re.IsMatch(input);
        }

        public static bool ValidarPatron(string input, string pattern, int rangoMinimo, int rangoMaximo)
        {
            var expReg = @"^[" + pattern + "]";
            expReg += "{" + rangoMinimo + "," + rangoMaximo + "}$";
            Regex re = new Regex(expReg);
            return re.IsMatch(input);
        }

        /// <summary>
        /// Valida una estructura de tipo header
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cantidadSeparadores"></param>
        /// <returns></returns>
        public static bool ValidarFormatoHeader(string input, string cantidadSeparadores, string separador)
        {
            var exprReg = string.Format(@"^(([a-zA-Z0-9ñÑüÜáéíóúÁÉÍÓÚ]*[\{0}])", separador) + "{" + cantidadSeparadores + @"})[a-zA-Z0-9ñÑüÜáéíóúÁÉÍÓÚ]*$";
            Regex re = new Regex(exprReg);
            return (re.IsMatch(input));
        }

        /// <summary>
        /// Permite verificar si una cadena contiene la estructura de un codigo divipol real
        /// 7 NUMÉRICOS Y DOS ULTIMOS ALFANUMERICOS MAYUSCULA
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ValidarCodigoDivipol(string input)
        {
            var exprReg = @"^(([0-9]){7})+([A-Z0-9][A-Z0-9])$";
            Regex re = new Regex(exprReg);
            return (re.IsMatch(input));
        }

        /// <summary>
        /// Valida una estructura de tipo header
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cantidadSeparadores"></param>
        /// <returns></returns>
        public static bool ValidarFormatoHeader(string input, string separador)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var items = input.Split(';');
            foreach (var item in items)
            {
                var re = new Regex(@"^([0-9])+$");
                if (re.IsMatch(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static MatchCollection CoincidenciasCaracteresEspeciales(string input)
        {
            var expReg = @"[^a-zA-Z0-9áéíóúúÁÉÍÓüÜ]";
            var re = Regex.Matches(input, expReg);
            return re;
        }

        public static char? CaracterCoincidente(string input)
        {
            var coincidencias = CoincidenciasCaracteresEspeciales(input);
            if (coincidencias.Count == 0) return null;

            var cio = coincidencias[0].ToString();
            foreach (Match item in coincidencias)
            {
                if (cio != item.ToString())
                {
                    return null;
                }
            }

            return Convert.ToChar(cio);
        }

        /// <summary>
        /// Devuelve el nombre original de una arhivo sin ningun versionamiento
        /// </summary>
        /// <param name="fileName">nombre de archivo con complemento pero sin extension</param>
        /// <param name="vers">tipo de versionamiento que tiene el archivo</param>
        /// <returns></returns>
        public static string GetNombreWithOutVersion(string fileName, Versionamiento.VersioningType vers)
        {
            var expReg = "";

            switch (vers)
            {
                case Versionamiento.VersioningType.FullPath_ddMMyy_hhmmss:
                    expReg = @"([_]" + ExprDay + ExprMonth + ExprYear + @"\ " + ExprHour + ExprMin + ExprSec + @")\Z"; ////Expresion para buscar cadenas terminadas en ddMMyy hhmmss, etc...
                    break;
                case Versionamiento.VersioningType.FullPath_yyMMdd_hhmmss:
                    expReg = @"([_]" + ExprYear + ExprMonth + ExprDay + @"\ " + ExprHour + ExprMin + ExprSec + @")\Z"; ////Expresion para buscar cadenas terminadas en yyMMdd hhmmss, etc...
                    break;
                case Versionamiento.VersioningType.Identity:
                    expReg = @"([\(]([0-9]+)[\)])\Z"; //Expresion para buscar cadenas terminadas en (n), ejemplo: (1), (2), (3), etc...
                    break;
                default: expReg = @"([\(]([0-9]+)[\)])\Z";
                    break;
            }

            var name = Regex.Replace(fileName, expReg, "");
            return name;
        }

        /// <summary>
        /// Valida la estructura del codigo de diseño, longitud y inicie con la variable corp
        /// </summary>
        /// <param name="codDesign"></param>
        /// <param name="corp"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool ValidarFormatoCodigoDisenio(string codDesign, int maxLength, string corp, bool isTarjeta, out string error)
        {
            error = "";
            if (codDesign.Length != maxLength)
            {
                error = "Longitud Inválida.";
                return false;
            }


            var rg = isTarjeta ? new Regex(@"\A" + corp) : new Regex(@"\AGUIA" + corp);

            if (rg.IsMatch(codDesign)) return true;

            error = "Corporación Inválida.";
            return false;
        }


        /*
LONGITUD -> DEFINE LA LONGITUD QUE DEBE TENER MÁXIMO EL ARREGLO
EXACTO -> DEFINE SI LA LONGITUD DEBE SER EXACTA O VARIABLE DE 1 A LONGITUD.
VACIO/NULL? -> DEFINE SI ACEPTA VALORES NULOS O VACIOS
TIPO DE DATO -> DEFINE EL TIPO DE DATO QUE SE VALIDA, NUMERICO, ALFANUMERICO, ALFABETICO, ANY, BOOLEANO
         */

        public enum DataTypeVal {NUMERIC, ALPHANUMERIC, ALPHABETIC, ANY, BOOLEAN}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">valor a validar</param>
        /// <param name="lng">LONGITUD -> DEFINE LA LONGITUD QUE DEBE TENER MÁXIMO EL ARREGLO</param>
        /// <param name="isExact">EXACTO -> DEFINE SI LA LONGITUD DEBE SER EXACTA O VARIABLE DE 1 A LONGITUD.</param>
        /// <param name="isNullOrEmpty">VACIO/NULL? -> DEFINE SI ACEPTA VALORES NULOS O VACIOS</param>
        /// <param name="dataType">TIPO DE DATO -> DEFINE EL TIPO DE DATO QUE SE VALIDA, NUMÉRICO, ALFANUMÉRICO, ALFABÉTICO, CUALQUIERA, BOOLEANO</param>
        /// <returns></returns>
        //public static bool Validation(string input, int lng, bool isExact, bool isNullOrEmpty, DataTypeVal dataType  )
        //{

        //    if (isNullOrEmpty)
        //    {
        //        if (!string.IsNullOrEmpty(input))
        //        {
                    
        //        }
        //    }

        //    switch (dataType)
        //    {
        //        case DataTypeVal.NUMERIC:

        //            if (isExact)
        //            {
        //                ValidarRangoNumerico(input, lng);
        //            }
        //            else
        //            {

        //            }

        //            break;
        //        case DataTypeVal.ALPHANUMERIC:
        //            break;
        //        case DataTypeVal.ALPHABETIC:
        //            break;
        //        case DataTypeVal.ANY:
        //            break;
        //        case DataTypeVal.BOOLEAN:
        //            break;
        //        default:
        //            break;
        //    }
        
        //}
    }
}
