using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PGWLib
{
    public static class Util
    {
        public static string SomenteNumeros(string Value)
        {
            string resultString = string.Empty;
            Regex regexObj = new Regex(@"[^\d]");
            resultString = regexObj.Replace(Value, "");
            return resultString;
        }

        public static string SomenteDouble(string Value)
        {
            string resultString = string.Empty;
            Regex regexObj = new Regex(@"[^\d,]"); // Permite apenas dígitos e uma vírgula
            resultString = regexObj.Replace(Value, "");
            return resultString;
        }

    }
}
