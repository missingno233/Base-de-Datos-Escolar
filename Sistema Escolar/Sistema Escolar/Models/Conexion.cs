using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escolar.Models
{
    public class Conexion
    {
        private readonly string conexion = "Server = HP\\MISCOSAS; " +
                "Database = Base Escolar; " +
                "Integrated Security = True;" +
                "TrustServerCertificate = True;";
        private String Consulta { get; set; } = "";

        public Conexion(string conexion)
        {
            this.conexion = conexion;
        }
        
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(this.conexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al conectar. {ex.Message}");
                return false;
            }
        }


        public void ObtenerDatos(String consulta)
        {
            try
            {
                DataTable tabllita = new DataTable();


                using (SqlCommand comandito = new SqlCommand(consulta, this.conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta))
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error. {ex.Message}");
            }
        }



    }
}
