namespace SistemaEscolarBD
{
    partial class PaisE
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
            tbSiglasPais = new TextBox();
            tbNombrePais = new TextBox();
            btnSalir = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Siglas = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbSiglasPais
            // 
            tbSiglasPais.Location = new Point(214, 161);
            tbSiglasPais.Name = "tbSiglasPais";
            tbSiglasPais.Size = new Size(151, 27);
            tbSiglasPais.TabIndex = 57;
            // 
            // tbNombrePais
            // 
            tbNombrePais.Location = new Point(214, 94);
            tbNombrePais.Name = "tbNombrePais";
            tbNombrePais.Size = new Size(151, 27);
            tbNombrePais.TabIndex = 56;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(298, 351);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 55;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(130, 351);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 54;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 242);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 53;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 52;
            // 
            // Siglas
            // 
            Siglas.AutoSize = true;
            Siglas.Location = new Point(126, 168);
            Siglas.Name = "Siglas";
            Siglas.Size = new Size(82, 20);
            Siglas.TabIndex = 51;
            Siglas.Text = "Siglas pais:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 97);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 50;
            label1.Text = "Nombre pais:";
            // 
            // PaisE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 474);
            Controls.Add(tbSiglasPais);
            Controls.Add(tbNombrePais);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(Siglas);
            Controls.Add(label1);
            Name = "PaisE";
            Text = "PaisE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSiglasPais;
        private TextBox tbNombrePais;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label Siglas;
        private Label label1;
    }
}