namespace WindowsFormsApp
{
    partial class frmBuscar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.panelbuscar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.panelbuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(4, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(231, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBuscar.Location = new System.Drawing.Point(42, 66);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 35);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(306, 73);
            this.dgvBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 62;
            this.dgvBuscar.Size = new System.Drawing.Size(663, 258);
            this.dgvBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuscar.Location = new System.Drawing.Point(59, 34);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(135, 18);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Ingrese el Codigo:";
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btmodificar.FlatAppearance.BorderSize = 0;
            this.btmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmodificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmodificar.Location = new System.Drawing.Point(0, 223);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(235, 32);
            this.btmodificar.TabIndex = 4;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = false;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bteliminar.FlatAppearance.BorderSize = 0;
            this.bteliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteliminar.Location = new System.Drawing.Point(0, 294);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(235, 35);
            this.bteliminar.TabIndex = 6;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // panelbuscar
            // 
            this.panelbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelbuscar.Controls.Add(this.lblBuscar);
            this.panelbuscar.Controls.Add(this.bteliminar);
            this.panelbuscar.Controls.Add(this.txtBuscar);
            this.panelbuscar.Controls.Add(this.btmodificar);
            this.panelbuscar.Controls.Add(this.btnBuscar);
            this.panelbuscar.Location = new System.Drawing.Point(-1, 2);
            this.panelbuscar.Name = "panelbuscar";
            this.panelbuscar.Size = new System.Drawing.Size(235, 443);
            this.panelbuscar.TabIndex = 7;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1023, 446);
            this.Controls.Add(this.panelbuscar);
            this.Controls.Add(this.dgvBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBuscar";
            this.Text = "Buscar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.panelbuscar.ResumeLayout(false);
            this.panelbuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Panel panelbuscar;
    }
}