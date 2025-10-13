namespace SistemaEscolarBD
{
    partial class EstadosE
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
            label3 = new Label();
            cbIdPais = new ComboBox();
            tbSiglasEstado = new TextBox();
            tbEstado = new TextBox();
            btnSalir = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 296);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 63;
            label3.Text = "Pais:";
            // 
            // cbIdPais
            // 
            cbIdPais.FormattingEnabled = true;
            cbIdPais.Location = new Point(214, 293);
            cbIdPais.Name = "cbIdPais";
            cbIdPais.Size = new Size(151, 28);
            cbIdPais.TabIndex = 62;
            // 
            // tbSiglasEstado
            // 
            tbSiglasEstado.Location = new Point(214, 148);
            tbSiglasEstado.Name = "tbSiglasEstado";
            tbSiglasEstado.Size = new Size(151, 27);
            tbSiglasEstado.TabIndex = 61;
            // 
            // tbEstado
            // 
            tbEstado.Location = new Point(214, 81);
            tbEstado.Name = "tbEstado";
            tbEstado.Size = new Size(151, 27);
            tbEstado.TabIndex = 60;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(304, 363);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 59;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(136, 363);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 58;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 229);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 57;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 151);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 55;
            label2.Text = "Siglas Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 81);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 54;
            label1.Text = "Nombre Estado:";
            // 
            // EstadosE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 475);
            Controls.Add(label3);
            Controls.Add(cbIdPais);
            Controls.Add(tbSiglasEstado);
            Controls.Add(tbEstado);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EstadosE";
            Text = "EstadosE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbIdPais;
        private TextBox tbSiglasEstado;
        private TextBox tbEstado;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}