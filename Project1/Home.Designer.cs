namespace Project1
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeTeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastriesSandwichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.productsToolStripMenuItem,
            this.cartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Teal;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffeeTeaToolStripMenuItem,
            this.pastriesSandwichesToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // coffeeTeaToolStripMenuItem
            // 
            this.coffeeTeaToolStripMenuItem.Name = "coffeeTeaToolStripMenuItem";
            this.coffeeTeaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.coffeeTeaToolStripMenuItem.Text = "Coffee & Tea";
            this.coffeeTeaToolStripMenuItem.Click += new System.EventHandler(this.coffeeTeaToolStripMenuItem_Click);
            // 
            // pastriesSandwichesToolStripMenuItem
            // 
            this.pastriesSandwichesToolStripMenuItem.Name = "pastriesSandwichesToolStripMenuItem";
            this.pastriesSandwichesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.pastriesSandwichesToolStripMenuItem.Text = "Pastries & Sandwiches";
            this.pastriesSandwichesToolStripMenuItem.Click += new System.EventHandler(this.pastriesSandwichesToolStripMenuItem_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Click += new System.EventHandler(this.cartToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project1.Properties.Resources.Coffeeeee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeTeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastriesSandwichesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
    }
}