using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class SalonBE
    {
        private Int16 mvarid_sal;
        public Int16 Id_Sal
        {
            get { return mvarid_sal; }
            set { mvarid_sal = value; }
        }

        private Int16 mvarid_prof;

        public Int16 Id_prof
        {
            get { return mvarid_prof; }
            set { mvarid_prof = value; }
        }
    }
}
