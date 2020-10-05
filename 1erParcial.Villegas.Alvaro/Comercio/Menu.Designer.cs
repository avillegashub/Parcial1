namespace Comercio
{
    partial class Menu
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
            this.bt_Stock = new System.Windows.Forms.Button();
            this.bt_venta = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_reportes = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Stock
            // 
            this.bt_Stock.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Stock.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stock.Location = new System.Drawing.Point(305, 15);
            this.bt_Stock.Name = "bt_Stock";
            this.bt_Stock.Size = new System.Drawing.Size(75, 69);
            this.bt_Stock.TabIndex = 0;
            this.bt_Stock.Text = "Stock";
            this.bt_Stock.UseVisualStyleBackColor = false;
            this.bt_Stock.Click += new System.EventHandler(this.bt_Stock_Click);
            // 
            // bt_venta
            // 
            this.bt_venta.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_venta.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venta.Location = new System.Drawing.Point(305, 90);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Size = new System.Drawing.Size(75, 69);
            this.bt_venta.TabIndex = 3;
            this.bt_venta.Text = "Venta";
            this.bt_venta.UseVisualStyleBackColor = false;
            this.bt_venta.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_salir.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Location = new System.Drawing.Point(305, 245);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(75, 34);
            this.bt_salir.TabIndex = 4;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_reportes
            // 
            this.bt_reportes.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_reportes.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reportes.Location = new System.Drawing.Point(305, 165);
            this.bt_reportes.Name = "bt_reportes";
            this.bt_reportes.Size = new System.Drawing.Size(75, 69);
            this.bt_reportes.TabIndex = 2;
            this.bt_reportes.Text = "Reportes";
            this.bt_reportes.UseVisualStyleBackColor = false;
            this.bt_reportes.Click += new System.EventHandler(this.bt_reportes_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Location = new System.Drawing.Point(12, 15);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(275, 264);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(400, 291);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.bt_reportes);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_venta);
            this.Controls.Add(this.bt_Stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Stock;
        private System.Windows.Forms.Button bt_venta;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_reportes;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}