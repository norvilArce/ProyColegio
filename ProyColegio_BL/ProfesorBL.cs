using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyColegio_ADO;
using ProyColegio_BE;

namespace ProyColegio_BL
{
    public class ProfesorBL
    {
        ProfesorADO objProfesorADO = new ProfesorADO();

        public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {
            return objProfesorADO.InsertarProfesor(objProfesorBE);
        }

        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            return objProfesorADO.ActualizarProfesor(objProfesorBE);
        }

        public Boolean EliminarProfesor(String strId)
        {
            return objProfesorADO.EliminarProfesor(strId);
        }

        public ProfesorBE ConsultarProfesor(String strId)
        {
            return objProfesorADO.ConsultarProfesor(strId);
        }

        public DataTable ListarProfesor()
        {
            return objProfesorADO.ListarProfesor();
        }

        public Int16 contarProfesores()
        {
            return objProfesorADO.contarProfesores();
        }

        public DataTable ListarCursosPorProfesor(int idProfesor) {
            return objProfesorADO.ListarCursosPorProfesor(idProfesor);
        }

    }
}
