namespace SistemaEscolarBD
{
    partial class AulaE
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
            cbEdificio = new ComboBox();
            cbAula = new ComboBox();
            tbCapacidad = new TextBox();
            label3 = new Label();
            btnSalir = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbPiso = new ComboBox();
            label = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbEdificio
            // 
            cbEdificio.FormattingEnabled = true;
            cbEdificio.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbEdificio.Location = new Point(231, 51);
            cbEdificio.Name = "cbEdificio";
            cbEdificio.Size = new Size(151, 28);
            cbEdificio.TabIndex = 35;
            // 
            // cbAula
            // 
            cbAula.FormattingEnabled = true;
            cbAula.Items.AddRange(new object[] { "01", "02", "03", "04", "05" });
            cbAula.Location = new Point(231, 116);
            cbAula.Name = "cbAula";
            cbAula.Size = new Size(151, 28);
            cbAula.TabIndex = 34;
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(231, 240);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(151, 27);
            tbCapacidad.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 240);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 32;
            label3.Text = "Capacidad Maxima:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(321, 352);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(153, 352);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 291);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 29;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // cbPiso
            // 
            cbPiso.FormattingEnabled = true;
            cbPiso.Items.AddRange(new object[] { "01", "02", "03" });
            cbPiso.Location = new Point(231, 180);
            cbPiso.Name = "cbPiso";
            cbPiso.Size = new Size(151, 28);
            cbPiso.TabIndex = 27;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(186, 183);
            label.Name = "label";
            label.Size = new Size(39, 20);
            label.TabIndex = 26;
            label.Text = "Piso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 25;
            label2.Text = "Aula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 54);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 24;
            label1.Text = "Edificio:";
            // 
            // AulaE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 483);
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
            Name = "AulaE";
            Text = "AulaE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEdificio;
        private ComboBox cbAula;
        private TextBox tbCapacidad;
        private Label label3;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPiso;
        private Label label;
        private Label label2;
        private Label label1;
    }
}