namespace SistemaEscolarBD
{
    partial class VetanaCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAcademico = new Button();
            btnAlumnos = new Button();
            btnAula = new Button();
            btnCarrera = new Button();
            btnCiudad = new Button();
            btnEstado = new Button();
            btnMateria = new Button();
            btnReinscripcion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 102);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccione que catalogo desea obtener:";
            // 
            // btnAcademico
            // 
            btnAcademico.Location = new Point(100, 141);
            btnAcademico.Name = "btnAcademico";
            btnAcademico.Size = new Size(105, 29);
            btnAcademico.TabIndex = 1;
            btnAcademico.Text = "Academico";
            btnAcademico.UseVisualStyleBackColor = true;
            btnAcademico.Click += button1_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(265, 141);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(109, 29);
            btnAlumnos.TabIndex = 2;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnAula
            // 
            btnAula.Location = new Point(100, 195);
            btnAula.Name = "btnAula";
            btnAula.Size = new Size(105, 29);
            btnAula.TabIndex = 3;
            btnAula.Text = "Aula";
            btnAula.UseVisualStyleBackColor = true;
            // 
            // btnCarrera
            // 
            btnCarrera.Location = new Point(265, 195);
            btnCarrera.Name = "btnCarrera";
            btnCarrera.Size = new Size(109, 29);
            btnCarrera.TabIndex = 4;
            btnCarrera.Text = "Carrera";
            btnCarrera.UseVisualStyleBackColor = true;
            // 
            // btnCiudad
            // 
            btnCiudad.Location = new Point(100, 253);
            btnCiudad.Name = "btnCiudad";
            btnCiudad.Size = new Size(105, 29);
            btnCiudad.TabIndex = 5;
            btnCiudad.Text = "Ciudad";
            btnCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(265, 253);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(109, 29);
            btnEstado.TabIndex = 6;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnMateria
            // 
            btnMateria.Location = new Point(100, 312);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new Size(105, 29);
            btnMateria.TabIndex = 7;
            btnMateria.Text = "Materia";
            btnMateria.UseVisualStyleBackColor = true;
            // 
            // btnReinscripcion
            // 
            btnReinscripcion.Location = new Point(265, 312);
            btnReinscripcion.Name = "btnReinscripcion";
            btnReinscripcion.Size = new Size(109, 29);
            btnReinscripcion.TabIndex = 8;
            btnReinscripcion.Text = "Reinscripcion";
            btnReinscripcion.UseVisualStyleBackColor = true;
            // 
            // VetanaCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 437);
            Controls.Add(btnReinscripcion);
            Controls.Add(btnMateria);
            Controls.Add(btnEstado);
            Controls.Add(btnCiudad);
            Controls.Add(btnCarrera);
            Controls.Add(btnAula);
            Controls.Add(btnAlumnos);
            Controls.Add(btnAcademico);
            Controls.Add(label1);
            Name = "VetanaCatalogo";
            Text = "Obtener Catalogo";
            Load += VetanaCatalogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAcademico;
        private Button btnAlumnos;
        private Button btnAula;
        private Button btnCarrera;
        private Button btnCiudad;
        private Button btnEstado;
        private Button btnMateria;
        private Button btnReinscripcion;
    }
}