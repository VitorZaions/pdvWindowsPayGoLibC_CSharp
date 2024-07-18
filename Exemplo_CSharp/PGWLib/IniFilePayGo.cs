using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static PGWLib.CustomObjects;
using static PGWLib.Enums;

namespace PGWLib
{
    class IniFilePayGo
    {
        private string path;

        public IniFilePayGo(string iniPath)
        {
            path = iniPath;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, EscapeString(value), path);
        }

        public string Read(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, path);
            return UnescapeString(temp.ToString());
        }

        private string EscapeString(string value)
        {
            return value?.Replace("\r", "\\r").Replace("\n", "\\n");
        }

        private string UnescapeString(string value)
        {
            return value?.Replace("\\r", "\r").Replace("\\n", "\n");
        }

        public void WriteResultadoTEF(ResultadoTEFPayGo resultado, string section)
        {
            Write(section, "ret", resultado.ret.ToString());
            Write(section, "ResultMessage", resultado.ResultMessage);
            Write(section, "transactionStatus", resultado.transactionStatus.ToString());

            for (int i = 0; i < resultado.Parametros.Count; i++)
            {
                var param = resultado.Parametros[i];
                Write(section, $"Parametros[{i}].parameterName", param.parameterName);
                Write(section, $"Parametros[{i}].parameterCode", param.parameterCode.ToString());
                Write(section, $"Parametros[{i}].parameterValue", param.parameterValue);
            }

            if (resultado.param != null)
            {
                Write(section, "param.parameterName", resultado.param.parameterName);
                Write(section, "param.parameterCode", resultado.param.parameterCode.ToString());
                Write(section, "param.parameterValue", resultado.param.parameterValue);
            }
        }

        public ResultadoTEFPayGo ReadResultadoTEF(string section)
        {
            ResultadoTEFPayGo resultado = new ResultadoTEFPayGo
            {
                ret = int.Parse(Read(section, "ret")),
                ResultMessage = Read(section, "ResultMessage"),
                transactionStatus = (E_PWCNF)Enum.Parse(typeof(E_PWCNF), Read(section, "transactionStatus")),
                Parametros = new List<PW_Parameter>()
            };

            int i = 0;
            while (true)
            {
                var paramName = Read(section, $"Parametros[{i}].parameterName");
                if (string.IsNullOrEmpty(paramName))
                    break;

                PW_Parameter param = new PW_Parameter
                {
                    parameterName = paramName,
                    parameterCode = ushort.Parse(Read(section, $"Parametros[{i}].parameterCode")),
                    parameterValue = Read(section, $"Parametros[{i}].parameterValue")
                };
                resultado.Parametros.Add(param);
                i++;
            }

            var singleParamName = Read(section, "param.parameterName");
            if (!string.IsNullOrEmpty(singleParamName))
            {
                resultado.param = new PW_Parameter
                {
                    parameterName = singleParamName,
                    parameterCode = ushort.Parse(Read(section, "param.parameterCode")),
                    parameterValue = Read(section, "param.parameterValue")
                };
            }

            return resultado;
        }
    }
}
