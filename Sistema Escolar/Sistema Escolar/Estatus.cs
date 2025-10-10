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
    public partial class Estatus : Form
    {


        private Models.Conexion BD = new();

        private string? consulta;


        public Estatus()
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
            consulta = "SELECT [IDEstatus]\r\n      " +
                ",[ClaveEstatus]\r\n      " +
                ",[NombreEstatus]\r\n      " +
                ",[FechaHoraCreacion]\r\n      " +
                ",[Usuario]\r\n  " +
                "FROM [dbo].[Estatus]\r\n"; 


            DataTable sabe = BD.Consultando(consulta);
            DGVDatos.DataSource = sabe;
        }

        private void TSBInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtSiglas.Text) ||
                cbGrado.SelectedItem == null)
            {
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }


            consulta = "INSERT INTO [dbo].[Estatus]\r\n           " +
                "([ClaveEstatus]\r\n           " +
                ",[NombreEstatus]\r\n           " +
                ",[FechaHoraCreacion]\r\n           " +
                ",[Usuario])\r\n     " +
                "VALUES\r\n           " +
                "(<ClaveEstatus, int,>\r\n           " +
                ",<NombreEstatus, varchar(25),>\r\n           " +
                ",<FechaHoraCreacion, date,>\r\n           " +
                ",<Usuario, varchar(25),>)\r\n";



            var parametros = new List<SqlParameter>
            {
                new ("@Nombre", txtNombre.Text.Trim()),
                new ("@Apellidos", txtSiglas.Text.Trim()),
                new ("@Grado", cbGrado.SelectedItem)
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
            consulta = $"DELETE FROM [dbo].[Estatus]\r\n      " +
                $"WHERE IDEstatus = {txtEliminar.Text}";

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
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtSiglas.Text) ||
                cbGrado.SelectedItem == null)
            {
                //le informamos al usuario
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }



            DataGridViewRow r = DGVDatos.SelectedRows[0];


            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                consulta = "UPDATE [dbo].[Estatus]\r\n   " +
                    "SET [ClaveEstatus] = <ClaveEstatus, int,>\r\n      " +
                    ",[NombreEstatus] = <NombreEstatus, varchar(25),>\r\n      " +
                    ",[FechaHoraCreacion] = <FechaHoraCreacion, date,>\r\n      " +
                    ",[Usuario] = <Usuario, varchar(25),>\r\n " +
                    "WHERE <Condiciones de búsqueda,,>\r\n";



                var parametros = new List<SqlParameter>
                {
                    new ("@Nombre",txtNombre.Text.Trim()),
                    new ("@Apellidos", txtSiglas.Text.Trim()),
                    new ("@Grado", cbGrado.SelectedItem.ToString()),
                    new ("@ID", Convert.ToInt32(r.Cells["IDAcademico"].Value)),
                    new ("@FechaCreacion", DateTime.Now)
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

                cbGrado.SelectedItem =
                    r.Cells["Grado"].Value.ToString();

                txtSiglas.Text =
                    r.Cells["Apellidos"].Value.ToString();
            }
        }
    }
