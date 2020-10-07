namespace WindowsFormsApp
{
    partial class FMAgregar
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
            this.lbCodigoArt = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbimagen = new System.Windows.Forms.Label();
            this.lbprecio = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.btaceptar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigoArt
            // 
            this.lbCodigoArt.AutoSize = true;
            this.lbCodigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArt.Location = new System.Drawing.Point(99, 54);
            this.lbCodigoArt.Name = "lbCodigoArt";
            this.lbCodigoArt.Size = new System.Drawing.Size(63, 20);
            this.lbCodigoArt.TabIndex = 0;
            this.lbCodigoArt.Text = "Codigo:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(93, 97);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Location = new System.Drawing.Point(66, 140);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(96, 20);
            this.lbdescripcion.TabIndex = 2;
            this.lbdescripcion.Text = "Descripcion:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(105, 186);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(57, 20);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(81, 234);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(82, 20);
            this.lbCategoria.TabIndex = 4;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbimagen
            // 
            this.lbimagen.AutoSize = true;
            this.lbimagen.Location = new System.Drawing.Point(38, 285);
            this.lbimagen.Name = "lbimagen";
            this.lbimagen.Size = new System.Drawing.Size(126, 20);
            this.lbimagen.TabIndex = 5;
            this.lbimagen.Text = "URL de Imagen:";
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.Location = new System.Drawing.Point(105, 346);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(57, 20);
            this.lbprecio.TabIndex = 6;
            this.lbprecio.Text = "Precio:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(246, 49);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(180, 26);
            this.txtcodigo.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(246, 92);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 26);
            this.txtnombre.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(246, 135);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(180, 26);
            this.txtdescripcion.TabIndex = 9;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(246, 280);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(180, 26);
            this.txtimagen.TabIndex = 10;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(246, 342);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(180, 26);
            this.txtprecio.TabIndex = 11;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // cbmarca
            // 
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(246, 182);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(180, 28);
            this.cbmarca.TabIndex = 12;
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(246, 229);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(180, 28);
            this.cbcategoria.TabIndex = 13;
            // 
            // btaceptar
            // 
            this.btaceptar.BackColor = System.Drawing.Color.SlateGray;
            this.btaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaceptar.Location = new System.Drawing.Point(140, 414);
            this.btaceptar.Name = "btaceptar";
            this.btaceptar.Size = new System.Drawing.Size(86, 38);
            this.btaceptar.TabIndex = 14;
            this.btaceptar.Text = "Aceptar";
            this.btaceptar.UseVisualStyleBackColor = false;
            this.btaceptar.Click += new System.EventHandler(this.btaceptar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Location = new System.Drawing.Point(296, 414);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(89, 38);
            this.btcancelar.TabIndex = 15;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // FMAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(548, 489);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btaceptar);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.lbimagen);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbdescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigoArt);
            this.Name = "FMAgregar";
            this.Text = "FMAgregar";
            this.Load += new System.EventHandler(this.FMAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoArt;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbdescripcion;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbimagen;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btaceptar;
        private System.Windows.Forms.Button btcancelar;
    }
}