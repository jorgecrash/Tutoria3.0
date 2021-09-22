
namespace CapaPresentacion
{
    partial class FrmMantRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantRegistro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textIdTutoria = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textIdEstudiante = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.topFormulario = new System.Windows.Forms.Panel();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgvRegistroDocenteTutoria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvEstudianteRegistrarTutoria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscarTutoriaDocente = new System.Windows.Forms.TextBox();
            this.txtBuscarTutoriaEstudiante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.topFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDocenteTutoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteRegistrarTutoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTORIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(821, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textIdTutoria
            // 
            this.textIdTutoria.BackColor = System.Drawing.Color.White;
            this.textIdTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdTutoria.Enabled = false;
            this.textIdTutoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdTutoria.ForeColor = System.Drawing.Color.Black;
            this.textIdTutoria.Location = new System.Drawing.Point(135, 243);
            this.textIdTutoria.Name = "textIdTutoria";
            this.textIdTutoria.Size = new System.Drawing.Size(157, 17);
            this.textIdTutoria.TabIndex = 71;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // textIdEstudiante
            // 
            this.textIdEstudiante.BackColor = System.Drawing.Color.White;
            this.textIdEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdEstudiante.Enabled = false;
            this.textIdEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdEstudiante.ForeColor = System.Drawing.Color.Black;
            this.textIdEstudiante.Location = new System.Drawing.Point(530, 243);
            this.textIdEstudiante.Name = "textIdEstudiante";
            this.textIdEstudiante.Size = new System.Drawing.Size(157, 17);
            this.textIdEstudiante.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(520, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(171, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "ID TUTORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(561, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "ID ESTUDIANTE";
            // 
            // topFormulario
            // 
            this.topFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.topFormulario.Controls.Add(this.label1);
            this.topFormulario.Controls.Add(this.pictureBox1);
            this.topFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormulario.Location = new System.Drawing.Point(0, 0);
            this.topFormulario.Name = "topFormulario";
            this.topFormulario.Size = new System.Drawing.Size(852, 25);
            this.topFormulario.TabIndex = 61;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.topFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // dgvRegistroDocenteTutoria
            // 
            this.dgvRegistroDocenteTutoria.AllowUserToAddRows = false;
            this.dgvRegistroDocenteTutoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRegistroDocenteTutoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegistroDocenteTutoria.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRegistroDocenteTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroDocenteTutoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistroDocenteTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroDocenteTutoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegistroDocenteTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroDocenteTutoria.ColumnHeadersVisible = false;
            this.dgvRegistroDocenteTutoria.DoubleBuffered = true;
            this.dgvRegistroDocenteTutoria.EnableHeadersVisualStyles = false;
            this.dgvRegistroDocenteTutoria.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvRegistroDocenteTutoria.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRegistroDocenteTutoria.Location = new System.Drawing.Point(13, 51);
            this.dgvRegistroDocenteTutoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRegistroDocenteTutoria.Name = "dgvRegistroDocenteTutoria";
            this.dgvRegistroDocenteTutoria.ReadOnly = true;
            this.dgvRegistroDocenteTutoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistroDocenteTutoria.RowHeadersVisible = false;
            this.dgvRegistroDocenteTutoria.RowHeadersWidth = 51;
            this.dgvRegistroDocenteTutoria.RowTemplate.Height = 24;
            this.dgvRegistroDocenteTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroDocenteTutoria.Size = new System.Drawing.Size(346, 147);
            this.dgvRegistroDocenteTutoria.TabIndex = 72;
            this.dgvRegistroDocenteTutoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroDocenteTutoria_CellClick);
            this.dgvRegistroDocenteTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroDocenteTutoria_CellContentClick);
            this.dgvRegistroDocenteTutoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRegistroDocenteTutoria_MouseClick);
            // 
            // dgvEstudianteRegistrarTutoria
            // 
            this.dgvEstudianteRegistrarTutoria.AllowUserToAddRows = false;
            this.dgvEstudianteRegistrarTutoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstudianteRegistrarTutoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEstudianteRegistrarTutoria.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEstudianteRegistrarTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersVisible = false;
            this.dgvEstudianteRegistrarTutoria.DoubleBuffered = true;
            this.dgvEstudianteRegistrarTutoria.EnableHeadersVisualStyles = false;
            this.dgvEstudianteRegistrarTutoria.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudianteRegistrarTutoria.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudianteRegistrarTutoria.Location = new System.Drawing.Point(14, 55);
            this.dgvEstudianteRegistrarTutoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEstudianteRegistrarTutoria.Name = "dgvEstudianteRegistrarTutoria";
            this.dgvEstudianteRegistrarTutoria.ReadOnly = true;
            this.dgvEstudianteRegistrarTutoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstudianteRegistrarTutoria.RowHeadersVisible = false;
            this.dgvEstudianteRegistrarTutoria.RowHeadersWidth = 51;
            this.dgvEstudianteRegistrarTutoria.RowTemplate.Height = 24;
            this.dgvEstudianteRegistrarTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudianteRegistrarTutoria.Size = new System.Drawing.Size(346, 143);
            this.dgvEstudianteRegistrarTutoria.TabIndex = 73;
            this.dgvEstudianteRegistrarTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudianteRegistrarTutoria_CellContentClick);
            // 
            // txtBuscarTutoriaDocente
            // 
            this.txtBuscarTutoriaDocente.Location = new System.Drawing.Point(13, 20);
            this.txtBuscarTutoriaDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarTutoriaDocente.Name = "txtBuscarTutoriaDocente";
            this.txtBuscarTutoriaDocente.Size = new System.Drawing.Size(244, 21);
            this.txtBuscarTutoriaDocente.TabIndex = 74;
            this.txtBuscarTutoriaDocente.TextChanged += new System.EventHandler(this.txtBuscarTutoriaDocente_TextChanged);
            // 
            // txtBuscarTutoriaEstudiante
            // 
            this.txtBuscarTutoriaEstudiante.Location = new System.Drawing.Point(14, 19);
            this.txtBuscarTutoriaEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarTutoriaEstudiante.Name = "txtBuscarTutoriaEstudiante";
            this.txtBuscarTutoriaEstudiante.Size = new System.Drawing.Size(248, 21);
            this.txtBuscarTutoriaEstudiante.TabIndex = 75;
            this.txtBuscarTutoriaEstudiante.TextChanged += new System.EventHandler(this.txtBuscarTutoriaEstudiante_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarTutoriaDocente);
            this.groupBox1.Controls.Add(this.dgvRegistroDocenteTutoria);
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(377, 202);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR TUTOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarTutoriaEstudiante);
            this.groupBox2.Controls.Add(this.dgvEstudianteRegistrarTutoria);
            this.groupBox2.Location = new System.Drawing.Point(425, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(377, 202);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR ESTUDIANTE";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.textIdEstudiante);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textIdTutoria);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 295);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscadores";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGuardar.ButtonText = "  Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::CapaPresentacion.Properties.Resources.archivos_y_carpetas__1_;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 10;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 40D;
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(725, 364);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(118, 35);
            this.btnGuardar.TabIndex = 106;
            this.btnGuardar.Text = "  Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 25);
            this.panel1.TabIndex = 79;
            // 
            // FrmMantRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(852, 431);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.topFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.FrmMantRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.topFormulario.ResumeLayout(false);
            this.topFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDocenteTutoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteRegistrarTutoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textIdTutoria;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textIdEstudiante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel topFormulario;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRegistroDocenteTutoria;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEstudianteRegistrarTutoria;
        private System.Windows.Forms.TextBox txtBuscarTutoriaDocente;
        private System.Windows.Forms.TextBox txtBuscarTutoriaEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
    }
}