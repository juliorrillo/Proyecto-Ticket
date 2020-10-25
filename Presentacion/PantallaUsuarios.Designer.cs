namespace Proyecto_Ticket.Presentacion
{
    partial class PantallaUsuarios
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.lvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvID,
            this.lvNombre,
            this.lvApellido,
            this.lvCorreo,
            this.lvTelefono,
            this.lvArea,
            this.lvCategoria,
            this.lvUser,
            this.lvPass});
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvUsuarios.Location = new System.Drawing.Point(8, 12);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(708, 534);
            this.lvUsuarios.TabIndex = 0;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            this.lvUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvUsuarios_MouseDoubleClick);
            // 
            // lvID
            // 
            this.lvID.Text = "ID";
            this.lvID.Width = 32;
            // 
            // lvNombre
            // 
            this.lvNombre.Text = "Nombre";
            this.lvNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvNombre.Width = 94;
            // 
            // lvApellido
            // 
            this.lvApellido.Text = "Apellido";
            this.lvApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvApellido.Width = 80;
            // 
            // lvCorreo
            // 
            this.lvCorreo.Text = "Correo";
            this.lvCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvCorreo.Width = 127;
            // 
            // lvTelefono
            // 
            this.lvTelefono.Text = "Telefono";
            this.lvTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvTelefono.Width = 95;
            // 
            // lvArea
            // 
            this.lvArea.Text = "Area";
            this.lvArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvArea.Width = 77;
            // 
            // lvCategoria
            // 
            this.lvCategoria.Text = "Categoria";
            this.lvCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvCategoria.Width = 100;
            // 
            // lvUser
            // 
            this.lvUser.Text = "Usuario";
            this.lvUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvUser.Width = 61;
            // 
            // lvPass
            // 
            this.lvPass.Text = "Contraseña";
            this.lvPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.bntAgregar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(722, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 541);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(6, 102);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(137, 40);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(6, 56);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // bntAgregar
            // 
            this.bntAgregar.FlatAppearance.BorderSize = 0;
            this.bntAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bntAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bntAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAgregar.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.bntAgregar.ForeColor = System.Drawing.Color.White;
            this.bntAgregar.Location = new System.Drawing.Point(6, 10);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(137, 40);
            this.bntAgregar.TabIndex = 3;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.BntAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(6, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PantallaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(880, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaUsuarios";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaUsuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.PantallaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.ColumnHeader lvID;
        private System.Windows.Forms.ColumnHeader lvNombre;
        private System.Windows.Forms.ColumnHeader lvApellido;
        private System.Windows.Forms.ColumnHeader lvCorreo;
        private System.Windows.Forms.ColumnHeader lvTelefono;
        private System.Windows.Forms.ColumnHeader lvArea;
        private System.Windows.Forms.ColumnHeader lvCategoria;
        private System.Windows.Forms.ColumnHeader lvUser;
        private System.Windows.Forms.ColumnHeader lvPass;
    }
}