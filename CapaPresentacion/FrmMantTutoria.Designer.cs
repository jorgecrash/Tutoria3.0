
namespace CapaPresentacion
{
    partial class FrmMantTutoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantTutoria));
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomDocenteTutor = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textIdDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topFormulario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDocenteTutoria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HORARIO = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topFormulario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteTutoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.HORARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Guadar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(149, 464);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(111)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(111, 36);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guadar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Hora:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(239, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID DOCENTE";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(241, 37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 55;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.topFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Buscar:";
            // 
            // txtNomDocenteTutor
            // 
            this.txtNomDocenteTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomDocenteTutor.Location = new System.Drawing.Point(71, 45);
            this.txtNomDocenteTutor.Multiline = true;
            this.txtNomDocenteTutor.Name = "txtNomDocenteTutor";
            this.txtNomDocenteTutor.Size = new System.Drawing.Size(138, 20);
            this.txtNomDocenteTutor.TabIndex = 64;
            this.txtNomDocenteTutor.TextChanged += new System.EventHandler(this.txtNomDocenteTutor_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(22, 32);
            this.dtpFecha.MaxDate = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2021, 9, 22, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 21);
            this.dtpFecha.TabIndex = 65;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(131, 32);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(68, 21);
            this.dtpHora.TabIndex = 66;
            this.dtpHora.Value = new System.DateTime(2021, 9, 5, 12, 0, 0, 0);
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textIdDocente
            // 
            this.textIdDocente.BackColor = System.Drawing.Color.White;
            this.textIdDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdDocente.Enabled = false;
            this.textIdDocente.Location = new System.Drawing.Point(251, 45);
            this.textIdDocente.Name = "textIdDocente";
            this.textIdDocente.Size = new System.Drawing.Size(83, 14);
            this.textIdDocente.TabIndex = 67;
            this.textIdDocente.Validating += new System.ComponentModel.CancelEventHandler(this.textIdDocente_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "ID TUTORIA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(109, 38);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 28);
            this.btnNuevo.TabIndex = 71;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 83);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generara ID_Tutor";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.White;
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(20, 45);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(73, 14);
            this.textId.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(121)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 26);
            this.panel1.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(416, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTORIA";
            // 
            // topFormulario
            // 
            this.topFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(121)))));
            this.topFormulario.Controls.Add(this.label1);
            this.topFormulario.Controls.Add(this.pictureBox1);
            this.topFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormulario.Location = new System.Drawing.Point(0, 0);
            this.topFormulario.Name = "topFormulario";
            this.topFormulario.Size = new System.Drawing.Size(444, 27);
            this.topFormulario.TabIndex = 41;
            this.topFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.topFormulario_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDocenteTutoria);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 323);
            this.panel2.TabIndex = 74;
            // 
            // dgvDocenteTutoria
            // 
            this.dgvDocenteTutoria.AllowUserToAddRows = false;
            this.dgvDocenteTutoria.AllowUserToDeleteRows = false;
            this.dgvDocenteTutoria.AllowUserToOrderColumns = true;
            this.dgvDocenteTutoria.AllowUserToResizeColumns = false;
            this.dgvDocenteTutoria.AllowUserToResizeRows = false;
            this.dgvDocenteTutoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocenteTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDocenteTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocenteTutoria.EnableHeadersVisualStyles = false;
            this.dgvDocenteTutoria.Location = new System.Drawing.Point(10, 92);
            this.dgvDocenteTutoria.Name = "dgvDocenteTutoria";
            this.dgvDocenteTutoria.RowHeadersVisible = false;
            this.dgvDocenteTutoria.RowHeadersWidth = 30;
            this.dgvDocenteTutoria.Size = new System.Drawing.Size(399, 228);
            this.dgvDocenteTutoria.TabIndex = 64;
            this.dgvDocenteTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocenteTutoria_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textIdDocente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.txtNomDocenteTutor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 83);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Fecha:";
            // 
            // HORARIO
            // 
            this.HORARIO.BackColor = System.Drawing.Color.White;
            this.HORARIO.Controls.Add(this.label6);
            this.HORARIO.Controls.Add(this.label4);
            this.HORARIO.Controls.Add(this.dtpFecha);
            this.HORARIO.Controls.Add(this.dtpHora);
            this.HORARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HORARIO.Location = new System.Drawing.Point(216, 45);
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.Size = new System.Drawing.Size(205, 83);
            this.HORARIO.TabIndex = 77;
            this.HORARIO.TabStop = false;
            this.HORARIO.Text = "Horario";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.luupaaaa;
            this.pictureBox4.Location = new System.Drawing.Point(25, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(229, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID DOCENTE";
            // 
            // FrmMantTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(444, 530);
            this.Controls.Add(this.HORARIO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.topFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantTutoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantTutoria";
            this.Load += new System.EventHandler(this.FrmMantTutoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topFormulario.ResumeLayout(false);
            this.topFormulario.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteTutoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.HORARIO.ResumeLayout(false);
            this.HORARIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomDocenteTutor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox textIdDocente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Panel topFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDocenteTutoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox HORARIO;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
    }
}