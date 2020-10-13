using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ProyColegio_ADO
{
    class ConexionADO
    {
        public string GetCnx()
        {
            string strCnx = 
                ConfigurationManager.ConnectionStrings["Colegio"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }

    }
}
