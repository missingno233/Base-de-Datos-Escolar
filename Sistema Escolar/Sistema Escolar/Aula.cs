using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Sistema_Escolar.Models;
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
    public partial class Aula : Form
    {

        Models.Conexion BD = new Conexion();
        private String consulta;


        public Aula()
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

            consulta = "SELECT [IDAula]\r\n      " +
                ",[Edificio]\r\n      " +
                ",[Aula]\r\n      " +
                ",[Piso]\r\n      " +
                ",[CapacidadMaxima]\r\n      " +
                ",[FechaHoraCreacion]\r\n  " +
                "FROM [dbo].[Aula]\r\n";



            DataTable sabe = BD.Consultando(consulta);
            DGVDatos.DataSource = sabe;
        }

        private void TSBInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEdificio.Text) ||
                string.IsNullOrEmpty(txtAula.Text) ||
                cbCapacidad.SelectedItem == null ||
                cbPiso.SelectedItem == null)
            {
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }


            consulta = "INSERT INTO [dbo].[Aula]\r\n           " +
                "([Edificio]\r\n           " +
                ",[Aula]\r\n           " +
                ",[Piso]\r\n           " +
                ",[CapacidadMaxima])\r\n     " +
                "VALUES\r\n           " +
                "(@Edificio\r\n           " +
                ",@Aula\r\n           " +
                ",@Piso\r\n           " +
                ",@CapacidadMaxima)";


            var parametros = new List<SqlParameter>
            {
                new ("@Edificio", txtEdificio.Text.Trim()),
                new ("@Aula", txtAula.Text.Trim()),
                new ("@Piso", cbPiso.SelectedItem.ToString()),
                new ("@CapacidadMaxima", cbCapacidad.SelectedItem.ToString())
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
            consulta = $"DELETE FROM [dbo].[Aula]\r\n      " +
                $"WHERE IDAula = {txtEliminar.Text}";

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
            if (string.IsNullOrEmpty(txtEdificio.Text) ||
                string.IsNullOrEmpty(txtAula.Text) ||
                cbCapacidad.SelectedItem == null ||
                cbPiso.SelectedItem == null)
            {
                MessageBox.Show("Porfavor, no deje espacios vacios");
                return;
            }


            DataGridViewRow r = DGVDatos.SelectedRows[0];


            if (DGVDatos.SelectedRows != null && DGVDatos.SelectedRows.Count > 0)
            {
                

                consulta = "UPDATE [dbo].[Aula]\r\n   " +
                    "SET [Edificio] = @Edificio\r\n      " +
                    ",[Aula] = @Aula\r\n      " +
                    ",[Piso] = @Piso\r\n      " +
                    ",[CapacidadMaxima] = @CapacidadMaxima\r\n      " +
                    ",[FechaHoraCreacion] = @FechaCreacion\r\n " +
                    "WHERE IDAula = @ID";

                var parametros = new List<SqlParameter>
                {
                    new ("@Edificio", txtEdificio.Text.Trim()),
                    new ("@Aula", txtAula.Text.Trim()),
                    new ("@Piso", cbPiso.SelectedItem.ToString()),
                    new ("@CapacidadMaxima", cbCapacidad.SelectedItem.ToString()),
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

                txtEdificio.Text =
                        r.Cells["Nombre"].Value.ToString();

                txtAula.Text =
                        r.Cells["Aula"].Value.ToString();

                cbPiso.SelectedItem =
                        r.Cells["Piso"].Value.ToString();

                cbCapacidad.SelectedItem =
                        r.Cells["Capacidad"].Value.ToString();
            }
        }
    }
}
