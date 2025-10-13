namespace SistemaEscolarBD
{
    partial class Grupo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbHorario = new TextBox();
            cbCarrera = new ComboBox();
            cbAula = new ComboBox();
            cbMaestro = new ComboBox();
            cbAlumno = new ComboBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Alumno: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 135);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Maestro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 189);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Aula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 233);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Carrera:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 281);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Horario:";
            // 
            // tbHorario
            // 
            tbHorario.Location = new Point(176, 281);
            tbHorario.Name = "tbHorario";
            tbHorario.Size = new Size(151, 27);
            tbHorario.TabIndex = 6;
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(176, 233);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(151, 28);
            cbCarrera.TabIndex = 7;
            // 
            // cbAula
            // 
            cbAula.FormattingEnabled = true;
            cbAula.Location = new Point(176, 186);
            cbAula.Name = "cbAula";
            cbAula.Size = new Size(151, 28);
            cbAula.TabIndex = 8;
            // 
            // cbMaestro
            // 
            cbMaestro.FormattingEnabled = true;
            cbMaestro.Location = new Point(176, 135);
            cbMaestro.Name = "cbMaestro";
            cbMaestro.Size = new Size(151, 28);
            cbMaestro.TabIndex = 9;
            // 
            // cbAlumno
            // 
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(176, 86);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(151, 28);
            cbAlumno.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(107, 367);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(267, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Grupo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(cbAlumno);
            Controls.Add(cbMaestro);
            Controls.Add(cbAula);
            Controls.Add(cbCarrera);
            Controls.Add(tbHorario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Grupo";
            Text = "Grupo";
            Load += Grupo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbHorario;
        private ComboBox cbCarrera;
        private ComboBox cbAula;
        private ComboBox cbMaestro;
        private ComboBox cbAlumno;
        private Button btnAgregar;
        private Button btnSalir;
    }
}