namespace Sistema_Escolar
{
    partial class Academico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGVDatos = new DataGridView();
            toolStrip1 = new ToolStrip();
            TSBObtenerDatos = new ToolStripButton();
            TSBEliminar = new ToolStripButton();
            TSBInsertar = new ToolStripButton();
            TSBEditar = new ToolStripButton();
            cbPiso = new ComboBox();
            txtAula = new TextBox();
            txtEdificio = new TextBox();
            cbCapacidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGVDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVDatos
            // 
            DGVDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDatos.Location = new Point(13, 28);
            DGVDatos.MultiSelect = false;
            DGVDatos.Name = "DGVDatos";
            DGVDatos.Size = new Size(490, 274);
            DGVDatos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBObtenerDatos, TSBEliminar, TSBInsertar, TSBEditar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(515, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSBObtenerDatos
            // 
            TSBObtenerDatos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBObtenerDatos.ImageTransparentColor = Color.Magenta;
            TSBObtenerDatos.Name = "TSBObtenerDatos";
            TSBObtenerDatos.Size = new Size(87, 22);
            TSBObtenerDatos.Text = "Obtener Datos";
            TSBObtenerDatos.Click += TSBObtenerDatos_Click;
            // 
            // TSBEliminar
            // 
            TSBEliminar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBEliminar.ImageTransparentColor = Color.Magenta;
            TSBEliminar.Name = "TSBEliminar";
            TSBEliminar.Size = new Size(54, 22);
            TSBEliminar.Text = "Eliminar";
            // 
            // TSBInsertar
            // 
            TSBInsertar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBInsertar.ImageTransparentColor = Color.Magenta;
            TSBInsertar.Name = "TSBInsertar";
            TSBInsertar.Size = new Size(50, 22);
            TSBInsertar.Text = "Insertar";
            // 
            // TSBEditar
            // 
            TSBEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBEditar.ImageTransparentColor = Color.Magenta;
            TSBEditar.Name = "TSBEditar";
            TSBEditar.Size = new Size(41, 22);
            TSBEditar.Text = "Editar";
            // 
            // cbPiso
            // 
            cbPiso.FormattingEnabled = true;
            cbPiso.Items.AddRange(new object[] { "1er piso", "2do piso", "3er piso" });
            cbPiso.Location = new Point(175, 348);
            cbPiso.Name = "cbPiso";
            cbPiso.Size = new Size(94, 23);
            cbPiso.TabIndex = 11;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(24, 348);
            txtAula.Name = "txtAula";
            txtAula.PlaceholderText = "Aula";
            txtAula.Size = new Size(136, 23);
            txtAula.TabIndex = 10;
            // 
            // txtEdificio
            // 
            txtEdificio.Location = new Point(24, 319);
            txtEdificio.Name = "txtEdificio";
            txtEdificio.PlaceholderText = "Edificio";
            txtEdificio.Size = new Size(136, 23);
            txtEdificio.TabIndex = 9;
            // 
            // cbCapacidad
            // 
            cbCapacidad.FormattingEnabled = true;
            cbCapacidad.Items.AddRange(new object[] { "30 alumnos", "40 alumnos", "50 alumnos" });
            cbCapacidad.Location = new Point(175, 319);
            cbCapacidad.Name = "cbCapacidad";
            cbCapacidad.Size = new Size(94, 23);
            cbCapacidad.TabIndex = 12;
            // 
            // Academico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 378);
            Controls.Add(cbCapacidad);
            Controls.Add(cbPiso);
            Controls.Add(txtAula);
            Controls.Add(txtEdificio);
            Controls.Add(toolStrip1);
            Controls.Add(DGVDatos);
            Name = "Academico";
            Text = "Academico";
            ((System.ComponentModel.ISupportInitialize)DGVDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVDatos;
        private ToolStrip toolStrip1;
        private ToolStripButton TSBObtenerDatos;
        private ToolStripButton TSBEliminar;
        private ToolStripButton TSBInsertar;
        private ToolStripButton TSBEditar;
        private ComboBox cbPiso;
        private TextBox txtAula;
        private TextBox txtEdificio;
        private ComboBox cbCapacidad;
    }
}