namespace Sistema_Escolar
{
    partial class VentanaPrincipal
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
            BtnMateria = new Button();
            label1 = new Label();
            BtnAula = new Button();
            BtnAcademico = new Button();
            BtnAlumno = new Button();
            BtnCarrera = new Button();
            BtnCiudad = new Button();
            BtnEstado = new Button();
            BtnPais = new Button();
            BtnEstatus = new Button();
            SuspendLayout();
            // 
            // BtnMateria
            // 
            BtnMateria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMateria.Location = new Point(325, 267);
            BtnMateria.Name = "BtnMateria";
            BtnMateria.Size = new Size(124, 60);
            BtnMateria.TabIndex = 1;
            BtnMateria.Text = "Materia";
            BtnMateria.UseVisualStyleBackColor = true;
            BtnMateria.Click += BtnMateria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(396, 25);
            label1.TabIndex = 2;
            label1.Text = "Porfavor Seleccione la ventan que desea abrir";
            // 
            // BtnAula
            // 
            BtnAula.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAula.Location = new Point(181, 102);
            BtnAula.Name = "BtnAula";
            BtnAula.Size = new Size(124, 60);
            BtnAula.TabIndex = 3;
            BtnAula.Text = "Aula";
            BtnAula.UseVisualStyleBackColor = true;
            BtnAula.Click += BtnAula_Click;
            // 
            // BtnAcademico
            // 
            BtnAcademico.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAcademico.Location = new Point(325, 103);
            BtnAcademico.Name = "BtnAcademico";
            BtnAcademico.Size = new Size(124, 60);
            BtnAcademico.TabIndex = 4;
            BtnAcademico.Text = "Academico";
            BtnAcademico.UseVisualStyleBackColor = true;
            BtnAcademico.Click += BtnAcademico_Click;
            // 
            // BtnAlumno
            // 
            BtnAlumno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAlumno.Location = new Point(32, 103);
            BtnAlumno.Name = "BtnAlumno";
            BtnAlumno.Size = new Size(124, 60);
            BtnAlumno.TabIndex = 5;
            BtnAlumno.Text = "Alumno";
            BtnAlumno.UseVisualStyleBackColor = true;
            BtnAlumno.Click += BtnAlumno_Click;
            // 
            // BtnCarrera
            // 
            BtnCarrera.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCarrera.Location = new Point(32, 185);
            BtnCarrera.Name = "BtnCarrera";
            BtnCarrera.Size = new Size(124, 60);
            BtnCarrera.TabIndex = 6;
            BtnCarrera.Text = "Carrera";
            BtnCarrera.UseVisualStyleBackColor = true;
            BtnCarrera.Click += BtnCarrera_Click;
            // 
            // BtnCiudad
            // 
            BtnCiudad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCiudad.Location = new Point(181, 185);
            BtnCiudad.Name = "BtnCiudad";
            BtnCiudad.Size = new Size(124, 60);
            BtnCiudad.TabIndex = 7;
            BtnCiudad.Text = "Ciudad";
            BtnCiudad.UseVisualStyleBackColor = true;
            BtnCiudad.Click += BtnCiudad_Click;
            // 
            // BtnEstado
            // 
            BtnEstado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstado.Location = new Point(325, 185);
            BtnEstado.Name = "BtnEstado";
            BtnEstado.Size = new Size(124, 60);
            BtnEstado.TabIndex = 8;
            BtnEstado.Text = "Estado";
            BtnEstado.UseVisualStyleBackColor = true;
            BtnEstado.Click += BtnEstado_Click;
            // 
            // BtnPais
            // 
            BtnPais.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPais.Location = new Point(181, 267);
            BtnPais.Name = "BtnPais";
            BtnPais.Size = new Size(124, 60);
            BtnPais.TabIndex = 9;
            BtnPais.Text = "Pais";
            BtnPais.UseVisualStyleBackColor = true;
            BtnPais.Click += BtnPais_Click;
            // 
            // BtnEstatus
            // 
            BtnEstatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstatus.Location = new Point(32, 267);
            BtnEstatus.Name = "BtnEstatus";
            BtnEstatus.Size = new Size(124, 60);
            BtnEstatus.TabIndex = 10;
            BtnEstatus.Text = "Estatus";
            BtnEstatus.UseVisualStyleBackColor = true;
            BtnEstatus.Click += BtnEstatus_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(491, 359);
            Controls.Add(BtnEstatus);
            Controls.Add(BtnPais);
            Controls.Add(BtnEstado);
            Controls.Add(BtnCiudad);
            Controls.Add(BtnCarrera);
            Controls.Add(BtnAlumno);
            Controls.Add(BtnAcademico);
            Controls.Add(BtnAula);
            Controls.Add(label1);
            Controls.Add(BtnMateria);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VentanaPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnMateria;
        private Label label1;
        private Button BtnAula;
        private Button BtnAcademico;
        private Button BtnAlumno;
        private Button BtnCarrera;
        private Button BtnCiudad;
        private Button BtnEstado;
        private Button BtnPais;
        private Button BtnEstatus;
    }
}
