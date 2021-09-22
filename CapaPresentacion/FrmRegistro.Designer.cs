
namespace CapaPresentacion
{
    partial class FrmRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.TablaRegistro = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNuevoDocentes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.Controls.Add(this.panel7);
            this.panel_Principal.Controls.Add(this.panel8);
            this.panel_Principal.Controls.Add(this.TablaRegistro);
            this.panel_Principal.Controls.Add(this.panel9);
            this.panel_Principal.Controls.Add(this.panel5);
            this.panel_Principal.Controls.Add(this.panel4);
            this.panel_Principal.Controls.Add(this.panel3);
            this.panel_Principal.Controls.Add(this.panel2);
            this.panel_Principal.Controls.Add(this.panel1);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(1040, 612);
            this.panel_Principal.TabIndex = 0;
            // 
            // TablaRegistro
            // 
            this.TablaRegistro.AllowUserToAddRows = false;
            this.TablaRegistro.AllowUserToOrderColumns = true;
            this.TablaRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaRegistro.BackgroundColor = System.Drawing.Color.White;
            this.TablaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaRegistro.Location = new System.Drawing.Point(19, 95);
            this.TablaRegistro.Name = "TablaRegistro";
            this.TablaRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.RowHeadersVisible = false;
            this.TablaRegistro.RowHeadersWidth = 51;
            this.TablaRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaRegistro.Size = new System.Drawing.Size(1002, 478);
            this.TablaRegistro.TabIndex = 33;
            this.TablaRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaRegistro_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Width = 69;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Width = 80;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(19, 573);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1002, 20);
            this.panel9.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.textBuscar);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.btnNuevoDocentes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(19, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 76);
            this.panel5.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1021, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 574);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 574);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 19);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 19);
            this.panel1.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1016, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 478);
            this.panel8.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(19, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 478);
            this.panel7.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(997, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 76);
            this.panel6.TabIndex = 39;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(64, 24);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(304, 30);
            this.textBuscar.TabIndex = 37;
            this.textBuscar.Click += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.luupaaaa;
            this.pictureBox3.Location = new System.Drawing.Point(28, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // btnNuevoDocentes
            // 
            this.btnNuevoDocentes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            this.btnNuevoDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoDocentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoDocentes.BorderRadius = 0;
            this.btnNuevoDocentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNuevoDocentes.ButtonText = "    Agregar Tutoria";
            this.btnNuevoDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDocentes.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoDocentes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoDocentes.Iconimage = global::CapaPresentacion.Properties.Resources.discusion_1;
            this.btnNuevoDocentes.Iconimage_right = null;
            this.btnNuevoDocentes.Iconimage_right_Selected = null;
            this.btnNuevoDocentes.Iconimage_Selected = null;
            this.btnNuevoDocentes.IconMarginLeft = 10;
            this.btnNuevoDocentes.IconMarginRight = 0;
            this.btnNuevoDocentes.IconRightVisible = true;
            this.btnNuevoDocentes.IconRightZoom = 0D;
            this.btnNuevoDocentes.IconVisible = true;
            this.btnNuevoDocentes.IconZoom = 45D;
            this.btnNuevoDocentes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevoDocentes.IsTab = false;
            this.btnNuevoDocentes.Location = new System.Drawing.Point(390, 24);
            this.btnNuevoDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoDocentes.Name = "btnNuevoDocentes";
            this.btnNuevoDocentes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoDocentes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnNuevoDocentes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoDocentes.selected = false;
            this.btnNuevoDocentes.Size = new System.Drawing.Size(194, 30);
            this.btnNuevoDocentes.TabIndex = 36;
            this.btnNuevoDocentes.Text = "    Agregar Tutoria";
            this.btnNuevoDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDocentes.Textcolor = System.Drawing.Color.White;
            this.btnNuevoDocentes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocentes.Click += new System.EventHandler(this.btnRegistrarEstudianteATutoria_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.panel_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView TablaRegistro;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoDocentes;
    }
}