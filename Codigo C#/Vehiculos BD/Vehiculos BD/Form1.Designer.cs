namespace Vehiculos_BD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPrecioAlquilerPorDia = new System.Windows.Forms.TextBox();
            this.IblPrecioPorDia = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.IblPlaca = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(181, 272);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(592, 150);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(33, 272);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(34, 388);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 34);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar  ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(34, 331);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPrecioAlquilerPorDia
            // 
            this.txtPrecioAlquilerPorDia.Location = new System.Drawing.Point(401, 219);
            this.txtPrecioAlquilerPorDia.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioAlquilerPorDia.Name = "txtPrecioAlquilerPorDia";
            this.txtPrecioAlquilerPorDia.Size = new System.Drawing.Size(165, 20);
            this.txtPrecioAlquilerPorDia.TabIndex = 40;
            // 
            // IblPrecioPorDia
            // 
            this.IblPrecioPorDia.AutoSize = true;
            this.IblPrecioPorDia.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblPrecioPorDia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IblPrecioPorDia.Location = new System.Drawing.Point(297, 222);
            this.IblPrecioPorDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IblPrecioPorDia.Name = "IblPrecioPorDia";
            this.IblPrecioPorDia.Size = new System.Drawing.Size(103, 19);
            this.IblPrecioPorDia.TabIndex = 39;
            this.IblPrecioPorDia.Text = "PrecioPorDia:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(401, 189);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(165, 20);
            this.txtPlaca.TabIndex = 38;
            // 
            // IblPlaca
            // 
            this.IblPlaca.AutoSize = true;
            this.IblPlaca.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblPlaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IblPlaca.Location = new System.Drawing.Point(297, 190);
            this.IblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IblPlaca.Name = "IblPlaca";
            this.IblPlaca.Size = new System.Drawing.Size(49, 19);
            this.IblPlaca.TabIndex = 37;
            this.IblPlaca.Text = "Placa:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(401, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 20);
            this.txtId.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(297, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 19);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAño.Location = new System.Drawing.Point(297, 152);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(42, 19);
            this.lblAño.TabIndex = 35;
            this.lblAño.Text = "Año:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarca.Location = new System.Drawing.Point(297, 117);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 19);
            this.lblMarca.TabIndex = 34;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(297, 82);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(104, 19);
            this.lblTipoVehiculo.TabIndex = 31;
            this.lblTipoVehiculo.Text = "TipoVehiculo:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(401, 153);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(165, 20);
            this.txtAño.TabIndex = 33;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(401, 118);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(165, 20);
            this.txtMarca.TabIndex = 32;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Location = new System.Drawing.Point(401, 83);
            this.txtTipoVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(165, 20);
            this.txtTipoVehiculo.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecioAlquilerPorDia);
            this.Controls.Add(this.IblPrecioPorDia);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.IblPlaca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTipoVehiculo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVehiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPrecioAlquilerPorDia;
        private System.Windows.Forms.Label IblPrecioPorDia;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label IblPlaca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
    }
}

