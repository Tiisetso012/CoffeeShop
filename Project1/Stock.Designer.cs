
namespace Project1
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Food = new System.Windows.Forms.ComboBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DelFood = new System.Windows.Forms.Button();
            this.btn_UpdateFood = new System.Windows.Forms.Button();
            this.dgv_Food = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Drink = new System.Windows.Forms.ComboBox();
            this.txtDrinkPrice = new System.Windows.Forms.TextBox();
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DelDrink = new System.Windows.Forms.Button();
            this.btn_UpdateDrink = new System.Windows.Forms.Button();
            this.dgv_Drinks = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drinks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 445);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.buttonHome);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_DelFood);
            this.tabPage1.Controls.Add(this.btn_UpdateFood);
            this.tabPage1.Controls.Add(this.dgv_Food);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Food";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.cmb_Food);
            this.groupBox2.Controls.Add(this.txtFoodPrice);
            this.groupBox2.Controls.Add(this.txtFood);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(554, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 394);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Item";
            // 
            // cmb_Food
            // 
            this.cmb_Food.FormattingEnabled = true;
            this.cmb_Food.Location = new System.Drawing.Point(20, 186);
            this.cmb_Food.Name = "cmb_Food";
            this.cmb_Food.Size = new System.Drawing.Size(191, 33);
            this.cmb_Food.TabIndex = 10;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(20, 308);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(191, 30);
            this.txtFoodPrice.TabIndex = 9;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(20, 92);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(191, 30);
            this.txtFood.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Food Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Food Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Food Type:";
            // 
            // btn_DelFood
            // 
            this.btn_DelFood.BackColor = System.Drawing.Color.Teal;
            this.btn_DelFood.Location = new System.Drawing.Point(354, 378);
            this.btn_DelFood.Name = "btn_DelFood";
            this.btn_DelFood.Size = new System.Drawing.Size(194, 35);
            this.btn_DelFood.TabIndex = 5;
            this.btn_DelFood.Text = "Delete";
            this.btn_DelFood.UseVisualStyleBackColor = false;
            this.btn_DelFood.Click += new System.EventHandler(this.btn_DelFood_Click);
            // 
            // btn_UpdateFood
            // 
            this.btn_UpdateFood.BackColor = System.Drawing.Color.Teal;
            this.btn_UpdateFood.Location = new System.Drawing.Point(354, 327);
            this.btn_UpdateFood.Name = "btn_UpdateFood";
            this.btn_UpdateFood.Size = new System.Drawing.Size(194, 34);
            this.btn_UpdateFood.TabIndex = 4;
            this.btn_UpdateFood.Text = "Update";
            this.btn_UpdateFood.UseVisualStyleBackColor = false;
            this.btn_UpdateFood.Click += new System.EventHandler(this.btn_UpdateFood_Click);
            // 
            // dgv_Food
            // 
            this.dgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Food.Location = new System.Drawing.Point(13, 20);
            this.dgv_Food.Name = "dgv_Food";
            this.dgv_Food.RowHeadersWidth = 51;
            this.dgv_Food.Size = new System.Drawing.Size(335, 393);
            this.dgv_Food.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btnHome);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_DelDrink);
            this.tabPage2.Controls.Add(this.btn_UpdateDrink);
            this.tabPage2.Controls.Add(this.dgv_Drinks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drinks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.cmb_Drink);
            this.groupBox1.Controls.Add(this.txtDrinkPrice);
            this.groupBox1.Controls.Add(this.txtDrink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(554, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 394);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Item";
            // 
            // cmb_Drink
            // 
            this.cmb_Drink.FormattingEnabled = true;
            this.cmb_Drink.Location = new System.Drawing.Point(20, 186);
            this.cmb_Drink.Name = "cmb_Drink";
            this.cmb_Drink.Size = new System.Drawing.Size(191, 33);
            this.cmb_Drink.TabIndex = 10;
            // 
            // txtDrinkPrice
            // 
            this.txtDrinkPrice.Location = new System.Drawing.Point(20, 308);
            this.txtDrinkPrice.Name = "txtDrinkPrice";
            this.txtDrinkPrice.Size = new System.Drawing.Size(191, 30);
            this.txtDrinkPrice.TabIndex = 9;
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(20, 92);
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(191, 30);
            this.txtDrink.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drink Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Drink Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drink Type:";
            // 
            // btn_DelDrink
            // 
            this.btn_DelDrink.BackColor = System.Drawing.Color.Teal;
            this.btn_DelDrink.Location = new System.Drawing.Point(352, 378);
            this.btn_DelDrink.Name = "btn_DelDrink";
            this.btn_DelDrink.Size = new System.Drawing.Size(196, 35);
            this.btn_DelDrink.TabIndex = 4;
            this.btn_DelDrink.Text = "Delete";
            this.btn_DelDrink.UseVisualStyleBackColor = false;
            this.btn_DelDrink.Click += new System.EventHandler(this.btn_DelDrink_Click);
            // 
            // btn_UpdateDrink
            // 
            this.btn_UpdateDrink.BackColor = System.Drawing.Color.Teal;
            this.btn_UpdateDrink.Location = new System.Drawing.Point(352, 327);
            this.btn_UpdateDrink.Name = "btn_UpdateDrink";
            this.btn_UpdateDrink.Size = new System.Drawing.Size(196, 34);
            this.btn_UpdateDrink.TabIndex = 3;
            this.btn_UpdateDrink.Text = "Update";
            this.btn_UpdateDrink.UseVisualStyleBackColor = false;
            this.btn_UpdateDrink.Click += new System.EventHandler(this.btn_UpdateDrink_Click);
            // 
            // dgv_Drinks
            // 
            this.dgv_Drinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drinks.Location = new System.Drawing.Point(13, 19);
            this.dgv_Drinks.Name = "dgv_Drinks";
            this.dgv_Drinks.RowHeadersWidth = 51;
            this.dgv_Drinks.Size = new System.Drawing.Size(333, 394);
            this.dgv_Drinks.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.Location = new System.Drawing.Point(352, 266);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(196, 34);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Teal;
            this.buttonHome.Location = new System.Drawing.Point(354, 275);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(194, 34);
            this.buttonHome.TabIndex = 10;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_UpdateDrink;
        private System.Windows.Forms.DataGridView dgv_Drinks;
        private System.Windows.Forms.Button btn_DelDrink;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_Food;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DelFood;
        private System.Windows.Forms.Button btn_UpdateFood;
        private System.Windows.Forms.DataGridView dgv_Food;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Drink;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.TextBox txtDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button buttonHome;
    }
}