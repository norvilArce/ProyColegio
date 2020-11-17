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
    public class AlumnoBL
    {
        AlumnoADO objAlumnoADO = new AlumnoADO();

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.InsertarAlumno(objAlumnoBE);
        }

        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }

        public Boolean EliminarAlumno(String strId)
        {
            return objAlumnoADO.EliminarAlumno(strId);
        }

        public AlumnoBE ConsultarAlumno(String strId)
        {
            return objAlumnoADO.ConsultarAlumno(strId);
        }

        public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumno();
        }

        public Int16 contarAlumnos()
        {
            return objAlumnoADO.contarAlumnos();
        }

        public DataTable ListarAlumnosPorPeriodo(int idPeriodo) {
            return objAlumnoADO.ListarAlumnosPorPeriodo(idPeriodo);
        }

        public DataTable ListarNotasAlumnoPorCurso(int idAlumno, int idPeriodo, int idCurso)
        {
            return objAlumnoADO.ListarNotasAlumnoPorCurso(idAlumno, idPeriodo, idCurso);
        }

    }
}
