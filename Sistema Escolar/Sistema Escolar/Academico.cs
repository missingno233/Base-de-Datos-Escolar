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
        //creamos el objeto BD para llamar su
        //metodo para mandar consultas
        private Models.Conexion BD = new();

        //para no crear una y otra vez la misma
        //consulta solo sobreescribirla 
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

            //para poder poder activarlo
            //cuando quieras eliminar
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
            consulta = "INSERT INTO[dbo].[Academico]\r\n            " +
                "([Nombre]\r\n           " +
                ", [Apellidos]\r\n           " +
                ", [Grado])\r\n           " +
                " VALUES" +
                "(@Nombre\r\n         " +
                ",@Apellidos\r\n          " +
                ",@Grado)";

            //estaba creando la condicional, pero no quería crear mas
            //registros en mi base de datos. Le pregunte a deepseek si
            //mi codigo hace lo que quiero y me enseñó lo que es el SQL Injection
            //sugirió agregar esto para evitarlo y cambiar los parametros en mi 

            var parametros = new List<SqlParameter>
            {
                new ("@Nombre", txtNombre.Text.Trim()),
                new ("@Apellidos", txtApellidos.Text.Trim()),
                new ("@Grado", cbGrado.SelectedItem)
            };

            //mandamos la consulta con los parametros de SQL
            BD.Consultando(consulta, parametros);

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
                consulta = "UPDATE [dbo].[Academico]\r\n      " +
                " SET [Nombre] = @Nombre\r\n      " +
                ",[Apellidos] = @Apellidos\r\n      " +
                ",[Grado] = @Grado\r\n      " +
                ",[FechaHoraCreacion] = @FechaCreacion\r\n" +
                "WHERE [IDAcademico] = @ID";


                //creamos los parametros necesarios
                var parametros = new List<SqlParameter>
                {
                    new ("@Nombre",txtNombre.Text.Trim()),
                    new ("@Apellidos", txtApellidos.Text.Trim()),
                    new ("@Grado", cbGrado.SelectedItem.ToString()),
                    new ("@ID", Convert.ToInt32(r.Cells["IDAcademico"].Value)),
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

            //con esta condicional llenamos los textbox y el combo
            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                //para evitar la fatiga
                DataGridViewRow r = DGVDatos.SelectedRows[0];
                txtNombre.Text =
                        r.Cells["Nombre"].Value.ToString();

                cbGrado.SelectedItem =
                    r.Cells["Grado"].Value.ToString();

                txtApellidos.Text =
                    r.Cells["Apellidos"].Value.ToString();
            }
        }

        private void TSBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
