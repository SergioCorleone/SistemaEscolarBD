namespace SistemaEscolarBD
{
    partial class Aula
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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbPiso = new ComboBox();
            label = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tbCapacidad = new TextBox();
            cbAula = new ComboBox();
            cbEdificio = new ComboBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(302, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(134, 374);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 313);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 17;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // cbPiso
            // 
            cbPiso.FormattingEnabled = true;
            cbPiso.Items.AddRange(new object[] { "01", "02", "03" });
            cbPiso.Location = new Point(212, 202);
            cbPiso.Name = "cbPiso";
            cbPiso.Size = new Size(151, 28);
            cbPiso.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(167, 205);
            label.Name = "label";
            label.Size = new Size(39, 20);
            label.TabIndex = 12;
            label.Text = "Piso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 141);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 11;
            label2.Text = "Aula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 76);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 10;
            label1.Text = "Edificio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 262);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 20;
            label3.Text = "Capacidad Maxima:";
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(212, 262);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(151, 27);
            tbCapacidad.TabIndex = 21;
            // 
            // cbAula
            // 
            cbAula.FormattingEnabled = true;
            cbAula.Items.AddRange(new object[] { "01", "02", "03", "04", "05" });
            cbAula.Location = new Point(212, 138);
            cbAula.Name = "cbAula";
            cbAula.Size = new Size(151, 28);
            cbAula.TabIndex = 22;
            // 
            // cbEdificio
            // 
            cbEdificio.FormattingEnabled = true;
            cbEdificio.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbEdificio.Location = new Point(212, 73);
            cbEdificio.Name = "cbEdificio";
            cbEdificio.Size = new Size(151, 28);
            cbEdificio.TabIndex = 23;
            // 
            // Aula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 481);
            Controls.Add(cbEdificio);
            Controls.Add(cbAula);
            Controls.Add(tbCapacidad);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbPiso);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Aula";
            Text = "Aula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPiso;
        private Label label;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tbCapacidad;
        private ComboBox cbAula;
        private ComboBox cbEdificio;
    }
}