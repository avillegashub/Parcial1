namespace Comercio
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.dgv_ListaProductos = new System.Windows.Forms.DataGridView();
            this.dgv_columnaImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_columnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_columnaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbx_codigo = new System.Windows.Forms.TextBox();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.txbx_nombre = new System.Windows.Forms.TextBox();
            this.lb_precio = new System.Windows.Forms.Label();
            this.txbxPrecio = new System.Windows.Forms.TextBox();
            this.lb_stock = new System.Windows.Forms.Label();
            this.txbx_stock = new System.Windows.Forms.TextBox();
            this.bt_anadir = new System.Windows.Forms.Button();
            this.bt_filtrar = new System.Windows.Forms.Button();
            this.bt_clean = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbox_Agregar = new System.Windows.Forms.ComboBox();
            this.cbox_Filtrar = new System.Windows.Forms.ComboBox();
            this.pcbx_imagenProducto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_imagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaProductos
            // 
            this.dgv_ListaProductos.AllowUserToAddRows = false;
            this.dgv_ListaProductos.AllowUserToDeleteRows = false;
            this.dgv_ListaProductos.AllowUserToResizeColumns = false;
            this.dgv_ListaProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_ListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_columnaImagen,
            this.dgv_columnaId,
            this.dgv_columnaNombre,
            this.dgv_columnaPrecio,
            this.dgv_columnaStock});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ListaProductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListaProductos.Location = new System.Drawing.Point(485, 42);
            this.dgv_ListaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ListaProductos.Name = "dgv_ListaProductos";
            this.dgv_ListaProductos.ReadOnly = true;
            this.dgv_ListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ListaProductos.RowHeadersVisible = false;
            this.dgv_ListaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_ListaProductos.RowTemplate.Height = 50;
            this.dgv_ListaProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaProductos.ShowCellErrors = false;
            this.dgv_ListaProductos.ShowRowErrors = false;
            this.dgv_ListaProductos.Size = new System.Drawing.Size(556, 755);
            this.dgv_ListaProductos.TabIndex = 8;
            this.dgv_ListaProductos.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dgv_columnaImagen
            // 
            this.dgv_columnaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv_columnaImagen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_columnaImagen.FillWeight = 1F;
            this.dgv_columnaImagen.HeaderText = "";
            this.dgv_columnaImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgv_columnaImagen.Name = "dgv_columnaImagen";
            this.dgv_columnaImagen.ReadOnly = true;
            this.dgv_columnaImagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_columnaImagen.Width = 54;
            // 
            // dgv_columnaId
            // 
            this.dgv_columnaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgv_columnaId.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_columnaId.FillWeight = 200F;
            this.dgv_columnaId.HeaderText = "Codigo";
            this.dgv_columnaId.Name = "dgv_columnaId";
            this.dgv_columnaId.ReadOnly = true;
            this.dgv_columnaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_columnaId.Width = 130;
            // 
            // dgv_columnaNombre
            // 
            this.dgv_columnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            this.dgv_columnaNombre.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_columnaNombre.HeaderText = "Nombre";
            this.dgv_columnaNombre.MaxInputLength = 10;
            this.dgv_columnaNombre.Name = "dgv_columnaNombre";
            this.dgv_columnaNombre.ReadOnly = true;
            this.dgv_columnaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_columnaNombre.Width = 150;
            // 
            // dgv_columnaPrecio
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dgv_columnaPrecio.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_columnaPrecio.HeaderText = "Precio $";
            this.dgv_columnaPrecio.MinimumWidth = 100;
            this.dgv_columnaPrecio.Name = "dgv_columnaPrecio";
            this.dgv_columnaPrecio.ReadOnly = true;
            this.dgv_columnaPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_columnaStock
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dgv_columnaStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_columnaStock.HeaderText = "Stock";
            this.dgv_columnaStock.MinimumWidth = 99;
            this.dgv_columnaStock.Name = "dgv_columnaStock";
            this.dgv_columnaStock.ReadOnly = true;
            this.dgv_columnaStock.Width = 99;
            // 
            // txbx_codigo
            // 
            this.txbx_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_codigo.Location = new System.Drawing.Point(133, 362);
            this.txbx_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_codigo.Name = "txbx_codigo";
            this.txbx_codigo.Size = new System.Drawing.Size(132, 23);
            this.txbx_codigo.TabIndex = 0;
            this.txbx_codigo.TextChanged += new System.EventHandler(this.txbx_codigo_TextChanged);
            this.txbx_codigo.Leave += new System.EventHandler(this.txbx_codigo_Leave);
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(40, 367);
            this.lb_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(52, 16);
            this.lb_codigo.TabIndex = 3;
            this.lb_codigo.Text = "Codigo";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(40, 445);
            this.lb_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(59, 16);
            this.lb_nombre.TabIndex = 5;
            this.lb_nombre.Text = "Nombre";
            // 
            // txbx_nombre
            // 
            this.txbx_nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_nombre.Location = new System.Drawing.Point(133, 439);
            this.txbx_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_nombre.Name = "txbx_nombre";
            this.txbx_nombre.Size = new System.Drawing.Size(132, 23);
            this.txbx_nombre.TabIndex = 1;
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precio.Location = new System.Drawing.Point(40, 520);
            this.lb_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(50, 16);
            this.lb_precio.TabIndex = 7;
            this.lb_precio.Text = "Precio";
            // 
            // txbxPrecio
            // 
            this.txbxPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPrecio.Location = new System.Drawing.Point(133, 515);
            this.txbxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPrecio.Name = "txbxPrecio";
            this.txbxPrecio.Size = new System.Drawing.Size(132, 23);
            this.txbxPrecio.TabIndex = 2;
            this.txbxPrecio.Leave += new System.EventHandler(this.txbxPrecio_Leave);
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stock.Location = new System.Drawing.Point(40, 596);
            this.lb_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(46, 16);
            this.lb_stock.TabIndex = 9;
            this.lb_stock.Text = "Stock";
            // 
            // txbx_stock
            // 
            this.txbx_stock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_stock.Location = new System.Drawing.Point(133, 591);
            this.txbx_stock.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_stock.Name = "txbx_stock";
            this.txbx_stock.ReadOnly = true;
            this.txbx_stock.Size = new System.Drawing.Size(132, 23);
            this.txbx_stock.TabIndex = 8;
            // 
            // bt_anadir
            // 
            this.bt_anadir.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_anadir.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_anadir.Location = new System.Drawing.Point(347, 361);
            this.bt_anadir.Margin = new System.Windows.Forms.Padding(4);
            this.bt_anadir.Name = "bt_anadir";
            this.bt_anadir.Size = new System.Drawing.Size(100, 30);
            this.bt_anadir.TabIndex = 5;
            this.bt_anadir.Text = "Añadir";
            this.bt_anadir.UseVisualStyleBackColor = false;
            this.bt_anadir.Click += new System.EventHandler(this.bt_anadir_Click);
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_filtrar.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_filtrar.Location = new System.Drawing.Point(347, 438);
            this.bt_filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(100, 30);
            this.bt_filtrar.TabIndex = 6;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.UseVisualStyleBackColor = false;
            this.bt_filtrar.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // bt_clean
            // 
            this.bt_clean.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_clean.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clean.Location = new System.Drawing.Point(347, 514);
            this.bt_clean.Margin = new System.Windows.Forms.Padding(4);
            this.bt_clean.Name = "bt_clean";
            this.bt_clean.Size = new System.Drawing.Size(100, 30);
            this.bt_clean.TabIndex = 7;
            this.bt_clean.Text = "Limpiar";
            this.bt_clean.UseVisualStyleBackColor = false;
            this.bt_clean.Click += new System.EventHandler(this.bt_clean_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 743);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // cbox_Agregar
            // 
            this.cbox_Agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Agregar.FormattingEnabled = true;
            this.cbox_Agregar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cbox_Agregar.Location = new System.Drawing.Point(292, 362);
            this.cbox_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_Agregar.Name = "cbox_Agregar";
            this.cbox_Agregar.Size = new System.Drawing.Size(45, 25);
            this.cbox_Agregar.TabIndex = 3;
            this.cbox_Agregar.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // cbox_Filtrar
            // 
            this.cbox_Filtrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Filtrar.FormattingEnabled = true;
            this.cbox_Filtrar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cbox_Filtrar.Location = new System.Drawing.Point(292, 439);
            this.cbox_Filtrar.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_Filtrar.Name = "cbox_Filtrar";
            this.cbox_Filtrar.Size = new System.Drawing.Size(45, 25);
            this.cbox_Filtrar.TabIndex = 4;
            // 
            // pcbx_imagenProducto
            // 
            this.pcbx_imagenProducto.Location = new System.Drawing.Point(92, 42);
            this.pcbx_imagenProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pcbx_imagenProducto.Name = "pcbx_imagenProducto";
            this.pcbx_imagenProducto.Size = new System.Drawing.Size(300, 281);
            this.pcbx_imagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbx_imagenProducto.TabIndex = 2;
            this.pcbx_imagenProducto.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(43, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salida";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1093, 876);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_Filtrar);
            this.Controls.Add(this.cbox_Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_clean);
            this.Controls.Add(this.bt_filtrar);
            this.Controls.Add(this.bt_anadir);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.txbx_stock);
            this.Controls.Add(this.lb_precio);
            this.Controls.Add(this.txbxPrecio);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.txbx_nombre);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.pcbx_imagenProducto);
            this.Controls.Add(this.txbx_codigo);
            this.Controls.Add(this.dgv_ListaProductos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1093, 876);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1093, 876);
            this.Name = "Stock";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_imagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ListaProductos;
        private System.Windows.Forms.TextBox txbx_codigo;
        private System.Windows.Forms.PictureBox pcbx_imagenProducto;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox txbx_nombre;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.TextBox txbxPrecio;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.TextBox txbx_stock;
        private System.Windows.Forms.Button bt_anadir;
        private System.Windows.Forms.Button bt_filtrar;
        private System.Windows.Forms.Button bt_clean;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbox_Agregar;
        private System.Windows.Forms.ComboBox cbox_Filtrar;
        private System.Windows.Forms.DataGridViewImageColumn dgv_columnaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_columnaStock;
        private System.Windows.Forms.Button button1;
    }
}