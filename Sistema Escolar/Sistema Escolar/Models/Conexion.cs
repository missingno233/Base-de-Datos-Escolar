using Microsoft.Data.SqlClient;
using System.Data;

namespace Sistema_Escolar.Models
{
    public class Conexion
    {
        private readonly string conexion = "Server=PCERDA\\SQLEXPRESS;"
                            + " Database=Base Escolar;"
                            + " Integrated Security=True; "
                            + " TrustServerCertificate=True";

        private readonly string Conectado = "C:\\Users\\gaelg\\source" +
           "\\repos\\Sistema Escolar\\Sistema Escolar\\base-de-datos" +
           "\\Sistema Escolar\\Sistema Escolar\\Models\\Iconos\\Conectado.ico";

        private readonly string Desconectado = "C:\\Users\\gaelg\\source" +
            "\\repos\\Sistema Escolar\\Sistema Escolar\\base-de-datos" +
            "\\Sistema Escolar\\Sistema Escolar\\Models\\Iconos\\Desconectado.ico";



        private String Consulta { get; set; } = "";


        public Conexion() { }



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


        public DataTable ObtenerDatos(String consulta)
        {
            DataTable tablita = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(this.conexion))
                {
                    conexion.Open();


                    using (SqlCommand comandito = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandito))
                        {
                            adaptador.Fill(tablita);
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error. {ex.Message}");
            }
            return tablita;
        }

        

    }
}
