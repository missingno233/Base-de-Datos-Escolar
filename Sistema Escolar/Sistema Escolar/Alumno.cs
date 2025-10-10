using Microsoft.Data.SqlClient;
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
    public partial class Alumno : Form
    {
        private Models.Conexion BD = new();
        private string? consulta;
        public Alumno()
        {
            InitializeComponent();

            MessageBox.Show("Si el icono de la ventana es verde, usted esta conectado", "Informe",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (BD.ProbarConexion() == true)
            {

                using (MemoryStream stream = new
                    (Properties.Resources.Conectado))
                {
                    this.Icon = new Icon(stream);
                }
            }
            else
            {

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

            consulta = "SELECT [IDAlumno]\r\n      " +
                ",[Nombre]\r\n      " +
                ",[Apellidos]\r\n      " +
                ",[Estatus]\r\n      " +
                ",[FechaHoraCreacion]\r\n  " +
                "FROM [dbo].[Alumno]";



            DataTable sabe = BD.Consultando(consulta);
            DGVDatos.DataSource = sabe;
        }

        private void TSBInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }


            consulta = "INSERT INTO [dbo].[Alumno]\r\n           " +
                "([Nombre]\r\n           " +
                ",[Apellidos]\r\n           " +
                ",[Estatus])\r\n     " +
                "VALUES\r\n           " +
                "(@Nombre\r\n           " +
                ",@Apellidos\r\n           " +
                ",@Estatus)\r\n";


            var parametros = new List<SqlParameter>
            {
                new ("@Nombre", txtNombre.Text.Trim()),
                new ("@Apellidos", txtApellidos.Text.Trim()),
                new ("@Estatus", RBEstatus.Checked)
            };

            BD.Consultando(consulta, parametros);

            TSBObtenerDatos.PerformClick();
        }

        private void TSBEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ingrese el ID que desea eliminar", "Advertencia"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtEliminar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            consulta = $"DELETE FROM [dbo].[Alumno]\r\n      " +
                $"WHERE IDAlumno = {txtEliminar.Text}";

            if (!string.IsNullOrEmpty(txtEliminar.Text))
            {
                if (int.TryParse(txtEliminar.Text, out int id))
                {

                    BD.Consultando(consulta);
                    TSBObtenerDatos.PerformClick();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un ID válido (número)", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEliminar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID a eliminar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEliminar.Focus();
            }

            btnEliminar.Enabled = false;
            txtEliminar.Enabled = false;
        }

        private void TSBEditar_Click(object sender, EventArgs e)
        {
            //es una herramienta misteriosa que nos ayudara mas tarde...
            DataGridViewRow r = DGVDatos.SelectedRows[0];


            //condicional para poder actualizar facilmente
            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                //consulta para editar
                consulta = "UPDATE [dbo].[Alumno]\r\n   " +
                    "SET [Nombre] = @Nombre\r\n      " +
                    ",[Apellidos] = @Apellidos\r\n      " +
                    ",[Estatus] = @Estatus\r\n      " +
                    ",[FechaHoraCreacion] = @FechaCreacion\r\n " +
                    "WHERE IDAlumno = @ID\r\n";


                //creamos los parametros necesarios
                var parametros = new List<SqlParameter>
                {
                    new ("@Nombre",txtNombre.Text.Trim()),
                    new ("@Apellidos", txtApellidos.Text.Trim()),
                    new ("@Estatus", RBEstatus.Checked),
                    new ("@ID", Convert.ToInt32(r.Cells["IDAlumno"].Value)),
                    new ("@FechaCreacion", DateTime.Now)//vi necesario aqui darle la una fecha aunque mi base
                                                        //ya lo hace por si sola
                };

                BD.Consultando(consulta, parametros);

                TSBObtenerDatos.PerformClick();
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un registro para editarlo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVDatos_SelectionChanged(object sender, EventArgs e)
        {

            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DGVDatos.SelectedRows[0];
                txtNombre.Text =
                        r.Cells["Nombre"].Value.ToString();

                RBEstatus.Checked =
                    Convert.ToBoolean(r.Cells["Estatus"].Value);

                txtApellidos.Text =
                    r.Cells["Apellidos"].Value.ToString();
            }
        }

    }
}
