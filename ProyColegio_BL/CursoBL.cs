using ProyColegio_ADO;
using ProyColegio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BL {
    public class CursoBL {

        CursoADO objCursoADO = new CursoADO();

        public Boolean InsertarCurso(CursoBE objCursoBE) {
            return objCursoADO.InsertarCurso(objCursoBE);
        }
        public Boolean ActualizarCurso(CursoBE objCursoBE) {
            return objCursoADO.ActualizarCurso(objCursoBE);
        }
        public Boolean EliminarCurso(int id) {
            return objCursoADO.EliminarCurso(id);
        }
        public CursoBE ConsultarCurso(int id) {
            return objCursoADO.ConsultarCurso(id);
        }
        public DataTable ListarCurso() {
            return objCursoADO.ListarCurso();
        }

    }
}
