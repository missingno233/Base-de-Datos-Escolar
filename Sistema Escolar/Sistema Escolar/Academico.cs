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
using Microsoft.Data.SqlClient;

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
            DataTable sabe = BD.Consultando(consulta);
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
            consulta = @"INSERT INTO [dbo].[Academico]         " +
                @"([Nombre]           " +
                @",[Apellidos]           " +
                @",[Grado])     " +
                @"VALUES           " +
                @"(@Nombre         " +
                @",@Apellidos          " +
                @",@Grado)";


            //estaba creando la condicional, pero no quería crear mas
            //registros en mi base de datos. Le pregunte a deepseek si
            //mi codigo hace lo que quiero y me enseñó lo que es el SQL Injection
            //sugirió agregar esto para evitarlo y cambiar los parametros en mi 

            var parametros = new List<SqlParameter>
            {
                new ("@Nombre", txtNombre.Text),
                new ("@Apellidos", txtApellidos.Text),
                new ("@Grado", cbGrado.SelectedItem)
            };

            //mandamos la consulta con los parametros de SQL
            BD.Consultando(consulta);

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
                    BD.Consultando(consulta);
                    TSBObtenerDatos.PerformClick();
                }
                //le hacemos saber que pasa al usuario
                else
                {
                    MessageBox.Show("Por favor ingrese un ID válido (número)", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEliminar.Focus();
                }
            }
            //le hacemos saber que pasa al usuario
            else
            {
                MessageBox.Show("Por favor ingrese un ID a eliminar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEliminar.Focus();
            }


        }

        private void TSBEditar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                consulta = "UPDATE [dbo].[IDAcademico]\r\n      " +
                " SET [Nombre] = @Nombre\r\n      " +
                ",[Apellidos] = @Apellidos\r\n      " +
                ",[Grado] = @Grado\r\n      " +
                "WHERE [dbo].[IDAcademico] = @ID";

                DataGridViewRow r = DGVDatos.SelectedRows[0];

                var parametros = new List<SqlParameter>
                {
                    new ("@Nombre",txtNombre.Text.Trim()),
                    new ("@Apellidos", txtApellidos.Text.Trim()),
                    new ("@Grado", cbGrado.SelectedItem ?? DBNull.Value),
                    new ("@ID", Convert.ToInt32(r.Cells["ID"].Value))
                };


            }
            else
            {
                MessageBox.Show("Porfavor seleccione un registro para editarlo.");
            }
        }

        private void DGVDatos_SelectionChanged(object sender, EventArgs e)
        {
            if(DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DGVDatos.SelectedRows[0];
                txtNombre.Text =
                        r.Cells["Nombre"].Value.ToString();

                cbGrado.SelectedItem =
                    r.Cells["Grado"].Value.ToString();

                txtApellidos.Text =
                    r.Cells["Apellidos"].Value.ToString();
            }
        }
    }
}
