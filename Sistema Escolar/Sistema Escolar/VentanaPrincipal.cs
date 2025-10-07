namespace Sistema_Escolar
{
    public partial class VentanaPrincipal : Form
    {
        //variable auxiliar para metodo abrirVentanas
        public String ventana { get; set; } = "";

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAlumno_Click(object sender, EventArgs e)
        {
            //le damos valor a la variable para abrir la ventana deseada
            ventana = "alumno";
            //llamamos al metodo con la ventana deseada
            abreVentanas(ventana);
        }

        private void BtnAcademico_Click(object sender, EventArgs e)
        {
            ventana = "academico";

            abreVentanas(ventana);
        }

        private void BtnAula_Click(object sender, EventArgs e)
        {
            ventana = "aula";

            abreVentanas(ventana);
        }

        private void BtnCarrera_Click(object sender, EventArgs e)
        {
            ventana = "carrera";

            abreVentanas(ventana);
        }

        private void BtnCiudad_Click(object sender, EventArgs e)
        {
            ventana = "ciudad";

            abreVentanas(ventana);
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            ventana = "estado";

            abreVentanas(ventana);
        }

        private void BtnEstatus_Click(object sender, EventArgs e)
        {
            ventana = "estatus";

            abreVentanas(ventana);
        }

        private void BtnPais_Click(object sender, EventArgs e)
        {
            ventana = "pais";

            abreVentanas(ventana);
        }

        private void BtnMateria_Click(object sender, EventArgs e)
        {
            ventana = "materia";

            abreVentanas(ventana);
        }



        public void abreVentanas(string ventana)
        {
            //controla la ventana seleccionada
            switch (ventana)
            {
                default:
                    break;

                case "alumno":
                    {
                        Alumno ventanaNueva = new Alumno();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "aula":
                    {
                        Aula ventanaNueva = new Aula();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "carrera":
                    {
                        Carrera ventanaNueva = new Carrera();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "ciudad":
                    {
                        Ciudad ventanaNueva = new Ciudad();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "estado":
                    {
                        Estado ventanaNueva = new Estado();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "estatus":
                    {
                        Estatus ventanaNueva = new Estatus();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "materia":
                    {
                        Materia ventanaNueva = new Materia();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "pais":
                    {
                        Pais ventanaNueva = new Pais();
                        ventanaNueva.ShowDialog();
                        break;
                    }
                case "academico":
                    {
                        Academico ventanaNueva = new Academico();
                        ventanaNueva.ShowDialog();
                        break;
                    }

            }


         
        }


    }
}
