using ProyColegio_ADO;
using ProyColegio_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BL
{
    public class MatriculaBL
    {
        MatriculaADO objMatriculaADO = new MatriculaADO();

        public Int16 RegistrarMatricula(MatriculaBE objMatriculaBE)
        {
            return objMatriculaADO.RegistrarMatricula(objMatriculaBE);
        }
    }
}
