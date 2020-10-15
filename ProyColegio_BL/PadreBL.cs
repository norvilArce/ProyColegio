using ProyColegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BL
{
    public class PadreBL
    {
        PadreADO objPadreADO = new PadreADO();

        public DataTable ListarPadre()
        {
            return objPadreADO.listarPadres();
        }

    }
}
