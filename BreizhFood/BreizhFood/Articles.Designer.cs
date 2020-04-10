namespace BreizhFood
{
    partial class Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            this.Categories = new System.Windows.Forms.ComboBox();
            this.AddCat = new System.Windows.Forms.Button();
            this.ProduitN = new System.Windows.Forms.TextBox();
            this.ModifN = new System.Windows.Forms.Button();
            this.AddP = new System.Windows.Forms.Button();
            this.DelCat = new System.Windows.Forms.Button();
            this.ModifCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ProduitP = new System.Windows.Forms.TextBox();
            this.Clients = new System.Windows.Forms.Button();
            this.ProduitI = new System.Windows.Forms.TextBox();
            this.ProduitC = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(58, 51);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(212, 24);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "Categories";
            this.Categories.SelectedIndexChanged += new System.EventHandler(this.Categories_SelectedIndexChanged_1);
            // 
            // AddCat
            // 
            this.AddCat.BackColor = System.Drawing.Color.Transparent;
            this.AddCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCat.BackgroundImage")));
            this.AddCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddCat.ForeColor = System.Drawing.Color.Transparent;
            this.AddCat.Location = new System.Drawing.Point(372, 349);
            this.AddCat.Name = "AddCat";
            this.AddCat.Size = new System.Drawing.Size(35, 36);
            this.AddCat.TabIndex = 2;
            this.AddCat.UseVisualStyleBackColor = false;
            this.AddCat.Click += new System.EventHandler(this.AddCat_Click);
            // 
            // ProduitN
            // 
            this.ProduitN.Location = new System.Drawing.Point(276, 157);
            this.ProduitN.Name = "ProduitN";
            this.ProduitN.Size = new System.Drawing.Size(212, 22);
            this.ProduitN.TabIndex = 3;
            this.ProduitN.Text = "Nom du produit";
            this.ProduitN.TextChanged += new System.EventHandler(this.ProduitN_TextChanged_1);
            // 
            // ModifN
            // 
            this.ModifN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModifN.BackgroundImage")));
            this.ModifN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModifN.Location = new System.Drawing.Point(147, 81);
            this.ModifN.Name = "ModifN";
            this.ModifN.Size = new System.Drawing.Size(35, 36);
            this.ModifN.TabIndex = 10;
            this.ModifN.UseVisualStyleBackColor = true;
            // 
            // AddP
            // 
            this.AddP.BackColor = System.Drawing.Color.Transparent;
            this.AddP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddP.BackgroundImage")));
            this.AddP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddP.ForeColor = System.Drawing.Color.Transparent;
            this.AddP.Location = new System.Drawing.Point(58, 81);
            this.AddP.Name = "AddP";
            this.AddP.Size = new System.Drawing.Size(35, 36);
            this.AddP.TabIndex = 13;
            this.AddP.UseVisualStyleBackColor = false;
            // 
            // DelCat
            // 
            this.DelCat.BackColor = System.Drawing.Color.Transparent;
            this.DelCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelCat.BackgroundImage")));
            this.DelCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelCat.ForeColor = System.Drawing.Color.Transparent;
            this.DelCat.Location = new System.Drawing.Point(453, 349);
            this.DelCat.Name = "DelCat";
            this.DelCat.Size = new System.Drawing.Size(35, 36);
            this.DelCat.TabIndex = 14;
            this.DelCat.UseVisualStyleBackColor = false;
            this.DelCat.Click += new System.EventHandler(this.DelCat_Click);
            // 
            // ModifCat
            // 
            this.ModifCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ModifCat.BackgroundImage")));
            this.ModifCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModifCat.Location = new System.Drawing.Point(276, 349);
            this.ModifCat.Name = "ModifCat";
            this.ModifCat.Size = new System.Drawing.Size(35, 36);
            this.ModifCat.TabIndex = 15;
            this.ModifCat.UseVisualStyleBackColor = true;
            this.ModifCat.Click += new System.EventHandler(this.ModifCat_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(235, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 228);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ProduitP
            // 
            this.ProduitP.Location = new System.Drawing.Point(276, 209);
            this.ProduitP.Name = "ProduitP";
            this.ProduitP.Size = new System.Drawing.Size(212, 22);
            this.ProduitP.TabIndex = 20;
            this.ProduitP.Text = "Prix";
            this.ProduitP.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Clients
            // 
            this.Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clients.Image = ((System.Drawing.Image)(resources.GetObject("Clients.Image")));
            this.Clients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clients.Location = new System.Drawing.Point(414, 15);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(230, 60);
            this.Clients.TabIndex = 21;
            this.Clients.Text = "Accueil";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // ProduitI
            // 
            this.ProduitI.Location = new System.Drawing.Point(276, 259);
            this.ProduitI.Name = "ProduitI";
            this.ProduitI.Size = new System.Drawing.Size(212, 22);
            this.ProduitI.TabIndex = 22;
            this.ProduitI.Text = "nom image";
            this.ProduitI.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // ProduitC
            // 
            this.ProduitC.Location = new System.Drawing.Point(276, 307);
            this.ProduitC.Name = "ProduitC";
            this.ProduitC.Size = new System.Drawing.Size(212, 22);
            this.ProduitC.TabIndex = 23;
            this.ProduitC.Text = "id cat";
            this.ProduitC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(659, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 102;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProduitC);
            this.Controls.Add(this.ProduitI);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.ProduitP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModifCat);
            this.Controls.Add(this.DelCat);
            this.Controls.Add(this.AddP);
            this.Controls.Add(this.ModifN);
            this.Controls.Add(this.ProduitN);
            this.Controls.Add(this.AddCat);
            this.Controls.Add(this.Categories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Articles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Categories;
        private System.Windows.Forms.Button AddCat;
        private System.Windows.Forms.TextBox ProduitN;
        private System.Windows.Forms.Button ModifN;
        private System.Windows.Forms.Button AddP;
        private System.Windows.Forms.Button DelCat;
        private System.Windows.Forms.Button ModifCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ProduitP;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.TextBox ProduitI;
        private System.Windows.Forms.TextBox ProduitC;
        private System.Windows.Forms.Button button2;
    }
}