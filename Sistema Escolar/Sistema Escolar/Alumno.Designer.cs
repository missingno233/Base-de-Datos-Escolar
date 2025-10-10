namespace Sistema_Escolar
{
    partial class Alumno
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
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            txtEliminar = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            RBEstatus = new RadioButton();
            radioButton1 = new RadioButton();
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
            // txtApellidos
            // 
            txtApellidos.Location = new Point(24, 348);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(136, 23);
            txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 319);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(197, 319);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(100, 23);
            txtEliminar.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 323);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(313, 319);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "¡Eliminalo!";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // RBEstatus
            // 
            RBEstatus.AutoSize = true;
            RBEstatus.Location = new Point(181, 353);
            RBEstatus.Name = "RBEstatus";
            RBEstatus.Size = new Size(59, 19);
            RBEstatus.TabIndex = 17;
            RBEstatus.TabStop = true;
            RBEstatus.Text = "Activo";
            RBEstatus.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(246, 353);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Inactivo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Alumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 378);
            Controls.Add(radioButton1);
            Controls.Add(RBEstatus);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtEliminar);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(toolStrip1);
            Controls.Add(DGVDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Alumno";
            Text = "Alumno";
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
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtEliminar;
        private Label label2;
        private Button btnEliminar;
        private RadioButton RBEstatus;
        private RadioButton radioButton1;
    }
}