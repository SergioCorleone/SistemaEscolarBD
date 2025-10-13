namespace SistemaEscolarBD
{
    partial class Reinscripcion
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbCalificacion = new TextBox();
            cbGrupo = new ComboBox();
            cbAlumno = new ComboBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 79);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Grupo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Alumno:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 196);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Calificacion:";
      
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 264);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
         
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
 
            // 
            // tbCalificacion
            // 
            tbCalificacion.Location = new Point(205, 196);
            tbCalificacion.Name = "tbCalificacion";
            tbCalificacion.Size = new Size(151, 27);
            tbCalificacion.TabIndex = 5;
        
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(205, 76);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(151, 28);
            cbGrupo.TabIndex = 6;

            // 
            // cbAlumno
            // 
            cbAlumno.FormattingEnabled = true;
            cbAlumno.Location = new Point(205, 135);
            cbAlumno.Name = "cbAlumno";
            cbAlumno.Size = new Size(151, 28);
            cbAlumno.TabIndex = 7;
       
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(144, 353);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(304, 353);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Reinscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 460);
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
            Name = "Reinscripcion";
            Text = "Reinscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox tbCalificacion;
        private ComboBox cbGrupo;
        private ComboBox cbAlumno;
        private Button btnAgregar;
        private Button btnSalir;
    }
}