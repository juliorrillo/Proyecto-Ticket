namespace Proyecto_Ticket.Presentacion
{
    partial class PantallaTicket
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
            this.LvTickets = new System.Windows.Forms.ListView();
            this.lvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAsignado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFechaCarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFechaModificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbiertos = new System.Windows.Forms.Button();
            this.btnEnProgreso = new System.Windows.Forms.Button();
            this.btnResuelto = new System.Windows.Forms.Button();
            this.btnCerrados = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnNuevoTicket = new System.Windows.Forms.Button();
            this.btnEditarTicket = new System.Windows.Forms.Button();
            this.btnBorrarTicket = new System.Windows.Forms.Button();
            this.btnSalirTicket = new System.Windows.Forms.Button();
            this.btnTicketEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvTickets
            // 
            this.LvTickets.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvID,
            this.lvEstado,
            this.lvTitulo,
            this.lvDescripcion,
            this.lvArea,
            this.lvCategoria,
            this.lvObservaciones,
            this.lvUsuario,
            this.lvAsignado,
            this.lvFechaCarga,
            this.lvFechaModificacion});
            this.LvTickets.FullRowSelect = true;
            this.LvTickets.HideSelection = false;
            this.LvTickets.Location = new System.Drawing.Point(12, 97);
            this.LvTickets.Name = "LvTickets";
            this.LvTickets.Scrollable = false;
            this.LvTickets.Size = new System.Drawing.Size(1090, 510);
            this.LvTickets.TabIndex = 0;
            this.LvTickets.UseCompatibleStateImageBehavior = false;
            this.LvTickets.View = System.Windows.Forms.View.Details;
            this.LvTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvTickets_MouseDoubleClick);
            // 
            // lvID
            // 
            this.lvID.Text = "ID";
            this.lvID.Width = 0;
            // 
            // lvEstado
            // 
            this.lvEstado.Text = "Estado";
            this.lvEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEstado.Width = 65;
            // 
            // lvTitulo
            // 
            this.lvTitulo.Text = "Titulo";
            this.lvTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvTitulo.Width = 139;
            // 
            // lvDescripcion
            // 
            this.lvDescripcion.Text = "Descripcion";
            this.lvDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvDescripcion.Width = 177;
            // 
            // lvArea
            // 
            this.lvArea.Text = "Area";
            this.lvArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvArea.Width = 84;
            // 
            // lvCategoria
            // 
            this.lvCategoria.Text = "Categoria";
            this.lvCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvCategoria.Width = 107;
            // 
            // lvObservaciones
            // 
            this.lvObservaciones.Text = "Observaciones";
            this.lvObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvObservaciones.Width = 168;
            // 
            // lvUsuario
            // 
            this.lvUsuario.Text = "Usuario";
            this.lvUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvUsuario.Width = 96;
            // 
            // lvAsignado
            // 
            this.lvAsignado.Text = "Asignado A";
            this.lvAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvAsignado.Width = 92;
            // 
            // lvFechaCarga
            // 
            this.lvFechaCarga.Text = "Fecha Ingreso";
            this.lvFechaCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvFechaCarga.Width = 70;
            // 
            // lvFechaModificacion
            // 
            this.lvFechaModificacion.Text = "Modificacion";
            this.lvFechaModificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvFechaModificacion.Width = 84;
            // 
            // btnAbiertos
            // 
            this.btnAbiertos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbiertos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAbiertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAbiertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbiertos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbiertos.ForeColor = System.Drawing.Color.White;
            this.btnAbiertos.Location = new System.Drawing.Point(787, 66);
            this.btnAbiertos.Name = "btnAbiertos";
            this.btnAbiertos.Size = new System.Drawing.Size(67, 29);
            this.btnAbiertos.TabIndex = 1;
            this.btnAbiertos.Text = "Abierto";
            this.btnAbiertos.UseVisualStyleBackColor = true;
            this.btnAbiertos.Click += new System.EventHandler(this.BtnAbiertos_Click);
            // 
            // btnEnProgreso
            // 
            this.btnEnProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnProgreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnProgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnProgreso.ForeColor = System.Drawing.Color.White;
            this.btnEnProgreso.Location = new System.Drawing.Point(854, 66);
            this.btnEnProgreso.Name = "btnEnProgreso";
            this.btnEnProgreso.Size = new System.Drawing.Size(95, 29);
            this.btnEnProgreso.TabIndex = 2;
            this.btnEnProgreso.Text = "En Progreso";
            this.btnEnProgreso.UseVisualStyleBackColor = true;
            this.btnEnProgreso.Click += new System.EventHandler(this.BtnEnProgreso_Click);
            // 
            // btnResuelto
            // 
            this.btnResuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResuelto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnResuelto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnResuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResuelto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResuelto.ForeColor = System.Drawing.Color.White;
            this.btnResuelto.Location = new System.Drawing.Point(949, 66);
            this.btnResuelto.Name = "btnResuelto";
            this.btnResuelto.Size = new System.Drawing.Size(74, 29);
            this.btnResuelto.TabIndex = 3;
            this.btnResuelto.Text = "Resuelto";
            this.btnResuelto.UseVisualStyleBackColor = true;
            this.btnResuelto.Click += new System.EventHandler(this.BtnResuelto_Click);
            // 
            // btnCerrados
            // 
            this.btnCerrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrados.ForeColor = System.Drawing.Color.White;
            this.btnCerrados.Location = new System.Drawing.Point(1023, 66);
            this.btnCerrados.Name = "btnCerrados";
            this.btnCerrados.Size = new System.Drawing.Size(79, 29);
            this.btnCerrados.TabIndex = 4;
            this.btnCerrados.Text = "Cerrados";
            this.btnCerrados.UseVisualStyleBackColor = true;
            this.btnCerrados.Click += new System.EventHandler(this.BtnCerrados_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(717, 66);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(70, 29);
            this.btnTodos.TabIndex = 5;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // btnNuevoTicket
            // 
            this.btnNuevoTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevoTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTicket.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTicket.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoTicket.Name = "btnNuevoTicket";
            this.btnNuevoTicket.Size = new System.Drawing.Size(90, 64);
            this.btnNuevoTicket.TabIndex = 6;
            this.btnNuevoTicket.Text = "Nuevo";
            this.btnNuevoTicket.UseVisualStyleBackColor = true;
            this.btnNuevoTicket.Click += new System.EventHandler(this.BtnNuevoTicket_Click);
            // 
            // btnEditarTicket
            // 
            this.btnEditarTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTicket.ForeColor = System.Drawing.Color.White;
            this.btnEditarTicket.Location = new System.Drawing.Point(106, 12);
            this.btnEditarTicket.Name = "btnEditarTicket";
            this.btnEditarTicket.Size = new System.Drawing.Size(90, 64);
            this.btnEditarTicket.TabIndex = 7;
            this.btnEditarTicket.Text = "Editar";
            this.btnEditarTicket.UseVisualStyleBackColor = true;
            this.btnEditarTicket.Click += new System.EventHandler(this.BtnEditarTicket_Click);
            // 
            // btnBorrarTicket
            // 
            this.btnBorrarTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBorrarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBorrarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTicket.ForeColor = System.Drawing.Color.White;
            this.btnBorrarTicket.Location = new System.Drawing.Point(201, 12);
            this.btnBorrarTicket.Name = "btnBorrarTicket";
            this.btnBorrarTicket.Size = new System.Drawing.Size(90, 64);
            this.btnBorrarTicket.TabIndex = 8;
            this.btnBorrarTicket.Text = "Borrar";
            this.btnBorrarTicket.UseVisualStyleBackColor = true;
            this.btnBorrarTicket.Click += new System.EventHandler(this.BtnBorrarTicket_Click);
            // 
            // btnSalirTicket
            // 
            this.btnSalirTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalirTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirTicket.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirTicket.ForeColor = System.Drawing.Color.White;
            this.btnSalirTicket.Location = new System.Drawing.Point(1013, 10);
            this.btnSalirTicket.Name = "btnSalirTicket";
            this.btnSalirTicket.Size = new System.Drawing.Size(82, 34);
            this.btnSalirTicket.TabIndex = 9;
            this.btnSalirTicket.Text = "Salir";
            this.btnSalirTicket.UseVisualStyleBackColor = true;
            this.btnSalirTicket.Click += new System.EventHandler(this.BtnSalirTicket_Click);
            // 
            // btnTicketEstado
            // 
            this.btnTicketEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTicketEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTicketEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketEstado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketEstado.ForeColor = System.Drawing.Color.White;
            this.btnTicketEstado.Location = new System.Drawing.Point(297, 12);
            this.btnTicketEstado.Name = "btnTicketEstado";
            this.btnTicketEstado.Size = new System.Drawing.Size(90, 64);
            this.btnTicketEstado.TabIndex = 10;
            this.btnTicketEstado.Text = "Estado";
            this.btnTicketEstado.UseVisualStyleBackColor = true;
            this.btnTicketEstado.Click += new System.EventHandler(this.BtnTicketEstado_Click);
            // 
            // PantallaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1114, 611);
            this.Controls.Add(this.btnTicketEstado);
            this.Controls.Add(this.btnSalirTicket);
            this.Controls.Add(this.btnBorrarTicket);
            this.Controls.Add(this.btnEditarTicket);
            this.Controls.Add(this.btnNuevoTicket);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnCerrados);
            this.Controls.Add(this.btnResuelto);
            this.Controls.Add(this.btnEnProgreso);
            this.Controls.Add(this.btnAbiertos);
            this.Controls.Add(this.LvTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PantallaTicket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaTicket_FormClosed);
            this.Load += new System.EventHandler(this.PantallaTicket_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvTickets;
        private System.Windows.Forms.ColumnHeader lvID;
        private System.Windows.Forms.ColumnHeader lvTitulo;
        private System.Windows.Forms.ColumnHeader lvDescripcion;
        private System.Windows.Forms.ColumnHeader lvEstado;
        private System.Windows.Forms.ColumnHeader lvArea;
        private System.Windows.Forms.ColumnHeader lvCategoria;
        private System.Windows.Forms.ColumnHeader lvObservaciones;
        private System.Windows.Forms.ColumnHeader lvUsuario;
        private System.Windows.Forms.ColumnHeader lvFechaCarga;
        private System.Windows.Forms.ColumnHeader lvFechaModificacion;
        private System.Windows.Forms.Button btnAbiertos;
        private System.Windows.Forms.Button btnEnProgreso;
        private System.Windows.Forms.Button btnResuelto;
        private System.Windows.Forms.Button btnCerrados;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnNuevoTicket;
        private System.Windows.Forms.Button btnEditarTicket;
        private System.Windows.Forms.Button btnBorrarTicket;
        private System.Windows.Forms.Button btnSalirTicket;
        private System.Windows.Forms.ColumnHeader lvAsignado;
        private System.Windows.Forms.Button btnTicketEstado;
    }
}