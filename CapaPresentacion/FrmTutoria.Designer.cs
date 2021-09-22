
namespace CapaPresentacion
{
    partial class FrmTutoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTutoria));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel_principal_medio = new System.Windows.Forms.Panel();
            this.TablaTutoria = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNuevoDocentes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevoDocente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_principal.SuspendLayout();
            this.panel_principal_medio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTutoria)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1021, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 574);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 574);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 19);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 19);
            this.panel1.TabIndex = 0;
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.panel_principal_medio);
            this.panel_principal.Controls.Add(this.panel4);
            this.panel_principal.Controls.Add(this.panel3);
            this.panel_principal.Controls.Add(this.panel2);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1040, 612);
            this.panel_principal.TabIndex = 1;
            // 
            // panel_principal_medio
            // 
            this.panel_principal_medio.Controls.Add(this.TablaTutoria);
            this.panel_principal_medio.Controls.Add(this.panel8);
            this.panel_principal_medio.Controls.Add(this.panel7);
            this.panel_principal_medio.Controls.Add(this.panel9);
            this.panel_principal_medio.Controls.Add(this.panel5);
            this.panel_principal_medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal_medio.Location = new System.Drawing.Point(19, 19);
            this.panel_principal_medio.Name = "panel_principal_medio";
            this.panel_principal_medio.Size = new System.Drawing.Size(1002, 574);
            this.panel_principal_medio.TabIndex = 4;
            // 
            // TablaTutoria
            // 
            this.TablaTutoria.AllowUserToAddRows = false;
            this.TablaTutoria.AllowUserToOrderColumns = true;
            this.TablaTutoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaTutoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaTutoria.BackgroundColor = System.Drawing.Color.White;
            this.TablaTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaTutoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTutoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.TablaTutoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaTutoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaTutoria.Location = new System.Drawing.Point(5, 76);
            this.TablaTutoria.Name = "TablaTutoria";
            this.TablaTutoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaTutoria.RowHeadersVisible = false;
            this.TablaTutoria.RowHeadersWidth = 51;
            this.TablaTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaTutoria.Size = new System.Drawing.Size(992, 478);
            this.TablaTutoria.TabIndex = 40;
            this.TablaTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaTutoria_CellContentClick);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(997, 76);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 478);
            this.panel8.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 478);
            this.panel7.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 554);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1002, 20);
            this.panel9.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnNuevoDocente);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 76);
            this.panel5.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.textBuscar);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.btnNuevoDocentes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1002, 76);
            this.panel6.TabIndex = 25;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(21, 60);
            this.panel11.TabIndex = 34;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1002, 16);
            this.panel10.TabIndex = 33;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(59, 30);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(304, 30);
            this.textBuscar.TabIndex = 31;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.luupaaaa;
            this.pictureBox3.Location = new System.Drawing.Point(23, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
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
            this.btnNuevoDocentes.IconZoom = 40D;
            this.btnNuevoDocentes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevoDocentes.IsTab = false;
            this.btnNuevoDocentes.Location = new System.Drawing.Point(370, 30);
            this.btnNuevoDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoDocentes.Name = "btnNuevoDocentes";
            this.btnNuevoDocentes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoDocentes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnNuevoDocentes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoDocentes.selected = false;
            this.btnNuevoDocentes.Size = new System.Drawing.Size(156, 30);
            this.btnNuevoDocentes.TabIndex = 8;
            this.btnNuevoDocentes.Text = "    Agregar Tutoria";
            this.btnNuevoDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDocentes.Textcolor = System.Drawing.Color.White;
            this.btnNuevoDocentes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocentes.Click += new System.EventHandler(this.btnAgregarTutoria_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.ActiveBorderThickness = 1;
            this.btnNuevoDocente.ActiveCornerRadius = 20;
            this.btnNuevoDocente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoDocente.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoDocente.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevoDocente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoDocente.BackgroundImage")));
            this.btnNuevoDocente.ButtonText = "Agregar Tutoria";
            this.btnNuevoDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNuevoDocente.IdleBorderThickness = 1;
            this.btnNuevoDocente.IdleCornerRadius = 20;
            this.btnNuevoDocente.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevoDocente.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.Location = new System.Drawing.Point(362, 15);
            this.btnNuevoDocente.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(181, 44);
            this.btnNuevoDocente.TabIndex = 1;
            this.btnNuevoDocente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnAgregarTutoria_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTutoria";
            this.Text = "FrmTutoria";
            this.panel_principal.ResumeLayout(false);
            this.panel_principal_medio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaTutoria)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel_principal_medio;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoDocente;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoDocentes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView TablaTutoria;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}