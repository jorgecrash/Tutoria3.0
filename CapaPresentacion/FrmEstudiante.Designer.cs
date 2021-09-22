
namespace CapaPresentacion
{
    partial class FrmEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiante));
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_principal = new System.Windows.Forms.Panel();
            this.Panel_principal_medio = new System.Windows.Forms.Panel();
            this.TablaEstudiante = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNuevoEstudiante = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_principal.SuspendLayout();
            this.Panel_principal_medio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 0;
            this.gunaElipse2.TargetControl = this.textBuscar;
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.Panel_principal_medio);
            this.panel_principal.Controls.Add(this.panel6);
            this.panel_principal.Controls.Add(this.panel4);
            this.panel_principal.Controls.Add(this.panel3);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1092, 699);
            this.panel_principal.TabIndex = 1;
            // 
            // Panel_principal_medio
            // 
            this.Panel_principal_medio.BackColor = System.Drawing.Color.Transparent;
            this.Panel_principal_medio.Controls.Add(this.TablaEstudiante);
            this.Panel_principal_medio.Controls.Add(this.panel9);
            this.Panel_principal_medio.Controls.Add(this.panel8);
            this.Panel_principal_medio.Controls.Add(this.panel7);
            this.Panel_principal_medio.Controls.Add(this.panel5);
            this.Panel_principal_medio.Controls.Add(this.panel2);
            this.Panel_principal_medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_principal_medio.Location = new System.Drawing.Point(19, 19);
            this.Panel_principal_medio.Name = "Panel_principal_medio";
            this.Panel_principal_medio.Size = new System.Drawing.Size(1028, 655);
            this.Panel_principal_medio.TabIndex = 15;
            // 
            // TablaEstudiante
            // 
            this.TablaEstudiante.AllowUserToAddRows = false;
            this.TablaEstudiante.AllowUserToOrderColumns = true;
            this.TablaEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaEstudiante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaEstudiante.BackgroundColor = System.Drawing.Color.White;
            this.TablaEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEstudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TablaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaEstudiante.DefaultCellStyle = dataGridViewCellStyle3;
            this.TablaEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaEstudiante.Location = new System.Drawing.Point(5, 96);
            this.TablaEstudiante.Name = "TablaEstudiante";
            this.TablaEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaEstudiante.RowHeadersVisible = false;
            this.TablaEstudiante.RowHeadersWidth = 51;
            this.TablaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaEstudiante.Size = new System.Drawing.Size(1018, 539);
            this.TablaEstudiante.TabIndex = 25;
            this.TablaEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEstudiante_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SlateGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(5, 635);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1018, 20);
            this.panel9.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1023, 96);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 559);
            this.panel8.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 559);
            this.panel7.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.btnNuevoEstudiante);
            this.panel5.Controls.Add(this.textBuscar);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1028, 76);
            this.panel5.TabIndex = 18;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(61, 27);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(304, 30);
            this.textBuscar.TabIndex = 7;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 20);
            this.panel2.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(19, 674);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1028, 25);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(19, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 19);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1047, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 699);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 699);
            this.panel1.TabIndex = 9;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 0;
            this.gunaElipse3.TargetControl = this.Panel_principal_medio;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = null;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 1.196411F;
            this.dataGridViewImageColumn1.HeaderText = "EDITAR";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 69;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 198.8035F;
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 80;
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 1.196411F;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Width = 69;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.FillWeight = 198.8035F;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Width = 80;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.Salir.Location = new System.Drawing.Point(995, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(27, 20);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 8;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.luupaaaa;
            this.pictureBox2.Location = new System.Drawing.Point(25, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            this.btnNuevoEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoEstudiante.BorderRadius = 0;
            this.btnNuevoEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNuevoEstudiante.ButtonText = "    Agregar Estudiante";
            this.btnNuevoEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEstudiante.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoEstudiante.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoEstudiante.Iconimage = global::CapaPresentacion.Properties.Resources.estudiante_con_gorro_de_graduacion;
            this.btnNuevoEstudiante.Iconimage_right = null;
            this.btnNuevoEstudiante.Iconimage_right_Selected = null;
            this.btnNuevoEstudiante.Iconimage_Selected = null;
            this.btnNuevoEstudiante.IconMarginLeft = 10;
            this.btnNuevoEstudiante.IconMarginRight = 0;
            this.btnNuevoEstudiante.IconRightVisible = true;
            this.btnNuevoEstudiante.IconRightZoom = 0D;
            this.btnNuevoEstudiante.IconVisible = true;
            this.btnNuevoEstudiante.IconZoom = 30D;
            this.btnNuevoEstudiante.IsTab = false;
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(372, 27);
            this.btnNuevoEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoEstudiante.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnNuevoEstudiante.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoEstudiante.selected = false;
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(177, 30);
            this.btnNuevoEstudiante.TabIndex = 8;
            this.btnNuevoEstudiante.Text = "    Agregar Estudiante";
            this.btnNuevoEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstudiante.Textcolor = System.Drawing.Color.White;
            this.btnNuevoEstudiante.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudiante.Click += new System.EventHandler(this.btnNuevoEstudiante_Click);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 699);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiante";
            this.Text = "FrmEstudiante";
            this.panel_principal.ResumeLayout(false);
            this.Panel_principal_medio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.Panel Panel_principal_medio;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DataGridView TablaEstudiante;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoEstudiante;
    }
}