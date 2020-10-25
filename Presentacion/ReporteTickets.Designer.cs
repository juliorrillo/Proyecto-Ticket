namespace Proyecto_Ticket.Presentacion
{
    partial class ReporteTickets
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
            this.LvReporte = new System.Windows.Forms.ListView();
            this.idTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.propietario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asignado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbierto = new System.Windows.Forms.Button();
            this.btnEnProgreso = new System.Windows.Forms.Button();
            this.btnCerrado = new System.Windows.Forms.Button();
            this.btnResuelto = new System.Windows.Forms.Button();
            this.dateCreacionDesde = new System.Windows.Forms.DateTimePicker();
            this.dateCreacionHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadAbierto = new System.Windows.Forms.TextBox();
            this.txtCantidadEnProgreso = new System.Windows.Forms.TextBox();
            this.txtCantidadResuelto = new System.Windows.Forms.TextBox();
            this.txtCantidadCerrado = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.btnReporteSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadTickets = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvReporte
            // 
            this.LvReporte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvReporte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTicket,
            this.estado,
            this.detalle,
            this.descripcion,
            this.propietario,
            this.asignado});
            this.LvReporte.Location = new System.Drawing.Point(6, 136);
            this.LvReporte.Name = "LvReporte";
            this.LvReporte.Size = new System.Drawing.Size(961, 269);
            this.LvReporte.TabIndex = 0;
            this.LvReporte.UseCompatibleStateImageBehavior = false;
            this.LvReporte.View = System.Windows.Forms.View.Details;
            // 
            // idTicket
            // 
            this.idTicket.Text = "N° Ticket";
            this.idTicket.Width = 103;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 107;
            // 
            // detalle
            // 
            this.detalle.Text = "Detalle";
            this.detalle.Width = 230;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripción";
            this.descripcion.Width = 233;
            // 
            // propietario
            // 
            this.propietario.Text = "Propietario";
            this.propietario.Width = 150;
            // 
            // asignado
            // 
            this.asignado.Text = "Asignado a";
            this.asignado.Width = 150;
            // 
            // btnAbierto
            // 
            this.btnAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbierto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbierto.ForeColor = System.Drawing.Color.White;
            this.btnAbierto.Location = new System.Drawing.Point(15, 20);
            this.btnAbierto.Name = "btnAbierto";
            this.btnAbierto.Size = new System.Drawing.Size(153, 56);
            this.btnAbierto.TabIndex = 1;
            this.btnAbierto.Text = "Abiertos";
            this.btnAbierto.UseVisualStyleBackColor = true;
            this.btnAbierto.Click += new System.EventHandler(this.BtnAbierto_Click);
            // 
            // btnEnProgreso
            // 
            this.btnEnProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnProgreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnProgreso.ForeColor = System.Drawing.Color.White;
            this.btnEnProgreso.Location = new System.Drawing.Point(174, 20);
            this.btnEnProgreso.Name = "btnEnProgreso";
            this.btnEnProgreso.Size = new System.Drawing.Size(153, 56);
            this.btnEnProgreso.TabIndex = 2;
            this.btnEnProgreso.Text = "En progreso";
            this.btnEnProgreso.UseVisualStyleBackColor = true;
            this.btnEnProgreso.Click += new System.EventHandler(this.BtnEnProgreso_Click);
            // 
            // btnCerrado
            // 
            this.btnCerrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrado.ForeColor = System.Drawing.Color.White;
            this.btnCerrado.Location = new System.Drawing.Point(492, 19);
            this.btnCerrado.Name = "btnCerrado";
            this.btnCerrado.Size = new System.Drawing.Size(153, 56);
            this.btnCerrado.TabIndex = 3;
            this.btnCerrado.Text = "Cerrados";
            this.btnCerrado.UseVisualStyleBackColor = true;
            this.btnCerrado.Click += new System.EventHandler(this.BtnCerrado_Click);
            // 
            // btnResuelto
            // 
            this.btnResuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResuelto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResuelto.ForeColor = System.Drawing.Color.White;
            this.btnResuelto.Location = new System.Drawing.Point(333, 19);
            this.btnResuelto.Name = "btnResuelto";
            this.btnResuelto.Size = new System.Drawing.Size(153, 56);
            this.btnResuelto.TabIndex = 4;
            this.btnResuelto.Text = "Resueltos";
            this.btnResuelto.UseVisualStyleBackColor = true;
            this.btnResuelto.Click += new System.EventHandler(this.BtnResuelto_Click);
            // 
            // dateCreacionDesde
            // 
            this.dateCreacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreacionDesde.Location = new System.Drawing.Point(661, 36);
            this.dateCreacionDesde.Name = "dateCreacionDesde";
            this.dateCreacionDesde.Size = new System.Drawing.Size(113, 20);
            this.dateCreacionDesde.TabIndex = 5;
            this.dateCreacionDesde.Value = new System.DateTime(2019, 7, 24, 0, 0, 0, 0);
            // 
            // dateCreacionHasta
            // 
            this.dateCreacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreacionHasta.Location = new System.Drawing.Point(661, 82);
            this.dateCreacionHasta.Name = "dateCreacionHasta";
            this.dateCreacionHasta.Size = new System.Drawing.Size(113, 20);
            this.dateCreacionHasta.TabIndex = 6;
            this.dateCreacionHasta.Value = new System.DateTime(2019, 7, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(657, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(659, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Hasta";
            // 
            // txtCantidadAbierto
            // 
            this.txtCantidadAbierto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadAbierto.Enabled = false;
            this.txtCantidadAbierto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadAbierto.ForeColor = System.Drawing.Color.White;
            this.txtCantidadAbierto.Location = new System.Drawing.Point(15, 74);
            this.txtCantidadAbierto.Name = "txtCantidadAbierto";
            this.txtCantidadAbierto.Size = new System.Drawing.Size(153, 27);
            this.txtCantidadAbierto.TabIndex = 9;
            // 
            // txtCantidadEnProgreso
            // 
            this.txtCantidadEnProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadEnProgreso.Enabled = false;
            this.txtCantidadEnProgreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEnProgreso.ForeColor = System.Drawing.Color.White;
            this.txtCantidadEnProgreso.Location = new System.Drawing.Point(174, 74);
            this.txtCantidadEnProgreso.Name = "txtCantidadEnProgreso";
            this.txtCantidadEnProgreso.Size = new System.Drawing.Size(153, 27);
            this.txtCantidadEnProgreso.TabIndex = 10;
            // 
            // txtCantidadResuelto
            // 
            this.txtCantidadResuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadResuelto.Enabled = false;
            this.txtCantidadResuelto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadResuelto.ForeColor = System.Drawing.Color.White;
            this.txtCantidadResuelto.Location = new System.Drawing.Point(333, 74);
            this.txtCantidadResuelto.Name = "txtCantidadResuelto";
            this.txtCantidadResuelto.Size = new System.Drawing.Size(153, 27);
            this.txtCantidadResuelto.TabIndex = 11;
            // 
            // txtCantidadCerrado
            // 
            this.txtCantidadCerrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadCerrado.Enabled = false;
            this.txtCantidadCerrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCerrado.ForeColor = System.Drawing.Color.White;
            this.txtCantidadCerrado.Location = new System.Drawing.Point(492, 74);
            this.txtCantidadCerrado.Name = "txtCantidadCerrado";
            this.txtCantidadCerrado.Size = new System.Drawing.Size(153, 27);
            this.txtCantidadCerrado.TabIndex = 12;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Impresoras",
            "Redes",
            "Configuracion",
            "Hardware",
            "Telefonos IP",
            "Desarrollo",
            "Nuevas Funcionalidad",
            "Coccion De Datos",
            "Reportes",
            "OTROS"});
            this.comboCategoria.Location = new System.Drawing.Point(805, 35);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboArea);
            this.groupBox1.Controls.Add(this.btnEnProgreso);
            this.groupBox1.Controls.Add(this.comboCategoria);
            this.groupBox1.Controls.Add(this.btnAbierto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadCerrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateCreacionHasta);
            this.groupBox1.Controls.Add(this.btnCerrado);
            this.groupBox1.Controls.Add(this.dateCreacionDesde);
            this.groupBox1.Controls.Add(this.txtCantidadResuelto);
            this.groupBox1.Controls.Add(this.btnResuelto);
            this.groupBox1.Controls.Add(this.txtCantidadEnProgreso);
            this.groupBox1.Controls.Add(this.txtCantidadAbierto);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 115);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(801, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(801, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categoria:";
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Items.AddRange(new object[] {
            "Administracion",
            "Tesoreria",
            "Contabilidad",
            "Costos",
            "Recepcion",
            "Diseño",
            "Producto",
            "Sistemas"});
            this.comboArea.Location = new System.Drawing.Point(805, 81);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(121, 21);
            this.comboArea.TabIndex = 14;
            // 
            // btnReporteSalir
            // 
            this.btnReporteSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteSalir.ForeColor = System.Drawing.Color.White;
            this.btnReporteSalir.Location = new System.Drawing.Point(849, 408);
            this.btnReporteSalir.Name = "btnReporteSalir";
            this.btnReporteSalir.Size = new System.Drawing.Size(113, 44);
            this.btnReporteSalir.TabIndex = 15;
            this.btnReporteSalir.Text = "Salir";
            this.btnReporteSalir.UseVisualStyleBackColor = true;
            this.btnReporteSalir.Click += new System.EventHandler(this.BtnReporteSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad de Ticket:";
            // 
            // txtCantidadTickets
            // 
            this.txtCantidadTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidadTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadTickets.Enabled = false;
            this.txtCantidadTickets.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTickets.ForeColor = System.Drawing.Color.White;
            this.txtCantidadTickets.Location = new System.Drawing.Point(169, 416);
            this.txtCantidadTickets.Name = "txtCantidadTickets";
            this.txtCantidadTickets.Size = new System.Drawing.Size(77, 31);
            this.txtCantidadTickets.TabIndex = 15;
            this.txtCantidadTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReporteTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(974, 462);
            this.Controls.Add(this.txtCantidadTickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReporteSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LvReporte);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteTickets";
            this.Text = "ReporteTickets";
            this.Load += new System.EventHandler(this.ReporteTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvReporte;
        private System.Windows.Forms.ColumnHeader idTicket;
        private System.Windows.Forms.Button btnAbierto;
        private System.Windows.Forms.Button btnEnProgreso;
        private System.Windows.Forms.Button btnCerrado;
        private System.Windows.Forms.Button btnResuelto;
        private System.Windows.Forms.DateTimePicker dateCreacionDesde;
        private System.Windows.Forms.DateTimePicker dateCreacionHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadAbierto;
        private System.Windows.Forms.TextBox txtCantidadEnProgreso;
        private System.Windows.Forms.TextBox txtCantidadResuelto;
        private System.Windows.Forms.TextBox txtCantidadCerrado;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Button btnReporteSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader detalle;
        private System.Windows.Forms.ColumnHeader descripcion;
        private System.Windows.Forms.ColumnHeader propietario;
        private System.Windows.Forms.ColumnHeader asignado;
    }
}