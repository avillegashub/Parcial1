namespace Comercio
{
    partial class Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ListaInventario = new System.Windows.Forms.DataGridView();
            this.dgv_ListaVenta = new System.Windows.Forms.DataGridView();
            this.lb_SubtotalTag = new System.Windows.Forms.Label();
            this.lb_descuentoTag = new System.Windows.Forms.Label();
            this.lb_totalFinalTag = new System.Windows.Forms.Label();
            this.lb_Subtotal = new System.Windows.Forms.Label();
            this.lb_descuento = new System.Windows.Forms.Label();
            this.lb_totalFinal = new System.Windows.Forms.Label();
            this.txbx_nombreCliente = new System.Windows.Forms.TextBox();
            this.txbx_dniCliente = new System.Windows.Forms.TextBox();
            this.txbx_apellidoCliente = new System.Windows.Forms.TextBox();
            this.bt_venta = new System.Windows.Forms.Button();
            this.lb_vendedor = new System.Windows.Forms.Label();
            this.bt_salida = new System.Windows.Forms.Button();
            this.lb_dniTag = new System.Windows.Forms.Label();
            this.lb_NombreTag = new System.Windows.Forms.Label();
            this.lb_ApellidoTag = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaInventario
            // 
            this.dgv_ListaInventario.AllowUserToAddRows = false;
            this.dgv_ListaInventario.AllowUserToDeleteRows = false;
            this.dgv_ListaInventario.AllowUserToResizeColumns = false;
            this.dgv_ListaInventario.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgv_ListaInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ListaInventario.BackgroundColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_ListaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaInventario.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_ListaInventario.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ListaInventario.Location = new System.Drawing.Point(571, 21);
            this.dgv_ListaInventario.Name = "dgv_ListaInventario";
            this.dgv_ListaInventario.ReadOnly = true;
            this.dgv_ListaInventario.RowHeadersVisible = false;
            this.dgv_ListaInventario.Size = new System.Drawing.Size(429, 659);
            this.dgv_ListaInventario.TabIndex = 13;
            this.dgv_ListaInventario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_ListaInventario_MouseDown);
            // 
            // dgv_ListaVenta
            // 
            this.dgv_ListaVenta.AllowDrop = true;
            this.dgv_ListaVenta.AllowUserToAddRows = false;
            this.dgv_ListaVenta.AllowUserToDeleteRows = false;
            this.dgv_ListaVenta.AllowUserToResizeColumns = false;
            this.dgv_ListaVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dgv_ListaVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_ListaVenta.BackgroundColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_ListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaVenta.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_ListaVenta.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ListaVenta.Location = new System.Drawing.Point(35, 81);
            this.dgv_ListaVenta.Name = "dgv_ListaVenta";
            this.dgv_ListaVenta.ReadOnly = true;
            this.dgv_ListaVenta.RowHeadersVisible = false;
            this.dgv_ListaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaVenta.Size = new System.Drawing.Size(485, 460);
            this.dgv_ListaVenta.TabIndex = 12;
            this.dgv_ListaVenta.Click += new System.EventHandler(this.dataGridView2_Click);
            this.dgv_ListaVenta.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragDrop);
            this.dgv_ListaVenta.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragEnter);
            // 
            // lb_SubtotalTag
            // 
            this.lb_SubtotalTag.AutoSize = true;
            this.lb_SubtotalTag.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubtotalTag.Location = new System.Drawing.Point(316, 556);
            this.lb_SubtotalTag.Name = "lb_SubtotalTag";
            this.lb_SubtotalTag.Size = new System.Drawing.Size(85, 19);
            this.lb_SubtotalTag.TabIndex = 5;
            this.lb_SubtotalTag.Text = "SubTotal:";
            // 
            // lb_descuentoTag
            // 
            this.lb_descuentoTag.AutoSize = true;
            this.lb_descuentoTag.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descuentoTag.Location = new System.Drawing.Point(316, 587);
            this.lb_descuentoTag.MinimumSize = new System.Drawing.Size(100, 0);
            this.lb_descuentoTag.Name = "lb_descuentoTag";
            this.lb_descuentoTag.Size = new System.Drawing.Size(105, 19);
            this.lb_descuentoTag.TabIndex = 7;
            this.lb_descuentoTag.Text = "Descuento :";
            // 
            // lb_totalFinalTag
            // 
            this.lb_totalFinalTag.AutoSize = true;
            this.lb_totalFinalTag.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalFinalTag.Location = new System.Drawing.Point(316, 624);
            this.lb_totalFinalTag.Name = "lb_totalFinalTag";
            this.lb_totalFinalTag.Size = new System.Drawing.Size(54, 19);
            this.lb_totalFinalTag.TabIndex = 10;
            this.lb_totalFinalTag.Text = "Total:";
            // 
            // lb_Subtotal
            // 
            this.lb_Subtotal.AutoSize = true;
            this.lb_Subtotal.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Subtotal.Location = new System.Drawing.Point(420, 559);
            this.lb_Subtotal.MinimumSize = new System.Drawing.Size(100, 0);
            this.lb_Subtotal.Name = "lb_Subtotal";
            this.lb_Subtotal.Size = new System.Drawing.Size(100, 16);
            this.lb_Subtotal.TabIndex = 6;
            this.lb_Subtotal.Text = " ";
            this.lb_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_descuento
            // 
            this.lb_descuento.AutoSize = true;
            this.lb_descuento.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descuento.Location = new System.Drawing.Point(420, 590);
            this.lb_descuento.MinimumSize = new System.Drawing.Size(100, 0);
            this.lb_descuento.Name = "lb_descuento";
            this.lb_descuento.Size = new System.Drawing.Size(100, 16);
            this.lb_descuento.TabIndex = 9;
            this.lb_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_totalFinal
            // 
            this.lb_totalFinal.AutoSize = true;
            this.lb_totalFinal.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalFinal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_totalFinal.Location = new System.Drawing.Point(420, 638);
            this.lb_totalFinal.MinimumSize = new System.Drawing.Size(100, 0);
            this.lb_totalFinal.Name = "lb_totalFinal";
            this.lb_totalFinal.Size = new System.Drawing.Size(100, 16);
            this.lb_totalFinal.TabIndex = 11;
            this.lb_totalFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbx_nombreCliente
            // 
            this.txbx_nombreCliente.Location = new System.Drawing.Point(166, 40);
            this.txbx_nombreCliente.Name = "txbx_nombreCliente";
            this.txbx_nombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txbx_nombreCliente.TabIndex = 1;
            // 
            // txbx_dniCliente
            // 
            this.txbx_dniCliente.Location = new System.Drawing.Point(35, 40);
            this.txbx_dniCliente.Name = "txbx_dniCliente";
            this.txbx_dniCliente.Size = new System.Drawing.Size(100, 20);
            this.txbx_dniCliente.TabIndex = 0;
            this.txbx_dniCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txbx_dniCliente.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txbx_apellidoCliente
            // 
            this.txbx_apellidoCliente.Location = new System.Drawing.Point(376, 40);
            this.txbx_apellidoCliente.Name = "txbx_apellidoCliente";
            this.txbx_apellidoCliente.Size = new System.Drawing.Size(144, 20);
            this.txbx_apellidoCliente.TabIndex = 2;
            // 
            // bt_venta
            // 
            this.bt_venta.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_venta.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venta.Location = new System.Drawing.Point(426, 673);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Size = new System.Drawing.Size(94, 41);
            this.bt_venta.TabIndex = 4;
            this.bt_venta.Text = "Venta";
            this.bt_venta.UseVisualStyleBackColor = false;
            this.bt_venta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_vendedor
            // 
            this.lb_vendedor.AutoSize = true;
            this.lb_vendedor.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vendedor.Location = new System.Drawing.Point(48, 557);
            this.lb_vendedor.MaximumSize = new System.Drawing.Size(200, 0);
            this.lb_vendedor.Name = "lb_vendedor";
            this.lb_vendedor.Size = new System.Drawing.Size(0, 18);
            this.lb_vendedor.TabIndex = 14;
            this.lb_vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_salida
            // 
            this.bt_salida.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_salida.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salida.Location = new System.Drawing.Point(35, 673);
            this.bt_salida.Name = "bt_salida";
            this.bt_salida.Size = new System.Drawing.Size(85, 41);
            this.bt_salida.TabIndex = 15;
            this.bt_salida.TabStop = false;
            this.bt_salida.Text = "Salir";
            this.bt_salida.UseVisualStyleBackColor = false;
            this.bt_salida.Click += new System.EventHandler(this.bt_salida_Click);
            // 
            // lb_dniTag
            // 
            this.lb_dniTag.AutoSize = true;
            this.lb_dniTag.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dniTag.Location = new System.Drawing.Point(32, 24);
            this.lb_dniTag.Name = "lb_dniTag";
            this.lb_dniTag.Size = new System.Drawing.Size(28, 13);
            this.lb_dniTag.TabIndex = 16;
            this.lb_dniTag.Text = "DNI";
            // 
            // lb_NombreTag
            // 
            this.lb_NombreTag.AutoSize = true;
            this.lb_NombreTag.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreTag.Location = new System.Drawing.Point(163, 24);
            this.lb_NombreTag.Name = "lb_NombreTag";
            this.lb_NombreTag.Size = new System.Drawing.Size(51, 13);
            this.lb_NombreTag.TabIndex = 17;
            this.lb_NombreTag.Text = "Nombre";
            // 
            // lb_ApellidoTag
            // 
            this.lb_ApellidoTag.AutoSize = true;
            this.lb_ApellidoTag.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ApellidoTag.Location = new System.Drawing.Point(373, 24);
            this.lb_ApellidoTag.Name = "lb_ApellidoTag";
            this.lb_ApellidoTag.Size = new System.Drawing.Size(55, 13);
            this.lb_ApellidoTag.TabIndex = 18;
            this.lb_ApellidoTag.Text = "Apellido";
            // 
            // Column1
            // 
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "X";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 30;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1042, 736);
            this.Controls.Add(this.lb_ApellidoTag);
            this.Controls.Add(this.lb_NombreTag);
            this.Controls.Add(this.lb_dniTag);
            this.Controls.Add(this.bt_salida);
            this.Controls.Add(this.lb_vendedor);
            this.Controls.Add(this.bt_venta);
            this.Controls.Add(this.txbx_apellidoCliente);
            this.Controls.Add(this.txbx_dniCliente);
            this.Controls.Add(this.txbx_nombreCliente);
            this.Controls.Add(this.lb_totalFinal);
            this.Controls.Add(this.lb_descuento);
            this.Controls.Add(this.lb_Subtotal);
            this.Controls.Add(this.lb_totalFinalTag);
            this.Controls.Add(this.lb_descuentoTag);
            this.Controls.Add(this.lb_SubtotalTag);
            this.Controls.Add(this.dgv_ListaVenta);
            this.Controls.Add(this.dgv_ListaInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaInventario;
        private System.Windows.Forms.DataGridView dgv_ListaVenta;
        private System.Windows.Forms.Label lb_SubtotalTag;
        private System.Windows.Forms.Label lb_descuentoTag;
        private System.Windows.Forms.Label lb_totalFinalTag;
        private System.Windows.Forms.Label lb_Subtotal;
        private System.Windows.Forms.Label lb_descuento;
        private System.Windows.Forms.Label lb_totalFinal;
        private System.Windows.Forms.TextBox txbx_nombreCliente;
        private System.Windows.Forms.TextBox txbx_dniCliente;
        private System.Windows.Forms.TextBox txbx_apellidoCliente;
        private System.Windows.Forms.Button bt_venta;
        private System.Windows.Forms.Label lb_vendedor;
        private System.Windows.Forms.Button bt_salida;
        private System.Windows.Forms.Label lb_dniTag;
        private System.Windows.Forms.Label lb_NombreTag;
        private System.Windows.Forms.Label lb_ApellidoTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}