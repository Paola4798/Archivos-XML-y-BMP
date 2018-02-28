namespace bmp_y_xml
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenBmp = new System.Windows.Forms.Button();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblLdN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtLdN = new System.Windows.Forms.TextBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.txtBmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenBmp
            // 
            this.btnOpenBmp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBmp.Location = new System.Drawing.Point(205, 34);
            this.btnOpenBmp.Name = "btnOpenBmp";
            this.btnOpenBmp.Size = new System.Drawing.Size(110, 51);
            this.btnOpenBmp.TabIndex = 1;
            this.btnOpenBmp.Text = "Datos";
            this.btnOpenBmp.UseVisualStyleBackColor = true;
            this.btnOpenBmp.Click += new System.EventHandler(this.btnOpenBmp_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.Location = new System.Drawing.Point(378, 15);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(71, 20);
            this.lblAgenda.TabIndex = 2;
            this.lblAgenda.Text = "Agenda";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(394, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(412, 81);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 16);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(387, 106);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(384, 136);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(77, 16);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblLdN
            // 
            this.lblLdN.AutoSize = true;
            this.lblLdN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLdN.Location = new System.Drawing.Point(306, 161);
            this.lblLdN.Name = "lblLdN";
            this.lblLdN.Size = new System.Drawing.Size(155, 16);
            this.lblLdN.TabIndex = 7;
            this.lblLdN.Text = "Lugar de Nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(467, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(467, 77);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(244, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(467, 102);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(244, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(467, 132);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(244, 20);
            this.txtDomicilio.TabIndex = 11;
            // 
            // txtLdN
            // 
            this.txtLdN.Location = new System.Drawing.Point(467, 161);
            this.txtLdN.Name = "txtLdN";
            this.txtLdN.Size = new System.Drawing.Size(244, 20);
            this.txtLdN.TabIndex = 12;
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(692, 196);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(102, 33);
            this.btnXML.TabIndex = 13;
            this.btnXML.Text = "Save";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // txtBmp
            // 
            this.txtBmp.Location = new System.Drawing.Point(12, 21);
            this.txtBmp.Multiline = true;
            this.txtBmp.Name = "txtBmp";
            this.txtBmp.Size = new System.Drawing.Size(189, 212);
            this.txtBmp.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 245);
            this.Controls.Add(this.txtBmp);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.txtLdN);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLdN);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.btnOpenBmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenBmp;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblLdN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtLdN;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.TextBox txtBmp;
    }
}

