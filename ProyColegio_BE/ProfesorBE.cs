using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BE
{
    public class ProfesorBE
    {
        private Int16 mvarid_prof;
        public Int16 IdProfesor
        {
            get { return mvarid_prof; }
            set { mvarid_prof = value; }
        }

        private String mvardni_prof;
        public String DniProfesor
        {
            get { return mvardni_prof; }
            set { mvardni_prof = value; }
        }

        private String mvarnom_prof;
        public String NomProfesor
        {
            get { return mvarnom_prof; }
            set { mvarnom_prof = value; }
        }

        private String mvarapepat_prof;
        public String ApePatProfesor
        {
            get { return mvarapepat_prof; }
            set { mvarapepat_prof = value; }
        }

        private String mvarapemat_prof;
        public String ApeMatProfesor
        {
            get { return mvarapemat_prof; }
            set { mvarapemat_prof = value; }
        }

        private String mvaremail_prof;
        public String EmailProfesor
        {
            get { return mvaremail_prof; }
            set { mvaremail_prof = value; }
        }

        private DateTime mvarfecnac_prof;
        public DateTime FecNacProfesor
        {
            get { return mvarfecnac_prof; }
            set { mvarfecnac_prof = value; }
        }

        private String mvartel_prof;
        public String TelProfesor
        {
            get { return mvartel_prof; }
            set { mvartel_prof = value; }
        }

        private String mvarcel_prof;
        public String CelProfesor
        {
            get { return mvarcel_prof; }
            set { mvarcel_prof = value; }
        }

        private String mavrdir_prof;
        public String DirProfesor
        {
            get { return mavrdir_prof; }
            set { mavrdir_prof = value; }
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

        private Int16 mvarest_prof;
        public Int16 Est_Prof
        {
            get { return mvarest_prof; }
            set { mvarest_prof = value; }
        }

    }
}
