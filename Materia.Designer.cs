namespace SistemaEscolarBD
{
    partial class Materia
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
            tbCreditos = new TextBox();
            tbNombreMateria = new TextBox();
            btnSalir = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbCreditos
            // 
            tbCreditos.Location = new Point(224, 150);
            tbCreditos.Name = "tbCreditos";
            tbCreditos.Size = new Size(151, 27);
            tbCreditos.TabIndex = 41;
            // 
            // tbNombreMateria
            // 
            tbNombreMateria.Location = new Point(224, 83);
            tbNombreMateria.Name = "tbNombreMateria";
            tbNombreMateria.Size = new Size(151, 27);
            tbNombreMateria.TabIndex = 40;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(308, 340);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(140, 340);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 231);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 37;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(224, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 157);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 35;
            label2.Text = "Creditos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 83);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 34;
            label1.Text = "Nombre materia:";
            // 
            // Materia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(tbCreditos);
            Controls.Add(tbNombreMateria);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Materia";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCreditos;
        private TextBox tbNombreMateria;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}