using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class PeriodoBE
    {
        private Int16 mvarid_periodo;
        public Int16 IdPeriodo
        {
            get { return mvarid_periodo; }
            set { mvarid_periodo = value; }
        }

        private DateTime mvarfec_ini;
        public DateTime FecInicio
        {
            get { return mvarfec_ini; }
            set { mvarfec_ini = value; }
        }

        private DateTime mvarfec_fin;
        public DateTime FecFin
        {
            get { return mvarfec_fin; }
            set { mvarfec_fin = value; }
        }
    }
}
