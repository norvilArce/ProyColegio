using ProyColegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BL
{
    public class PeriodoBL
    {
        PeriodoADO objPeriodoADO = new PeriodoADO();

        public DataTable ListarPeriodos()
        {
            return objPeriodoADO.listarPerdiodos();
        }
    }
}
