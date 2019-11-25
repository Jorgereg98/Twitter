namespace Twitter.User_Controls
{
    partial class Home
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Login2 = new System.Windows.Forms.Button();
            this.register1 = new Twitter.User_Controls.Login();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.Transparent;
            this.Login.Location = new System.Drawing.Point(836, 410);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(354, 36);
            this.Login.TabIndex = 2;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.Transparent;
            this.Register.Location = new System.Drawing.Point(836, 360);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(354, 36);
            this.Register.TabIndex = 1;
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Login2
            // 
            this.Login2.BackColor = System.Drawing.Color.Transparent;
            this.Login2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login2.ForeColor = System.Drawing.Color.Transparent;
            this.Login2.Location = new System.Drawing.Point(1086, 117);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(104, 47);
            this.Login2.TabIndex = 0;
            this.Login2.UseVisualStyleBackColor = false;
            this.Login2.Click += new System.EventHandler(this.Login2_Click);
            // 
            // register1
            // 
            this.register1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("register1.BackgroundImage")));
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(1340, 565);
            this.register1.TabIndex = 3;
            this.register1.Tag = "";
            this.register1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.register1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1340, 565);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Login register1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Login2;
    }
}
