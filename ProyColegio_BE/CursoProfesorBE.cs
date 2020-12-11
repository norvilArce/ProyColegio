using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE {
    class CursoProfesorBE {
        private int idCursoProfesor_;
        private int idCurso_;
        private int idProfesor_;
        private int idPeriodo_;
        private int cupos_;
               
        public int IdCursoProfesor {
            get { return idCursoProfesor_; }
            set { idCursoProfesor_ = value; }
        }

        public int IdCurso {
            get { return idCurso_; }
            set { idCurso_ = value; }
        }

        public int IdProfesor {
            get { return idProfesor_; }
            set { idProfesor_ = value; }
        }

        public int IdPeriodo {
            get { return idPeriodo_; }
            set { idPeriodo_ = value; }
        }

        public int Cupos {
            get { return cupos_; }
            set { cupos_ = value; }
        }
    }
}
