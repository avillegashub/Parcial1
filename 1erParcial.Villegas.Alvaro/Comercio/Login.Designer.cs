namespace Comercio
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.txbx_Usuario = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_Usuario
            // 
            this.txbx_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Usuario.Location = new System.Drawing.Point(70, 82);
            this.txbx_Usuario.Name = "txbx_Usuario";
            this.txbx_Usuario.Size = new System.Drawing.Size(100, 23);
            this.txbx_Usuario.TabIndex = 0;
            // 
            // txbx_password
            // 
            this.txbx_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_password.Location = new System.Drawing.Point(70, 125);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = 'X';
            this.txbx_password.Size = new System.Drawing.Size(100, 23);
            this.txbx_password.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_login.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(83, 164);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 33);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(88, 63);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(60, 16);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "Usuario";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(83, 106);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(74, 16);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Location = new System.Drawing.Point(235, 41);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(169, 172);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 5;
            this.pb_Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(462, 259);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_Usuario;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Timer timer1;
    }
}