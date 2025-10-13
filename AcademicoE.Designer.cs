namespace SistemaEscolarBD
{
    partial class AcademicoE
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
            tbNombreEditar = new TextBox();
            tbApellidosEditar = new TextBox();
            GradoEditar = new ComboBox();
            label = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(292, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(124, 359);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Editar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 288);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 17;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 283);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // tbNombreEditar
            // 
            tbNombreEditar.Location = new Point(202, 62);
            tbNombreEditar.Name = "tbNombreEditar";
            tbNombreEditar.Size = new Size(151, 27);
            tbNombreEditar.TabIndex = 15;
            // 
            // tbApellidosEditar
            // 
            tbApellidosEditar.Location = new Point(202, 137);
            tbApellidosEditar.Name = "tbApellidosEditar";
            tbApellidosEditar.Size = new Size(151, 27);
            tbApellidosEditar.TabIndex = 14;
            // 
            // GradoEditar
            // 
            GradoEditar.FormattingEnabled = true;
            GradoEditar.Items.AddRange(new object[] { "1ro", "2do", "3ro", "4to", "5to", "6to", "7mo", "8vo" });
            GradoEditar.Location = new Point(202, 214);
            GradoEditar.Name = "GradoEditar";
            GradoEditar.Size = new Size(151, 28);
            GradoEditar.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(141, 217);
            label.Name = "label";
            label.Size = new Size(53, 20);
            label.TabIndex = 12;
            label.Text = "Grado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // AcademicoE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbNombreEditar);
            Controls.Add(tbApellidosEditar);
            Controls.Add(GradoEditar);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AcademicoE";
            Text = "Academico Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox tbNombreEditar;
        private TextBox tbApellidosEditar;
        private ComboBox GradoEditar;
        private Label label;
        private Label label2;
        private Label label1;
    }
}