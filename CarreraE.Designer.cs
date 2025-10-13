namespace SistemaEscolarBD
{
    partial class CarreraE
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
            tbSiglasCarrera = new TextBox();
            tbNombreCarrera = new TextBox();
            btnSalir = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbSiglasCarrera
            // 
            tbSiglasCarrera.Location = new Point(217, 166);
            tbSiglasCarrera.Name = "tbSiglasCarrera";
            tbSiglasCarrera.Size = new Size(151, 27);
            tbSiglasCarrera.TabIndex = 41;
            // 
            // tbNombreCarrera
            // 
            tbNombreCarrera.Location = new Point(217, 99);
            tbNombreCarrera.Name = "tbNombreCarrera";
            tbNombreCarrera.Size = new Size(151, 27);
            tbNombreCarrera.TabIndex = 40;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(301, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(133, 356);
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
            label4.Location = new Point(161, 247);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 37;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(217, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 169);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 35;
            label2.Text = "Siglas carrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 99);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 34;
            label1.Text = "Nombre carrera:";
            // 
            // CarreraE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 485);
            Controls.Add(tbSiglasCarrera);
            Controls.Add(tbNombreCarrera);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarreraE";
            Text = "CarreraE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSiglasCarrera;
        private TextBox tbNombreCarrera;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}