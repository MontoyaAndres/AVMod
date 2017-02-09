namespace AVMod2
{
    partial class AVMod2pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVMod2pro));
            this.cerrar = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.Windows = new System.Windows.Forms.RadioButton();
            this.mac = new System.Windows.Forms.RadioButton();
            this.todos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puerto = new System.Windows.Forms.TextBox();
            this.linux = new System.Windows.Forms.RadioButton();
            this.git = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.Button();
            this.twitter = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cerrar.ForeColor = System.Drawing.Color.Black;
            this.cerrar.Location = new System.Drawing.Point(534, 11);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(15, 13);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            this.cerrar.MouseLeave += new System.EventHandler(this.cerrar_MouseLeave);
            this.cerrar.MouseHover += new System.EventHandler(this.cerrar_MouseHover);
            // 
            // guardar
            // 
            this.guardar.AutoSize = true;
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.guardar.ForeColor = System.Drawing.Color.Black;
            this.guardar.Location = new System.Drawing.Point(514, 11);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(15, 13);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "--";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            this.guardar.MouseLeave += new System.EventHandler(this.guardar_MouseLeave);
            this.guardar.MouseHover += new System.EventHandler(this.guardar_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(69, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "AVMod 2";
            // 
            // ip
            // 
            this.ip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Bold);
            this.ip.Location = new System.Drawing.Point(59, 111);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(201, 19);
            this.ip.TabIndex = 9;
            this.ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ip_KeyPress);
            // 
            // Windows
            // 
            this.Windows.AutoSize = true;
            this.Windows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Windows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Windows.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Windows.FlatAppearance.BorderSize = 0;
            this.Windows.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windows.ForeColor = System.Drawing.Color.Orange;
            this.Windows.ImageKey = "(ninguno)";
            this.Windows.Location = new System.Drawing.Point(304, 111);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(85, 21);
            this.Windows.TabIndex = 11;
            this.Windows.Text = "Windows";
            this.Windows.UseVisualStyleBackColor = true;
            // 
            // mac
            // 
            this.mac.AutoSize = true;
            this.mac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mac.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.mac.FlatAppearance.BorderSize = 0;
            this.mac.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mac.ForeColor = System.Drawing.Color.Orange;
            this.mac.ImageKey = "(ninguno)";
            this.mac.Location = new System.Drawing.Point(304, 147);
            this.mac.Name = "mac";
            this.mac.Size = new System.Drawing.Size(68, 21);
            this.mac.TabIndex = 18;
            this.mac.Text = "MacOs";
            this.mac.UseVisualStyleBackColor = true;
            // 
            // todos
            // 
            this.todos.AutoSize = true;
            this.todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.todos.FlatAppearance.BorderSize = 0;
            this.todos.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.todos.ForeColor = System.Drawing.Color.Orange;
            this.todos.ImageKey = "(ninguno)";
            this.todos.Location = new System.Drawing.Point(431, 147);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(63, 21);
            this.todos.TabIndex = 20;
            this.todos.Text = "Todos";
            this.todos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "I.P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(7, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Puerto";
            // 
            // puerto
            // 
            this.puerto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puerto.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Bold);
            this.puerto.Location = new System.Drawing.Point(59, 159);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(201, 19);
            this.puerto.TabIndex = 24;
            this.puerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puerto_KeyPress);
            // 
            // linux
            // 
            this.linux.AutoSize = true;
            this.linux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linux.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.linux.FlatAppearance.BorderSize = 0;
            this.linux.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.linux.ForeColor = System.Drawing.Color.Orange;
            this.linux.ImageKey = "(ninguno)";
            this.linux.Location = new System.Drawing.Point(431, 111);
            this.linux.Name = "linux";
            this.linux.Size = new System.Drawing.Size(68, 21);
            this.linux.TabIndex = 25;
            this.linux.Text = "Linux ";
            this.linux.UseVisualStyleBackColor = true;
            // 
            // git
            // 
            this.git.BackgroundImage = global::AVMod2.Properties.Resources.git;
            this.git.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.git.Cursor = System.Windows.Forms.Cursors.Hand;
            this.git.FlatAppearance.BorderSize = 0;
            this.git.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.git.Location = new System.Drawing.Point(50, 9);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(13, 13);
            this.git.TabIndex = 29;
            this.git.UseVisualStyleBackColor = true;
            this.git.Click += new System.EventHandler(this.git_Click);
            // 
            // google
            // 
            this.google.BackgroundImage = global::AVMod2.Properties.Resources.google;
            this.google.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.google.FlatAppearance.BorderSize = 0;
            this.google.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.google.Location = new System.Drawing.Point(30, 9);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(13, 13);
            this.google.TabIndex = 28;
            this.google.UseVisualStyleBackColor = true;
            this.google.Click += new System.EventHandler(this.google_Click);
            // 
            // twitter
            // 
            this.twitter.BackgroundImage = global::AVMod2.Properties.Resources.twitter;
            this.twitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitter.FlatAppearance.BorderSize = 0;
            this.twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitter.Location = new System.Drawing.Point(11, 9);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(13, 13);
            this.twitter.TabIndex = 27;
            this.twitter.UseVisualStyleBackColor = true;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // go
            // 
            this.go.BackgroundImage = global::AVMod2.Properties.Resources.cada;
            this.go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go.FlatAppearance.BorderSize = 0;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.ForeColor = System.Drawing.Color.Transparent;
            this.go.Location = new System.Drawing.Point(249, 206);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(61, 57);
            this.go.TabIndex = 26;
            this.go.Text = "r";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // AVMod2pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(561, 305);
            this.Controls.Add(this.git);
            this.Controls.Add(this.google);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.go);
            this.Controls.Add(this.linux);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.todos);
            this.Controls.Add(this.mac);
            this.Controls.Add(this.Windows);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cerrar);
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVMod2pro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVMod";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.Label guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.RadioButton Windows;
        private System.Windows.Forms.RadioButton mac;
        private System.Windows.Forms.RadioButton todos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.RadioButton linux;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button twitter;
        private System.Windows.Forms.Button google;
        private System.Windows.Forms.Button git;
    }
}

