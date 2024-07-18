using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PGWLib.CustomObjects;
using static PGWLib.Enums;

namespace PGWLib
{
    public class ResultadoTEFPayGo
    {
        public int ret;

        public List<PW_Parameter> Parametros;

        public string ResultMessage;

        public PW_Parameter param;

        public E_PWCNF transactionStatus;

        public ResultadoTEFPayGo() { }
    }
}
