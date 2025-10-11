namespace SistemaEscolarBD
{
    partial class Academico
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
            label = new Label();
            Grado = new ComboBox();
            tbApellidos = new TextBox();
            tbNombre = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            btnAgregar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 63);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 138);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(142, 218);
            label.Name = "label";
            label.Size = new Size(53, 20);
            label.TabIndex = 2;
            label.Text = "Grado:";
            // 
            // Grado
            // 
            Grado.FormattingEnabled = true;
            Grado.Items.AddRange(new object[] { "1ro", "2do", "3ro", "4to", "5to", "6to", "7mo", "8vo" });
            Grado.Location = new Point(203, 215);
            Grado.Name = "Grado";
            Grado.Size = new Size(151, 28);
            Grado.TabIndex = 3;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(203, 138);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(151, 27);
            tbApellidos.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(203, 63);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(151, 27);
            tbNombre.TabIndex = 5;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 289);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(125, 360);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(293, 360);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Academico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbNombre);
            Controls.Add(tbApellidos);
            Controls.Add(Grado);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Academico";
            Text = "Academico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label;
        private ComboBox Grado;
        private TextBox tbApellidos;
        private TextBox tbNombre;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button btnAgregar;
        private Button btnSalir;
    }
}