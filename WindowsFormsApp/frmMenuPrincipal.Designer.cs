namespace WindowsFormsApp
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnListado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbcatalogo = new System.Windows.Forms.Label();
            this.panelopciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelopciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnListado.FlatAppearance.BorderSize = 0;
            this.btnListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListado.Location = new System.Drawing.Point(4, 126);
            this.btnListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(291, 49);
            this.btnListado.TabIndex = 0;
            this.btnListado.Text = "Listado de Articulos";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(0, 404);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(295, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(0, 266);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(295, 48);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Articulo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbcatalogo
            // 
            this.lbcatalogo.AutoSize = true;
            this.lbcatalogo.BackColor = System.Drawing.Color.Transparent;
            this.lbcatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbcatalogo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcatalogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcatalogo.Location = new System.Drawing.Point(417, 23);
            this.lbcatalogo.Name = "lbcatalogo";
            this.lbcatalogo.Size = new System.Drawing.Size(330, 29);
            this.lbcatalogo.TabIndex = 5;
            this.lbcatalogo.Text = "CATALOGO DE ARTICULOS";
            // 
            // panelopciones
            // 
            this.panelopciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelopciones.Controls.Add(this.btnListado);
            this.panelopciones.Controls.Add(this.btnBuscar);
            this.panelopciones.Controls.Add(this.btnAgregar);
            this.panelopciones.Location = new System.Drawing.Point(0, 60);
            this.panelopciones.Name = "panelopciones";
            this.panelopciones.Size = new System.Drawing.Size(295, 591);
            this.panelopciones.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbcatalogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 63);
            this.panel1.TabIndex = 7;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1063, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelopciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.panelopciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbcatalogo;
        private System.Windows.Forms.Panel panelopciones;
        private System.Windows.Forms.Panel panel1;
    }
}