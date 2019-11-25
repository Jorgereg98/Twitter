namespace Twitter.User_Controls
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterNow = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.register1 = new Twitter.User_Controls.Register();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(381, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RegisterNow
            // 
            this.RegisterNow.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.RegisterNow.AutoSize = true;
            this.RegisterNow.BackColor = System.Drawing.Color.Transparent;
            this.RegisterNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNow.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.RegisterNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNow.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.RegisterNow.Location = new System.Drawing.Point(508, 309);
            this.RegisterNow.Name = "RegisterNow";
            this.RegisterNow.Size = new System.Drawing.Size(125, 16);
            this.RegisterNow.TabIndex = 1;
            this.RegisterNow.TabStop = true;
            this.RegisterNow.Text = "Regístrate ahora >>";
            this.RegisterNow.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RegisterNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterNow_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Teléfono, correo o usuario";
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(1340, 565);
            this.register1.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.register1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RegisterNow);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1340, 565);
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel RegisterNow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Register register1;
    }
}
