namespace Hospital
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnHardcodearMásPacientes = new System.Windows.Forms.Button();
            this.mensajersMolestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajesMolestos2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.mensajersMolestosToolStripMenuItem,
            this.mensajesMolestos2ToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem.Text = "&Medico";
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.medicoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // dtgvPacientes
            // 
            this.dtgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPacientes.Location = new System.Drawing.Point(107, 62);
            this.dtgvPacientes.Name = "dtgvPacientes";
            this.dtgvPacientes.Size = new System.Drawing.Size(499, 221);
            this.dtgvPacientes.TabIndex = 1;
            // 
            // btnHardcodearMásPacientes
            // 
            this.btnHardcodearMásPacientes.Location = new System.Drawing.Point(121, 314);
            this.btnHardcodearMásPacientes.Name = "btnHardcodearMásPacientes";
            this.btnHardcodearMásPacientes.Size = new System.Drawing.Size(462, 23);
            this.btnHardcodearMásPacientes.TabIndex = 2;
            this.btnHardcodearMásPacientes.Text = "Boton para agregar más pacientes";
            this.btnHardcodearMásPacientes.UseVisualStyleBackColor = true;
            this.btnHardcodearMásPacientes.Click += new System.EventHandler(this.btnHardcodearMásPacientes_Click);
            // 
            // mensajersMolestosToolStripMenuItem
            // 
            this.mensajersMolestosToolStripMenuItem.Name = "mensajersMolestosToolStripMenuItem";
            this.mensajersMolestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensajersMolestosToolStripMenuItem.Text = "Mensajers Molestos";
            this.mensajersMolestosToolStripMenuItem.Click += new System.EventHandler(this.mensajersMolestosToolStripMenuItem_Click);
            // 
            // mensajesMolestos2ToolStripMenuItem
            // 
            this.mensajesMolestos2ToolStripMenuItem.Name = "mensajesMolestos2ToolStripMenuItem";
            this.mensajesMolestos2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensajesMolestos2ToolStripMenuItem.Text = "Mensajes Molestos2";
            this.mensajesMolestos2ToolStripMenuItem.Click += new System.EventHandler(this.mensajesMolestos2ToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 392);
            this.Controls.Add(this.btnHardcodearMásPacientes);
            this.Controls.Add(this.dtgvPacientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPpal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frm_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvPacientes;
        private System.Windows.Forms.Button btnHardcodearMásPacientes;
        private System.Windows.Forms.ToolStripMenuItem mensajersMolestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajesMolestos2ToolStripMenuItem;
    }
}