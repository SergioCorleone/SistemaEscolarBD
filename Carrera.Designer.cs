namespace SistemaEscolarBD
{
    partial class Carrera
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
            label2 = new Label();
            label1 = new Label();
            tbNombreCarrera = new TextBox();
            tbSiglasCarrera = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(300, 360);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(132, 360);
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
            label4.Location = new Point(160, 251);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 29;
            label4.Text = "Fecha:";
            
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(216, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 28;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 173);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 25;
            label2.Text = "Siglas carrera:";
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 103);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 24;
            label1.Text = "Nombre carrera:";
            label1.Click += label1_Click;
            // 
            // tbNombreCarrera
            // 
            tbNombreCarrera.Location = new Point(216, 103);
            tbNombreCarrera.Name = "tbNombreCarrera";
            tbNombreCarrera.Size = new Size(151, 27);
            tbNombreCarrera.TabIndex = 32;
            
            // 
            // tbSiglasCarrera
            // 
            tbSiglasCarrera.Location = new Point(216, 170);
            tbSiglasCarrera.Name = "tbSiglasCarrera";
            tbSiglasCarrera.Size = new Size(151, 27);
            tbSiglasCarrera.TabIndex = 33;
            
            // 
            // Carrera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(tbSiglasCarrera);
            Controls.Add(tbNombreCarrera);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Carrera";
            Text = "Carrera";
            Load += Carrera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private TextBox tbNombreCarrera;
        private TextBox tbSiglasCarrera;
    }
}