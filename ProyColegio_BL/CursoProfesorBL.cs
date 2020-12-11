using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyColegio_ADO;
using ProyColegio_BE;
using System.Data;

namespace ProyColegio_BL {

    public class CursoProfesorBL {
        CursoProfesorADO objCursoProfADO = new CursoProfesorADO();

        public DataTable ListarCursoProfesor() {
            return objCursoProfADO.ListarCursoProfesor();
        }

    }
}
