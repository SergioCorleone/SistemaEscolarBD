namespace SistemaEscolarBD
{
    partial class GruposE
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
            btnSalir = new Button();
            btnAgregar = new Button();
            cbAlumno = new ComboBox();
            cbMaestro = new ComboBox();
            cbAula = new ComboBox();
            cbCarrera = new ComboBox();
            tbHorario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(325, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(165, 362);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbAlumno
            // 
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(234, 81);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(151, 28);
            cbAlumno.TabIndex = 22;
            // 
            // cbMaestro
            // 
            cbMaestro.FormattingEnabled = true;
            cbMaestro.Location = new Point(234, 130);
            cbMaestro.Name = "cbMaestro";
            cbMaestro.Size = new Size(151, 28);
            cbMaestro.TabIndex = 21;
            // 
            // cbAula
            // 
            cbAula.FormattingEnabled = true;
            cbAula.Location = new Point(234, 181);
            cbAula.Name = "cbAula";
            cbAula.Size = new Size(151, 28);
            cbAula.TabIndex = 20;
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(234, 228);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(151, 28);
            cbCarrera.TabIndex = 19;
            // 
            // tbHorario
            // 
            tbHorario.Location = new Point(234, 276);
            tbHorario.Name = "tbHorario";
            tbHorario.Size = new Size(151, 27);
            tbHorario.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 276);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 17;
            label6.Text = "Horario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 228);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 16;
            label5.Text = "Carrera:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 184);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 15;
            label4.Text = "Aula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 130);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 14;
            label3.Text = "Maestro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 13;
            label2.Text = "Alumno: ";
            // 
            // GruposE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 473);
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
            Name = "GruposE";
            Text = "GruposE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregar;
        private ComboBox cbAlumno;
        private ComboBox cbMaestro;
        private ComboBox cbAula;
        private ComboBox cbCarrera;
        private TextBox tbHorario;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}