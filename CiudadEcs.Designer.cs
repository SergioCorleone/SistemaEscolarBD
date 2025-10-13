namespace SistemaEscolarBD
{
    partial class CiudadEcs
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
            cbIdEstado = new ComboBox();
            tbSiglasCiudad = new TextBox();
            tbCuidad = new TextBox();
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
            label3.Location = new Point(157, 286);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 53;
            label3.Text = "Estado:";
            // 
            // cbIdEstado
            // 
            cbIdEstado.FormattingEnabled = true;
            cbIdEstado.Location = new Point(220, 283);
            cbIdEstado.Name = "cbIdEstado";
            cbIdEstado.Size = new Size(151, 28);
            cbIdEstado.TabIndex = 52;
            // 
            // tbSiglasCiudad
            // 
            tbSiglasCiudad.Location = new Point(220, 138);
            tbSiglasCiudad.Name = "tbSiglasCiudad";
            tbSiglasCiudad.Size = new Size(151, 27);
            tbSiglasCiudad.TabIndex = 51;
            // 
            // tbCuidad
            // 
            tbCuidad.Location = new Point(220, 71);
            tbCuidad.Name = "tbCuidad";
            tbCuidad.Size = new Size(151, 27);
            tbCuidad.TabIndex = 50;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(310, 353);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 49;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(142, 353);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 219);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 47;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(220, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 141);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 45;
            label2.Text = "Siglas Ciudad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 71);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 44;
            label1.Text = "Nombre Ciudad:";
            // 
            // CiudadEcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(label3);
            Controls.Add(cbIdEstado);
            Controls.Add(tbSiglasCiudad);
            Controls.Add(tbCuidad);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CiudadEcs";
            Text = "CiudadEcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbIdEstado;
        private TextBox tbSiglasCiudad;
        private TextBox tbCuidad;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
    }
}