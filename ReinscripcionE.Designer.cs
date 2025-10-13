namespace SistemaEscolarBD
{
    partial class ReinscripcionE
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
            cbGrupo = new ComboBox();
            tbCalificacion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(306, 369);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(146, 369);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbAlumno
            // 
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(207, 151);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(151, 28);
            cbAlumno.TabIndex = 17;
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(207, 92);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(151, 28);
            cbGrupo.TabIndex = 16;
            // 
            // tbCalificacion
            // 
            tbCalificacion.Location = new Point(207, 212);
            tbCalificacion.Name = "tbCalificacion";
            tbCalificacion.Size = new Size(151, 27);
            tbCalificacion.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 280);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 13;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 212);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 12;
            label3.Text = "Calificacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Alumno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 95);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 10;
            label1.Text = "Grupo:";
            // 
            // ReinscripcionE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 491);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(cbAlumno);
            Controls.Add(cbGrupo);
            Controls.Add(tbCalificacion);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReinscripcionE";
            Text = "ReinscripcionE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregar;
        private ComboBox cbAlumno;
        private ComboBox cbGrupo;
        private TextBox tbCalificacion;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}