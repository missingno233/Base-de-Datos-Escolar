using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_Escolar
{
    public partial class Academico : Form
    {
        private Models.Conexion BD = new();
        private string? consulta;


        public Academico()
        {
            InitializeComponent();
            //le informamos al usuario sobre los iconos
            MessageBox.Show("Si el icono de la ventana es verde, usted esta conectado", "Informe",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Condicional para cambiar el icono dependiendo si se logro la conexion o no
            if (BD.ProbarConexion() == true)
            {
                //Usamos MemoryStream para poder acceder al icono
                using (MemoryStream stream = new
                    (Properties.Resources.Conectado))
                {
                    this.Icon = new Icon(stream);
                }
            }
            else
            {
                //Usamos MemoryStream para poder acceder al icono
                using (MemoryStream stream = new
                    (Properties.Resources.Desconectado))
                {
                    this.Icon = new Icon(stream);
                }
            }

            txtEliminar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void TSBObtenerDatos_Click(object sender, EventArgs e)
        {
            //consulta para seleccionar todos los registros
            consulta = "SELECT [IDAcademico]\r\n      " +
                ",[Nombre]\r\n      " +
                ",[Apellidos]\r\n      " +
                ",[Grado]\r\n      " +
                ",[FechaHoraCreacion]\r\n  " +
                "FROM [dbo].[Academico]";


            //llenamos el DGV
            DataTable sabe = BD.ObtenerDatos(consulta);
            DGVDatos.DataSource = sabe;
        }

        private void TSBInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidos.Text) ||
                cbGrado.SelectedItem == null)
            {
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }


            //consulta para seleccionar todos los registros
            consulta = $"INSERT INTO [dbo].[Academico]\r\n           " +
                $"([Nombre]\r\n           " +
                $",[Apellidos]\r\n           " +
                $",[Grado])\r\n     " +
                $"VALUES\r\n           " +
                $"('{txtNombre.Text}'\r\n           " +
                $",'{txtApellidos.Text}'\r\n           " +
                $",'{cbGrado.SelectedItem}')";           

            BD.ObtenerDatos(consulta);

            //llamamos al evento Obtenerdatos para actualizar la tabla
            TSBObtenerDatos.PerformClick();
        }

        private void TSBEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ingrese el ID que desea eliminar", "Advertencia"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Habilitamos el textbox y el boton para poder obtener el ID a eliminar
            txtEliminar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Consulta para eliminar
            consulta = $"DELETE FROM [dbo].[Academico]\r\n      " +
                $"WHERE [IDAcademico] = {txtEliminar.Text}";

            //Condicional para evitar informacion nula
            if (!string.IsNullOrEmpty(txtEliminar.Text))
            {
                //condicional para asegurar que sea un numero
                if (int.TryParse(txtEliminar.Text, out int id))
                {
                    BD.ObtenerDatos(consulta);
                    TSBObtenerDatos.PerformClick();
                }
                //le hacemos saber que pasa al usuario
                else
                {
                    MessageBox.Show("Por favor ingrese un ID válido (número)", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //le hacemos saber que pasa al usuario
            else
            {
                MessageBox.Show("Por favor ingrese un ID a eliminar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
