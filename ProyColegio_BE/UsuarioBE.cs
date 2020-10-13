using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class UsuarioBE
    {
        private String mvarlogin_usuario;
        private String mvarpass_usuario;
        private Int16 mvarniv_usuario;
        private Int16 mvarest_usuario;
        private DateTime mvarfec_registro;
        private String mvarusu_registro;

        public String LogUsu
        {
            get { return mvarlogin_usuario; }
            set { mvarlogin_usuario = value; }
        }

        public String PassUsu
        {
            get { return mvarpass_usuario; }
            set { mvarpass_usuario = value; }
        }

        public Int16 NivUsu
        {
            get { return mvarniv_usuario; }
            set { mvarniv_usuario = value; }
        }

        public Int16 EstUsu
        {
            get { return mvarest_usuario; }
            set { mvarest_usuario = value; }
        }

        public DateTime FecReg
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }

        public String UsuReg
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }

    }
}
