
namespace Project1
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.rdb_pastry = new System.Windows.Forms.RadioButton();
            this.rdb_sandwich = new System.Windows.Forms.RadioButton();
            this.grb_pastry = new System.Windows.Forms.GroupBox();
            this.lst_pastry = new System.Windows.Forms.ListBox();
            this.grb_sandwich = new System.Windows.Forms.GroupBox();
            this.lst_Sandwich = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.grb_pastry.SuspendLayout();
            this.grb_sandwich.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_pastry
            // 
            this.rdb_pastry.AutoSize = true;
            this.rdb_pastry.BackColor = System.Drawing.Color.Transparent;
            this.rdb_pastry.Checked = true;
            this.rdb_pastry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_pastry.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_pastry.Location = new System.Drawing.Point(22, 151);
            this.rdb_pastry.Name = "rdb_pastry";
            this.rdb_pastry.Size = new System.Drawing.Size(103, 29);
            this.rdb_pastry.TabIndex = 0;
            this.rdb_pastry.TabStop = true;
            this.rdb_pastry.Text = "Pastries";
            this.rdb_pastry.UseVisualStyleBackColor = false;
            this.rdb_pastry.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_sandwich
            // 
            this.rdb_sandwich.AutoSize = true;
            this.rdb_sandwich.BackColor = System.Drawing.Color.Transparent;
            this.rdb_sandwich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_sandwich.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_sandwich.Location = new System.Drawing.Point(218, 151);
            this.rdb_sandwich.Name = "rdb_sandwich";
            this.rdb_sandwich.Size = new System.Drawing.Size(140, 29);
            this.rdb_sandwich.TabIndex = 1;
            this.rdb_sandwich.Text = "Sandwiches";
            this.rdb_sandwich.UseVisualStyleBackColor = false;
            this.rdb_sandwich.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // grb_pastry
            // 
            this.grb_pastry.BackColor = System.Drawing.Color.Transparent;
            this.grb_pastry.Controls.Add(this.lst_pastry);
            this.grb_pastry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_pastry.ForeColor = System.Drawing.SystemColors.Control;
            this.grb_pastry.Location = new System.Drawing.Point(22, 195);
            this.grb_pastry.Name = "grb_pastry";
            this.grb_pastry.Size = new System.Drawing.Size(162, 216);
            this.grb_pastry.TabIndex = 2;
            this.grb_pastry.TabStop = false;
            this.grb_pastry.Text = "Pastry Selection";
            this.grb_pastry.Visible = false;
            // 
            // lst_pastry
            // 
            this.lst_pastry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_pastry.FormattingEnabled = true;
            this.lst_pastry.ItemHeight = 25;
            this.lst_pastry.Location = new System.Drawing.Point(6, 25);
            this.lst_pastry.Name = "lst_pastry";
            this.lst_pastry.Size = new System.Drawing.Size(150, 179);
            this.lst_pastry.TabIndex = 0;
            // 
            // grb_sandwich
            // 
            this.grb_sandwich.BackColor = System.Drawing.Color.Transparent;
            this.grb_sandwich.Controls.Add(this.lst_Sandwich);
            this.grb_sandwich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_sandwich.ForeColor = System.Drawing.SystemColors.Control;
            this.grb_sandwich.Location = new System.Drawing.Point(218, 195);
            this.grb_sandwich.Name = "grb_sandwich";
            this.grb_sandwich.Size = new System.Drawing.Size(165, 216);
            this.grb_sandwich.TabIndex = 3;
            this.grb_sandwich.TabStop = false;
            this.grb_sandwich.Text = "Sandwich Selection";
            this.grb_sandwich.Visible = false;
            // 
            // lst_Sandwich
            // 
            this.lst_Sandwich.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_Sandwich.FormattingEnabled = true;
            this.lst_Sandwich.ItemHeight = 25;
            this.lst_Sandwich.Location = new System.Drawing.Point(6, 25);
            this.lst_Sandwich.Name = "lst_Sandwich";
            this.lst_Sandwich.Size = new System.Drawing.Size(153, 179);
            this.lst_Sandwich.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Teal;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Location = new System.Drawing.Point(136, 431);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 34);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add to cart";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "A bite of deliciousness.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Living the Sweet Life";
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Teal;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeBtn.Location = new System.Drawing.Point(527, 441);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(120, 34);
            this.homeBtn.TabIndex = 8;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 575);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.grb_sandwich);
            this.Controls.Add(this.grb_pastry);
            this.Controls.Add(this.rdb_sandwich);
            this.Controls.Add(this.rdb_pastry);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.grb_pastry.ResumeLayout(false);
            this.grb_sandwich.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_pastry;
        private System.Windows.Forms.RadioButton rdb_sandwich;
        private System.Windows.Forms.GroupBox grb_pastry;
        private System.Windows.Forms.GroupBox grb_sandwich;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_pastry;
        private System.Windows.Forms.ListBox lst_Sandwich;
        private System.Windows.Forms.Button homeBtn;
    }
}