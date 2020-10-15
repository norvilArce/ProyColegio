using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class PadreBE
    {
        private Int16 mvarid_padre;
        public Int16 IdPadre
        {
            get { return mvarid_padre; }
            set { mvarid_padre = value; }
        }

        private String mvardni_padre;
        public String DniPadre
        {
            get { return mvardni_padre; }
            set { mvardni_padre = value; }
        }

        private String mvarnom_padre;
        public String NomPadre
        {
            get { return mvarnom_padre; }
            set { mvarnom_padre = value; }
        }

        private String mvarapepat_padre;
        public String ApePatPadre
        {
            get { return mvarapepat_padre; }
            set { mvarapepat_padre = value; }
        }

        private String mvarapemat_padre;
        public String ApeMatPadre
        {
            get { return mvarapemat_padre; }
            set { mvarapemat_padre = value; }
        }

        private String mvaremail_padre;
        public String EmailPadre
        {
            get { return mvaremail_padre; }
            set { mvaremail_padre = value; }
        }

        private DateTime mvarfecnac_padre;
        public DateTime FecNacPadre
        {
            get { return mvarfecnac_padre; }
            set { mvarfecnac_padre = value; }
        }

        private String mvartel_padre;
        public String TelPadre
        {
            get { return mvartel_padre; }
            set { mvartel_padre = value; }
        }

        private String mvarcel_padre;
        public String CelPadre
        {
            get { return mvarcel_padre; }
            set { mvarcel_padre = value; }
        }

        private String mvardir_padre;
        public String DirPadre
        {
            get { return mvardir_padre; }
            set { mvardir_padre = value; }
        }

        private String mvarid_ubigeo;
        public String Id_Ubigeo
        {
            get { return mvarid_ubigeo; }
            set { mvarid_ubigeo = value; }
        }

        private String mvarusu_registro;
        public String Usu_Registro
        {
            get { return mvarusu_registro; }
            set { mvarusu_registro = value; }
        }

        private DateTime mvarfec_registro;
        public DateTime Fec_Registro
        {
            get { return mvarfec_registro; }
            set { mvarfec_registro = value; }
        }

        private String mvarusu_ult_mod;
        public String Usu_Ult_Mod
        {
            get { return mvarusu_ult_mod; }
            set { mvarusu_ult_mod = value; }
        }

        private DateTime mvarfec_ult_mod;
        public DateTime Fec_Ult_Mod
        {
            get { return mvarfec_ult_mod; }
            set { mvarfec_ult_mod = value; }
        }

        private Int16 mvarest_padre;
        public Int16 EstPadre
        {
            get { return mvarest_padre; }
            set { mvarest_padre = value; }
        }

    }
}
