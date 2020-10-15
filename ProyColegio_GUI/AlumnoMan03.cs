using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyColegio_GUI
{
    public partial class AlumnoMan03 : Form
    {
        public AlumnoMan03()
        {
            InitializeComponent();
        }

        private String _Id;
        public String Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
    }
}
