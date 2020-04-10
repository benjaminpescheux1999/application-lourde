namespace BreizhFood
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ValiderConnect = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Pseudo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValiderConnect
            // 
            this.ValiderConnect.BackColor = System.Drawing.Color.Transparent;
            this.ValiderConnect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ValiderConnect.ForeColor = System.Drawing.Color.Black;
            this.ValiderConnect.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ValiderConnect.Location = new System.Drawing.Point(199, 295);
            this.ValiderConnect.Name = "ValiderConnect";
            this.ValiderConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ValiderConnect.Size = new System.Drawing.Size(328, 27);
            this.ValiderConnect.TabIndex = 0;
            this.ValiderConnect.Text = "Login";
            this.ValiderConnect.UseVisualStyleBackColor = false;
            this.ValiderConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(381, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(146, 22);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Pseudo
            // 
            this.Pseudo.BackColor = System.Drawing.SystemColors.Window;
            this.Pseudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pseudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pseudo.Location = new System.Drawing.Point(199, 211);
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.Size = new System.Drawing.Size(146, 22);
            this.Pseudo.TabIndex = 3;
            this.Pseudo.TextChanged += new System.EventHandler(this.Pseudo_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 96;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Pseudo";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 97;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Password";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Pseudo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ValiderConnect);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "BreizhFood";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValiderConnect;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Pseudo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

