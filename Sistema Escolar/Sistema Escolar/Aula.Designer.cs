namespace Sistema_Escolar
{
    partial class Aula
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
            txtAula = new TextBox();
            txtEdificio = new TextBox();
            txtEliminar = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            cbPiso = new ComboBox();
            cbCapacidad = new ComboBox();
            label1 = new Label();
            label3 = new Label();
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
            DGVDatos.SelectionChanged += DGVDatos_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBObtenerDatos, TSBEliminar, TSBInsertar, TSBEditar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(515, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSBObtenerDatos
            // 
            TSBObtenerDatos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBObtenerDatos.ImageTransparentColor = Color.Magenta;
            TSBObtenerDatos.Name = "TSBObtenerDatos";
            TSBObtenerDatos.Size = new Size(110, 24);
            TSBObtenerDatos.Text = "Obtener Datos";
            TSBObtenerDatos.Click += TSBObtenerDatos_Click;
            // 
            // TSBEliminar
            // 
            TSBEliminar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBEliminar.ImageTransparentColor = Color.Magenta;
            TSBEliminar.Name = "TSBEliminar";
            TSBEliminar.Size = new Size(67, 24);
            TSBEliminar.Text = "Eliminar";
            TSBEliminar.Click += TSBEliminar_Click;
            // 
            // TSBInsertar
            // 
            TSBInsertar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBInsertar.ImageTransparentColor = Color.Magenta;
            TSBInsertar.Name = "TSBInsertar";
            TSBInsertar.Size = new Size(62, 24);
            TSBInsertar.Text = "Insertar";
            TSBInsertar.Click += TSBInsertar_Click;
            // 
            // TSBEditar
            // 
            TSBEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBEditar.ImageTransparentColor = Color.Magenta;
            TSBEditar.Name = "TSBEditar";
            TSBEditar.Size = new Size(52, 24);
            TSBEditar.Text = "Editar";
            TSBEditar.Click += TSBEditar_Click;
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
            // txtEliminar
            // 
            txtEliminar.Location = new Point(403, 319);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(100, 23);
            txtEliminar.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 323);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(428, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "¡Eliminalo!";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbPiso
            // 
            cbPiso.FormattingEnabled = true;
            cbPiso.Items.AddRange(new object[] { "1ro", "2do", "3ro" });
            cbPiso.Location = new Point(239, 320);
            cbPiso.Name = "cbPiso";
            cbPiso.Size = new Size(48, 23);
            cbPiso.TabIndex = 19;
            // 
            // cbCapacidad
            // 
            cbCapacidad.FormattingEnabled = true;
            cbCapacidad.Items.AddRange(new object[] { "15", "20", "25", "30", "35", "40" });
            cbCapacidad.Location = new Point(239, 349);
            cbCapacidad.Name = "cbCapacidad";
            cbCapacidad.Size = new Size(48, 23);
            cbCapacidad.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 323);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 21;
            label1.Text = "Piso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 351);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 22;
            label3.Text = "Capacidad";
            // 
            // Aula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 378);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbCapacidad);
            Controls.Add(cbPiso);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtEliminar);
            Controls.Add(txtAula);
            Controls.Add(txtEdificio);
            Controls.Add(toolStrip1);
            Controls.Add(DGVDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Aula";
            Text = "Aula";
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
        private TextBox txtAula;
        private TextBox txtEdificio;
        private TextBox txtEliminar;
        private Label label2;
        private Button btnEliminar;
        private ComboBox cbPiso;
        private ComboBox cbCapacidad;
        private Label label1;
        private Label label3;
    }
}