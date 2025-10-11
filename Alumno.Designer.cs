namespace SistemaEscolarBD
{
    partial class Alumno
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
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            cbEstatus = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(280, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(112, 359);
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
            label4.Location = new Point(134, 288);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 17;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 283);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(190, 62);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(151, 27);
            tbNombre.TabIndex = 15;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(190, 137);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(151, 27);
            tbApellidos.TabIndex = 14;
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Regular", "Irregular", "Inactivo" });
            cbEstatus.Location = new Point(190, 214);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(151, 28);
            cbEstatus.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 217);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 12;
            label3.Text = "Estatus:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // Alumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbNombre);
            Controls.Add(tbApellidos);
            Controls.Add(cbEstatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Alumno";
            Text = "Alumno";
            Load += Alumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private ComboBox cbEstatus;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}