namespace Pintureria
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFecCom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabArticulo = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.picErrorDescr = new System.Windows.Forms.PictureBox();
            this.picErrorCodArt = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPagCosto = new System.Windows.Forms.TabPage();
            this.picErrorPreLista = new System.Windows.Forms.PictureBox();
            this.grCosto = new System.Windows.Forms.GroupBox();
            this.btnEliminarCol = new System.Windows.Forms.Button();
            this.txtPorDesRec = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgCosto = new System.Windows.Forms.DataGridView();
            this.colPrecLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgrDescRec = new System.Windows.Forms.Button();
            this.txtDescDescRec = new System.Windows.Forms.TextBox();
            this.cboDescRec = new System.Windows.Forms.ComboBox();
            this.txtPreLista = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPreFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lvlIva = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.tabArticulo.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorDescr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCodArt)).BeginInit();
            this.tabPagCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorPreLista)).BeginInit();
            this.grCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Código:";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodArticulo.Location = new System.Drawing.Point(135, 26);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(121, 22);
            this.txtCodArticulo.TabIndex = 0;
            this.txtCodArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodArticulo_KeyDown);
            this.txtCodArticulo.Leave += new System.EventHandler(this.txtCodArticulo_Leave);
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(135, 51);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(283, 22);
            this.txtDescr.TabIndex = 1;
            this.txtDescr.Leave += new System.EventHandler(this.txtDescr_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rubro:";
            // 
            // cboRubro
            // 
            this.cboRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(135, 77);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(121, 24);
            this.cboRubro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(135, 105);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 24);
            this.cboMarca.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(135, 160);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(158, 22);
            this.txtProveedor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ubicación:";
            // 
            // cboUnidad
            // 
            this.cboUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(135, 133);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(121, 24);
            this.cboUnidad.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(67, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unidad:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(135, 187);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(233, 22);
            this.txtUbicacion.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 16;
            // 
            // txtFecCom
            // 
            this.txtFecCom.Location = new System.Drawing.Point(464, 50);
            this.txtFecCom.Name = "txtFecCom";
            this.txtFecCom.Size = new System.Drawing.Size(245, 22);
            this.txtFecCom.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(529, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "FechaCompra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(78, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Stock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Stock Min:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "*Precio de lista:";
            // 
            // tabArticulo
            // 
            this.tabArticulo.Controls.Add(this.tabPageGeneral);
            this.tabArticulo.Controls.Add(this.tabPagCosto);
            this.tabArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArticulo.Location = new System.Drawing.Point(12, 29);
            this.tabArticulo.Name = "tabArticulo";
            this.tabArticulo.SelectedIndex = 0;
            this.tabArticulo.Size = new System.Drawing.Size(785, 309);
            this.tabArticulo.TabIndex = 36;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageGeneral.Controls.Add(this.picErrorDescr);
            this.tabPageGeneral.Controls.Add(this.picErrorCodArt);
            this.tabPageGeneral.Controls.Add(this.btnBuscar);
            this.tabPageGeneral.Controls.Add(this.txtStockMin);
            this.tabPageGeneral.Controls.Add(this.txtStock);
            this.tabPageGeneral.Controls.Add(this.txtObservacion);
            this.tabPageGeneral.Controls.Add(this.label19);
            this.tabPageGeneral.Controls.Add(this.label3);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.txtCodArticulo);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.txtDescr);
            this.tabPageGeneral.Controls.Add(this.cboRubro);
            this.tabPageGeneral.Controls.Add(this.label4);
            this.tabPageGeneral.Controls.Add(this.cboMarca);
            this.tabPageGeneral.Controls.Add(this.label5);
            this.tabPageGeneral.Controls.Add(this.txtProveedor);
            this.tabPageGeneral.Controls.Add(this.label6);
            this.tabPageGeneral.Controls.Add(this.label7);
            this.tabPageGeneral.Controls.Add(this.cboUnidad);
            this.tabPageGeneral.Controls.Add(this.label11);
            this.tabPageGeneral.Controls.Add(this.txtUbicacion);
            this.tabPageGeneral.Controls.Add(this.label12);
            this.tabPageGeneral.Controls.Add(this.label8);
            this.tabPageGeneral.Controls.Add(this.txtFecCom);
            this.tabPageGeneral.Controls.Add(this.label10);
            this.tabPageGeneral.Controls.Add(this.label9);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(777, 280);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            // 
            // picErrorDescr
            // 
            this.picErrorDescr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picErrorDescr.BackgroundImage")));
            this.picErrorDescr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picErrorDescr.Location = new System.Drawing.Point(423, 52);
            this.picErrorDescr.Name = "picErrorDescr";
            this.picErrorDescr.Size = new System.Drawing.Size(23, 21);
            this.picErrorDescr.TabIndex = 97;
            this.picErrorDescr.TabStop = false;
            this.picErrorDescr.Visible = false;
            // 
            // picErrorCodArt
            // 
            this.picErrorCodArt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picErrorCodArt.BackgroundImage")));
            this.picErrorCodArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picErrorCodArt.Location = new System.Drawing.Point(260, 25);
            this.picErrorCodArt.Name = "picErrorCodArt";
            this.picErrorCodArt.Size = new System.Drawing.Size(23, 21);
            this.picErrorCodArt.TabIndex = 96;
            this.picErrorCodArt.TabStop = false;
            this.picErrorCodArt.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = global::Pintureria.Properties.Resources.Lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(299, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 25);
            this.btnBuscar.TabIndex = 95;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtStockMin
            // 
            this.txtStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.Location = new System.Drawing.Point(281, 218);
            this.txtStockMin.MaxLength = 10;
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(68, 22);
            this.txtStockMin.TabIndex = 8;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(136, 218);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(68, 22);
            this.txtStock.TabIndex = 7;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(423, 125);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(322, 108);
            this.txtObservacion.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(530, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 16);
            this.label19.TabIndex = 24;
            this.label19.Text = "Observación:";
            // 
            // tabPagCosto
            // 
            this.tabPagCosto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPagCosto.Controls.Add(this.picErrorPreLista);
            this.tabPagCosto.Controls.Add(this.grCosto);
            this.tabPagCosto.Controls.Add(this.txtPreLista);
            this.tabPagCosto.Controls.Add(this.label17);
            this.tabPagCosto.Controls.Add(this.txtPreFinal);
            this.tabPagCosto.Controls.Add(this.label13);
            this.tabPagCosto.Controls.Add(this.label14);
            this.tabPagCosto.Controls.Add(this.txtIva);
            this.tabPagCosto.Controls.Add(this.lvlIva);
            this.tabPagCosto.Controls.Add(this.txtGanancia);
            this.tabPagCosto.Location = new System.Drawing.Point(4, 25);
            this.tabPagCosto.Name = "tabPagCosto";
            this.tabPagCosto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCosto.Size = new System.Drawing.Size(777, 280);
            this.tabPagCosto.TabIndex = 1;
            this.tabPagCosto.Text = "Costo Calculado";
            // 
            // picErrorPreLista
            // 
            this.picErrorPreLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picErrorPreLista.BackgroundImage")));
            this.picErrorPreLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picErrorPreLista.Location = new System.Drawing.Point(289, 13);
            this.picErrorPreLista.Name = "picErrorPreLista";
            this.picErrorPreLista.Size = new System.Drawing.Size(23, 21);
            this.picErrorPreLista.TabIndex = 81;
            this.picErrorPreLista.TabStop = false;
            this.picErrorPreLista.Visible = false;
            // 
            // grCosto
            // 
            this.grCosto.Controls.Add(this.btnEliminarCol);
            this.grCosto.Controls.Add(this.txtPorDesRec);
            this.grCosto.Controls.Add(this.label15);
            this.grCosto.Controls.Add(this.dgCosto);
            this.grCosto.Controls.Add(this.btnAgrDescRec);
            this.grCosto.Controls.Add(this.txtDescDescRec);
            this.grCosto.Controls.Add(this.cboDescRec);
            this.grCosto.Enabled = false;
            this.grCosto.Location = new System.Drawing.Point(29, 68);
            this.grCosto.Name = "grCosto";
            this.grCosto.Size = new System.Drawing.Size(742, 129);
            this.grCosto.TabIndex = 40;
            this.grCosto.TabStop = false;
            // 
            // btnEliminarCol
            // 
            this.btnEliminarCol.BackgroundImage = global::Pintureria.Properties.Resources.deshacer1;
            this.btnEliminarCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarCol.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarCol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCol.Location = new System.Drawing.Point(694, 56);
            this.btnEliminarCol.Name = "btnEliminarCol";
            this.btnEliminarCol.Size = new System.Drawing.Size(35, 34);
            this.btnEliminarCol.TabIndex = 91;
            this.btnEliminarCol.UseVisualStyleBackColor = true;
            this.btnEliminarCol.Click += new System.EventHandler(this.btnEliminarCol_Click);
            // 
            // txtPorDesRec
            // 
            this.txtPorDesRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorDesRec.Location = new System.Drawing.Point(303, 14);
            this.txtPorDesRec.Name = "txtPorDesRec";
            this.txtPorDesRec.Size = new System.Drawing.Size(50, 22);
            this.txtPorDesRec.TabIndex = 15;
            this.txtPorDesRec.TabStop = false;
            this.txtPorDesRec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 89;
            this.label15.Text = "%";
            // 
            // dgCosto
            // 
            this.dgCosto.AllowUserToAddRows = false;
            this.dgCosto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCosto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCosto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrecLista,
            this.colSinIva,
            this.colConIva});
            this.dgCosto.Location = new System.Drawing.Point(6, 43);
            this.dgCosto.Name = "dgCosto";
            this.dgCosto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCosto.Size = new System.Drawing.Size(679, 74);
            this.dgCosto.TabIndex = 88;
            // 
            // colPrecLista
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrecLista.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrecLista.HeaderText = "PrecioLista";
            this.colPrecLista.Name = "colPrecLista";
            this.colPrecLista.ReadOnly = true;
            // 
            // colSinIva
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colSinIva.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSinIva.HeaderText = "S/IVA";
            this.colSinIva.Name = "colSinIva";
            this.colSinIva.ReadOnly = true;
            // 
            // colConIva
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colConIva.DefaultCellStyle = dataGridViewCellStyle3;
            this.colConIva.HeaderText = "C/IVA";
            this.colConIva.Name = "colConIva";
            this.colConIva.ReadOnly = true;
            // 
            // btnAgrDescRec
            // 
            this.btnAgrDescRec.BackgroundImage = global::Pintureria.Properties.Resources.mas1;
            this.btnAgrDescRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgrDescRec.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgrDescRec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgrDescRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrDescRec.Location = new System.Drawing.Point(357, 14);
            this.btnAgrDescRec.Name = "btnAgrDescRec";
            this.btnAgrDescRec.Size = new System.Drawing.Size(31, 23);
            this.btnAgrDescRec.TabIndex = 16;
            this.btnAgrDescRec.TabStop = false;
            this.btnAgrDescRec.UseVisualStyleBackColor = true;
            this.btnAgrDescRec.Click += new System.EventHandler(this.btnAgrDescRec_Click);
            // 
            // txtDescDescRec
            // 
            this.txtDescDescRec.Location = new System.Drawing.Point(133, 15);
            this.txtDescDescRec.MaxLength = 20;
            this.txtDescDescRec.Name = "txtDescDescRec";
            this.txtDescDescRec.Size = new System.Drawing.Size(143, 22);
            this.txtDescDescRec.TabIndex = 14;
            // 
            // cboDescRec
            // 
            this.cboDescRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescRec.FormattingEnabled = true;
            this.cboDescRec.Items.AddRange(new object[] {
            "DESCUENTO",
            "RECARGO"});
            this.cboDescRec.Location = new System.Drawing.Point(6, 14);
            this.cboDescRec.Name = "cboDescRec";
            this.cboDescRec.Size = new System.Drawing.Size(121, 24);
            this.cboDescRec.TabIndex = 85;
            // 
            // txtPreLista
            // 
            this.txtPreLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreLista.Location = new System.Drawing.Point(163, 12);
            this.txtPreLista.Name = "txtPreLista";
            this.txtPreLista.Size = new System.Drawing.Size(124, 22);
            this.txtPreLista.TabIndex = 11;
            this.txtPreLista.GotFocus += new System.EventHandler(this.txtPreLista_GotFocus);
            this.txtPreLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPreLista.LostFocus += new System.EventHandler(this.txtPresLista_LostFocus);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(184, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 24);
            this.label17.TabIndex = 39;
            this.label17.Text = "Precio Final:";
            // 
            // txtPreFinal
            // 
            this.txtPreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreFinal.Location = new System.Drawing.Point(318, 211);
            this.txtPreFinal.Name = "txtPreFinal";
            this.txtPreFinal.ReadOnly = true;
            this.txtPreFinal.Size = new System.Drawing.Size(213, 35);
            this.txtPreFinal.TabIndex = 13;
            this.txtPreFinal.TabStop = false;
            this.txtPreFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreFinal.Click += new System.EventHandler(this.txtPreFinal_Click);
            this.txtPreFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            this.txtPreFinal.Leave += new System.EventHandler(this.txtPreFinal_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 16);
            this.label14.TabIndex = 80;
            this.label14.Text = "Ganancia% :";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(285, 43);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(50, 22);
            this.txtIva.TabIndex = 13;
            this.txtIva.TabStop = false;
            this.txtIva.Text = "21";
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtIva.Leave += new System.EventHandler(this.txtIva_Leave);
            // 
            // lvlIva
            // 
            this.lvlIva.AutoSize = true;
            this.lvlIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlIva.Location = new System.Drawing.Point(243, 46);
            this.lvlIva.Name = "lvlIva";
            this.lvlIva.Size = new System.Drawing.Size(36, 16);
            this.lvlIva.TabIndex = 79;
            this.lvlIva.Text = "IVA:";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(163, 43);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(50, 22);
            this.txtGanancia.TabIndex = 12;
            this.txtGanancia.TabStop = false;
            this.txtGanancia.Text = "62";
            this.txtGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtGanancia.Leave += new System.EventHandler(this.txtGanancia_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(386, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(484, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(288, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = global::Pintureria.Properties.Resources.Ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(758, 340);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(35, 30);
            this.btnAyuda.TabIndex = 58;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(819, 407);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArticulo_KeyDown);
            this.tabArticulo.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorDescr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCodArt)).EndInit();
            this.tabPagCosto.ResumeLayout(false);
            this.tabPagCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorPreLista)).EndInit();
            this.grCosto.ResumeLayout(false);
            this.grCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCosto)).EndInit();
            this.ResumeLayout(false);

        }

        

      

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtFecCom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabArticulo;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPagCosto;
        private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtPreFinal;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPreLista;
        private System.Windows.Forms.TextBox txtStockMin;
		private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.GroupBox grCosto;
		private System.Windows.Forms.TextBox txtPorDesRec;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataGridView dgCosto;
		private System.Windows.Forms.Button btnAgrDescRec;
		private System.Windows.Forms.TextBox txtDescDescRec;
		private System.Windows.Forms.ComboBox cboDescRec;
		private System.Windows.Forms.TextBox txtIva;
		private System.Windows.Forms.TextBox txtGanancia;
		private System.Windows.Forms.Label lvlIva;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrecLista;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSinIva;
		private System.Windows.Forms.DataGridViewTextBoxColumn colConIva;
		private System.Windows.Forms.Button btnEliminarCol;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picErrorPreLista;
		private System.Windows.Forms.PictureBox picErrorCodArt;
		private System.Windows.Forms.PictureBox picErrorDescr;
		private System.Windows.Forms.Button btnAyuda;
    }
}