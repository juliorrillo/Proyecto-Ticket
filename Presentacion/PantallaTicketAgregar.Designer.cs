namespace Proyecto_Ticket.Presentacion
{
    partial class PantallaTicketAgregar
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
            this.txtTicketTitulo = new System.Windows.Forms.TextBox();
            this.txtTicketDetalle = new System.Windows.Forms.TextBox();
            this.cbTicketArea = new System.Windows.Forms.ComboBox();
            this.cbTicketCategoria = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtTicketDescripcion = new System.Windows.Forms.TextBox();
            this.cbTicketTecnico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTicketTecnico = new System.Windows.Forms.TextBox();
            this.txtTicketUsuario = new System.Windows.Forms.TextBox();
            this.btnSalirAgregarTicket = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTicketTitulo
            // 
            this.txtTicketTitulo.Location = new System.Drawing.Point(158, 19);
            this.txtTicketTitulo.Name = "txtTicketTitulo";
            this.txtTicketTitulo.Size = new System.Drawing.Size(333, 20);
            this.txtTicketTitulo.TabIndex = 4;
            // 
            // txtTicketDetalle
            // 
            this.txtTicketDetalle.Location = new System.Drawing.Point(158, 61);
            this.txtTicketDetalle.Multiline = true;
            this.txtTicketDetalle.Name = "txtTicketDetalle";
            this.txtTicketDetalle.Size = new System.Drawing.Size(333, 160);
            this.txtTicketDetalle.TabIndex = 5;
            // 
            // cbTicketArea
            // 
            this.cbTicketArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketArea.FormattingEnabled = true;
            this.cbTicketArea.Items.AddRange(new object[] {
            "Administracion",
            "Tesoreria",
            "Contabilidad",
            "Costos",
            "Recepcion",
            "Diseño",
            "Producto",
            "Sistemas"});
            this.cbTicketArea.Location = new System.Drawing.Point(158, 246);
            this.cbTicketArea.Name = "cbTicketArea";
            this.cbTicketArea.Size = new System.Drawing.Size(333, 21);
            this.cbTicketArea.TabIndex = 6;
            // 
            // cbTicketCategoria
            // 
            this.cbTicketCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketCategoria.FormattingEnabled = true;
            this.cbTicketCategoria.Items.AddRange(new object[] {
            "Impresoras",
            "Redes",
            "Configuracion",
            "Hardware",
            "Telefonos IP",
            "Desarrollo",
            "Nuevas Funcionalidad",
            "Coccion De Datos",
            "Reportes",
            "OTRO"});
            this.cbTicketCategoria.Location = new System.Drawing.Point(158, 294);
            this.cbTicketCategoria.Name = "cbTicketCategoria";
            this.cbTicketCategoria.Size = new System.Drawing.Size(333, 21);
            this.cbTicketCategoria.TabIndex = 7;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Abierto",
            "En Progreso",
            "Resuelto",
            "Cerrado"});
            this.cbEstado.Location = new System.Drawing.Point(95, 10);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(209, 21);
            this.cbEstado.TabIndex = 1;
            // 
            // txtTicketDescripcion
            // 
            this.txtTicketDescripcion.Location = new System.Drawing.Point(158, 344);
            this.txtTicketDescripcion.Multiline = true;
            this.txtTicketDescripcion.Name = "txtTicketDescripcion";
            this.txtTicketDescripcion.Size = new System.Drawing.Size(333, 160);
            this.txtTicketDescripcion.TabIndex = 8;
            // 
            // cbTicketTecnico
            // 
            this.cbTicketTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketTecnico.FormattingEnabled = true;
            this.cbTicketTecnico.Location = new System.Drawing.Point(158, 574);
            this.cbTicketTecnico.Name = "cbTicketTecnico";
            this.cbTicketTecnico.Size = new System.Drawing.Size(333, 21);
            this.cbTicketTecnico.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalle:";
            // 
            // cbArea
            // 
            this.cbArea.AutoSize = true;
            this.cbArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.ForeColor = System.Drawing.Color.White;
            this.cbArea.Location = new System.Drawing.Point(31, 246);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(53, 21);
            this.cbArea.TabIndex = 10;
            this.cbArea.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Asignado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado:";
            // 
            // btnAgregarTicket
            // 
            this.btnAgregarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTicket.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTicket.Location = new System.Drawing.Point(83, 666);
            this.btnAgregarTicket.Name = "btnAgregarTicket";
            this.btnAgregarTicket.Size = new System.Drawing.Size(154, 33);
            this.btnAgregarTicket.TabIndex = 11;
            this.btnAgregarTicket.Text = "Aceptar";
            this.btnAgregarTicket.UseVisualStyleBackColor = true;
            this.btnAgregarTicket.Click += new System.EventHandler(this.BtnAgregarTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTicketTecnico);
            this.groupBox1.Controls.Add(this.txtTicketUsuario);
            this.groupBox1.Controls.Add(this.txtTicketTitulo);
            this.groupBox1.Controls.Add(this.txtTicketDetalle);
            this.groupBox1.Controls.Add(this.cbTicketArea);
            this.groupBox1.Controls.Add(this.cbTicketCategoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTicketDescripcion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTicketTecnico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 613);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txtTicketTecnico
            // 
            this.txtTicketTecnico.Location = new System.Drawing.Point(158, 574);
            this.txtTicketTecnico.Name = "txtTicketTecnico";
            this.txtTicketTecnico.Size = new System.Drawing.Size(333, 20);
            this.txtTicketTecnico.TabIndex = 16;
            this.txtTicketTecnico.Visible = false;
            // 
            // txtTicketUsuario
            // 
            this.txtTicketUsuario.Location = new System.Drawing.Point(158, 527);
            this.txtTicketUsuario.Name = "txtTicketUsuario";
            this.txtTicketUsuario.Size = new System.Drawing.Size(333, 20);
            this.txtTicketUsuario.TabIndex = 15;
            // 
            // btnSalirAgregarTicket
            // 
            this.btnSalirAgregarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAgregarTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAgregarTicket.ForeColor = System.Drawing.Color.White;
            this.btnSalirAgregarTicket.Location = new System.Drawing.Point(308, 667);
            this.btnSalirAgregarTicket.Name = "btnSalirAgregarTicket";
            this.btnSalirAgregarTicket.Size = new System.Drawing.Size(154, 33);
            this.btnSalirAgregarTicket.TabIndex = 12;
            this.btnSalirAgregarTicket.Text = "Salir";
            this.btnSalirAgregarTicket.UseVisualStyleBackColor = true;
            this.btnSalirAgregarTicket.Click += new System.EventHandler(this.BtnSalirAgregarTicket_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // PantallaTicketAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(538, 711);
            this.Controls.Add(this.btnSalirAgregarTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaTicketAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaTicketAgregar";
            this.Load += new System.EventHandler(this.PantallaTicketAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketTitulo;
        private System.Windows.Forms.TextBox txtTicketDetalle;
        private System.Windows.Forms.ComboBox cbTicketArea;
        private System.Windows.Forms.ComboBox cbTicketCategoria;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtTicketDescripcion;
        private System.Windows.Forms.ComboBox cbTicketTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalirAgregarTicket;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TextBox txtTicketUsuario;
        private System.Windows.Forms.TextBox txtTicketTecnico;
    }
}