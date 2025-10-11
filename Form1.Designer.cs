namespace SistemaEscolarBD
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbObtener = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbObtener, toolStripButton1, toolStripButton2, tsbEditar, tsbEliminar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbObtener
            // 
            tsbObtener.Image = Properties.Resources.document_folder_get_e_icon_232920;
            tsbObtener.ImageTransparentColor = Color.Magenta;
            tsbObtener.Name = "tsbObtener";
            tsbObtener.Size = new Size(87, 24);
            tsbObtener.Text = "Obtener";
            tsbObtener.Click += tsbObtener_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.add_circle_create_expand_new_plus_icon_123218;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(87, 24);
            toolStripButton1.Text = "Agregar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.Image = Properties.Resources.cancel_close_delete_exit_logout_remove_x_icon_123217;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(62, 24);
            toolStripButton2.Text = "Salir";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_icon_128873;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(72, 24);
            tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = Properties.Resources.trash_bin_icon_icons_com_67981;
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(87, 24);
            tsbEliminar.Text = "Eliminar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 423);
            dataGridView1.TabIndex = 1;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "Registro";
            Text = "Registro";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tsbObtener;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        public DataGridView dataGridView1;
    }
}
