namespace pryArroyoLisandro_Biblioteca
{
    partial class frmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtCodigoDistribuidor = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.cmdAvanzar = new System.Windows.Forms.Button();
            this.cmdRetroceder = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.AutoSize = true;
            this.lblCodigoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(12, 233);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(143, 20);
            this.lblCodigoDistribuidor.TabIndex = 1;
            this.lblCodigoDistribuidor.Text = "Codigo Distribuidor";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(12, 177);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(102, 20);
            this.lblCodigoAutor.TabIndex = 2;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(12, 121);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(120, 20);
            this.lblCodigoEditorial.TabIndex = 3;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(12, 65);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(104, 20);
            this.lblNombreLibro.TabIndex = 4;
            this.lblNombreLibro.Text = "Nombre Libro";
            // 
            // txtCodigoDistribuidor
            // 
            this.txtCodigoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDistribuidor.Location = new System.Drawing.Point(161, 227);
            this.txtCodigoDistribuidor.Name = "txtCodigoDistribuidor";
            this.txtCodigoDistribuidor.ReadOnly = true;
            this.txtCodigoDistribuidor.Size = new System.Drawing.Size(186, 26);
            this.txtCodigoDistribuidor.TabIndex = 6;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAutor.Location = new System.Drawing.Point(161, 171);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.ReadOnly = true;
            this.txtCodigoAutor.Size = new System.Drawing.Size(57, 26);
            this.txtCodigoAutor.TabIndex = 7;
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEditorial.Location = new System.Drawing.Point(161, 115);
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.ReadOnly = true;
            this.txtCodigoEditorial.Size = new System.Drawing.Size(186, 26);
            this.txtCodigoEditorial.TabIndex = 8;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(161, 59);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(322, 26);
            this.txtNombreLibro.TabIndex = 9;
            // 
            // cmdAvanzar
            // 
            this.cmdAvanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAvanzar.Location = new System.Drawing.Point(408, 283);
            this.cmdAvanzar.Name = "cmdAvanzar";
            this.cmdAvanzar.Size = new System.Drawing.Size(75, 33);
            this.cmdAvanzar.TabIndex = 10;
            this.cmdAvanzar.Text = ">>";
            this.cmdAvanzar.UseVisualStyleBackColor = true;
            this.cmdAvanzar.Click += new System.EventHandler(this.cmdAvanzar_Click);
            // 
            // cmdRetroceder
            // 
            this.cmdRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRetroceder.Location = new System.Drawing.Point(302, 283);
            this.cmdRetroceder.Name = "cmdRetroceder";
            this.cmdRetroceder.Size = new System.Drawing.Size(75, 33);
            this.cmdRetroceder.TabIndex = 11;
            this.cmdRetroceder.Text = "<<";
            this.cmdRetroceder.UseVisualStyleBackColor = true;
            this.cmdRetroceder.Click += new System.EventHandler(this.cmdRetroceder_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(161, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(57, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 328);
            this.Controls.Add(this.cmdRetroceder);
            this.Controls.Add(this.cmdAvanzar);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtCodigoEditorial);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtCodigoDistribuidor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoDistribuidor;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Button cmdAvanzar;
        private System.Windows.Forms.Button cmdRetroceder;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

