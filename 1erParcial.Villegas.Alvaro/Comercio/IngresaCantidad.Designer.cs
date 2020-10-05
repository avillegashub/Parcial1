namespace Comercio
{
    partial class IngresaCantidad
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
            this.txbx_cantidad = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_cantidad
            // 
            this.txbx_cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_cantidad.Location = new System.Drawing.Point(22, 23);
            this.txbx_cantidad.Name = "txbx_cantidad";
            this.txbx_cantidad.Size = new System.Drawing.Size(132, 23);
            this.txbx_cantidad.TabIndex = 0;
            this.txbx_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_ingresar.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.Black;
            this.bt_ingresar.Location = new System.Drawing.Point(34, 64);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_ingresar.Size = new System.Drawing.Size(109, 48);
            this.bt_ingresar.TabIndex = 1;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresaCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(181, 144);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.txbx_cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresaCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_cantidad;
        private System.Windows.Forms.Button bt_ingresar;
    }
}