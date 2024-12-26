namespace presentacion
{
    partial class frmAltaArticulo
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
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtboxCodArt = new System.Windows.Forms.TextBox();
            this.txtboxModelo = new System.Windows.Forms.TextBox();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtboxUrlImagen = new System.Windows.Forms.TextBox();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.comboxMarca = new System.Windows.Forms.ComboBox();
            this.comboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.picboxImagenAlta = new System.Windows.Forms.PictureBox();
            this.btnGuardarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagenAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(26, 71);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(77, 13);
            this.lblCodArt.TabIndex = 0;
            this.lblCodArt.Text = "Código de Art.:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(26, 42);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(26, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 13);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(26, 130);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtboxCodArt
            // 
            this.txtboxCodArt.Location = new System.Drawing.Point(109, 68);
            this.txtboxCodArt.Name = "txtboxCodArt";
            this.txtboxCodArt.Size = new System.Drawing.Size(149, 20);
            this.txtboxCodArt.TabIndex = 5;
            // 
            // txtboxModelo
            // 
            this.txtboxModelo.Location = new System.Drawing.Point(109, 42);
            this.txtboxModelo.Name = "txtboxModelo";
            this.txtboxModelo.Size = new System.Drawing.Size(149, 20);
            this.txtboxModelo.TabIndex = 6;
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Location = new System.Drawing.Point(109, 97);
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(149, 20);
            this.txtboxDescripcion.TabIndex = 7;
            // 
            // txtboxUrlImagen
            // 
            this.txtboxUrlImagen.Location = new System.Drawing.Point(109, 156);
            this.txtboxUrlImagen.Name = "txtboxUrlImagen";
            this.txtboxUrlImagen.Size = new System.Drawing.Size(149, 20);
            this.txtboxUrlImagen.TabIndex = 8;
            this.txtboxUrlImagen.Leave += new System.EventHandler(this.txtboxUrlImagen_Leave);
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.Location = new System.Drawing.Point(109, 187);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(62, 20);
            this.txtboxPrecio.TabIndex = 9;
            // 
            // comboxMarca
            // 
            this.comboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxMarca.FormattingEnabled = true;
            this.comboxMarca.Location = new System.Drawing.Point(109, 13);
            this.comboxMarca.Name = "comboxMarca";
            this.comboxMarca.Size = new System.Drawing.Size(149, 21);
            this.comboxMarca.TabIndex = 10;
            // 
            // comboxCategoria
            // 
            this.comboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxCategoria.FormattingEnabled = true;
            this.comboxCategoria.Location = new System.Drawing.Point(109, 126);
            this.comboxCategoria.Name = "comboxCategoria";
            this.comboxCategoria.Size = new System.Drawing.Size(149, 21);
            this.comboxCategoria.TabIndex = 11;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(26, 159);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 190);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // picboxImagenAlta
            // 
            this.picboxImagenAlta.Location = new System.Drawing.Point(291, 21);
            this.picboxImagenAlta.Name = "picboxImagenAlta";
            this.picboxImagenAlta.Size = new System.Drawing.Size(156, 126);
            this.picboxImagenAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImagenAlta.TabIndex = 14;
            this.picboxImagenAlta.TabStop = false;
            // 
            // btnGuardarAlta
            // 
            this.btnGuardarAlta.Location = new System.Drawing.Point(291, 187);
            this.btnGuardarAlta.Name = "btnGuardarAlta";
            this.btnGuardarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlta.TabIndex = 15;
            this.btnGuardarAlta.Text = "Guardar";
            this.btnGuardarAlta.UseVisualStyleBackColor = true;
            this.btnGuardarAlta.Click += new System.EventHandler(this.btnGuardarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(372, 187);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAlta.TabIndex = 16;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 225);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.btnGuardarAlta);
            this.Controls.Add(this.picboxImagenAlta);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.comboxCategoria);
            this.Controls.Add(this.comboxMarca);
            this.Controls.Add(this.txtboxPrecio);
            this.Controls.Add(this.txtboxUrlImagen);
            this.Controls.Add(this.txtboxDescripcion);
            this.Controls.Add(this.txtboxModelo);
            this.Controls.Add(this.txtboxCodArt);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblCodArt);
            this.Name = "frmAltaArticulo";
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagenAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtboxCodArt;
        private System.Windows.Forms.TextBox txtboxModelo;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.TextBox txtboxUrlImagen;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.ComboBox comboxMarca;
        private System.Windows.Forms.ComboBox comboxCategoria;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox picboxImagenAlta;
        private System.Windows.Forms.Button btnGuardarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}