using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class Academico : Form
    {

        Models.Conexion conexion = new Models.Conexion();


        public Academico()
        {
            InitializeComponent();
        }

        private void TSBObtenerDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
