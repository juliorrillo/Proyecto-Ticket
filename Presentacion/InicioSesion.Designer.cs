namespace Proyecto_Ticket.Presentacion
{
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
       private System.ComponentModel.IContainer components = null;
//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtUsuarioIngreso = new System.Windows.Forms.TextBox();
            this.txtPasswordIngreso = new System.Windows.Forms.TextBox();
            this.btnSalirIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(248)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Location = new System.Drawing.Point(37, 166);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(400, 62);
            this.btnIngreso.TabIndex = 4;
            this.btnIngreso.Text = "Login";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // txtUsuarioIngreso
            // 
            this.txtUsuarioIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuarioIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioIngreso.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIngreso.ForeColor = System.Drawing.Color.White;
            this.txtUsuarioIngreso.Location = new System.Drawing.Point(37, 52);
            this.txtUsuarioIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioIngreso.Name = "txtUsuarioIngreso";
            this.txtUsuarioIngreso.Size = new System.Drawing.Size(399, 33);
            this.txtUsuarioIngreso.TabIndex = 2;
            this.txtUsuarioIngreso.Text = "Usuario";
            this.txtUsuarioIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioIngreso.Enter += new System.EventHandler(this.TxtUsuarioIngreso_Enter);
            this.txtUsuarioIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioIngreso_KeyPress);
            this.txtUsuarioIngreso.Leave += new System.EventHandler(this.TxtUsuarioIngreso_Leave);
            // 
            // txtPasswordIngreso
            // 
            this.txtPasswordIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPasswordIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordIngreso.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordIngreso.ForeColor = System.Drawing.Color.White;
            this.txtPasswordIngreso.Location = new System.Drawing.Point(39, 112);
            this.txtPasswordIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordIngreso.Name = "txtPasswordIngreso";
            this.txtPasswordIngreso.Size = new System.Drawing.Size(399, 33);
            this.txtPasswordIngreso.TabIndex = 3;
            this.txtPasswordIngreso.Text = "Contraseña";
            this.txtPasswordIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordIngreso.Enter += new System.EventHandler(this.TxtPasswordIngreso_Enter);
            this.txtPasswordIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordIngreso_KeyPress);
            this.txtPasswordIngreso.Leave += new System.EventHandler(this.TxtPasswordIngreso_Leave);
            // 
            // btnSalirIngreso
            // 
            this.btnSalirIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSalirIngreso.FlatAppearance.BorderSize = 0;
            this.btnSalirIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirIngreso.Image")));
            this.btnSalirIngreso.Location = new System.Drawing.Point(436, 2);
            this.btnSalirIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalirIngreso.Name = "btnSalirIngreso";
            this.btnSalirIngreso.Size = new System.Drawing.Size(28, 25);
            this.btnSalirIngreso.TabIndex = 1;
            this.btnSalirIngreso.UseVisualStyleBackColor = false;
            this.btnSalirIngreso.Click += new System.EventHandler(this.BtnSalirIngreso_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(468, 258);
            this.Controls.Add(this.btnSalirIngreso);
            this.Controls.Add(this.txtPasswordIngreso);
            this.Controls.Add(this.txtUsuarioIngreso);
            this.Controls.Add(this.btnIngreso);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InicioSesion";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox txtUsuarioIngreso;
        private System.Windows.Forms.TextBox txtPasswordIngreso;
        private System.Windows.Forms.Button btnSalirIngreso;
    }
}