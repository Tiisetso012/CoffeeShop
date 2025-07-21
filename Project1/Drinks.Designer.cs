
namespace Project1
{
    partial class Drinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drinks));
            this.rdb_coffee = new System.Windows.Forms.RadioButton();
            this.rdb_tea = new System.Windows.Forms.RadioButton();
            this.grb_Coffee = new System.Windows.Forms.GroupBox();
            this.lst_Coffee = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_Tea = new System.Windows.Forms.GroupBox();
            this.lst_Tea = new System.Windows.Forms.ListBox();
            this.homeBTN = new System.Windows.Forms.Button();
            this.grb_Coffee.SuspendLayout();
            this.grb_Tea.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_coffee
            // 
            this.rdb_coffee.AutoSize = true;
            this.rdb_coffee.BackColor = System.Drawing.Color.Transparent;
            this.rdb_coffee.Checked = true;
            this.rdb_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_coffee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_coffee.Location = new System.Drawing.Point(12, 134);
            this.rdb_coffee.Name = "rdb_coffee";
            this.rdb_coffee.Size = new System.Drawing.Size(91, 29);
            this.rdb_coffee.TabIndex = 0;
            this.rdb_coffee.TabStop = true;
            this.rdb_coffee.Text = "Coffee";
            this.rdb_coffee.UseVisualStyleBackColor = false;
            this.rdb_coffee.CheckedChanged += new System.EventHandler(this.rdb_coffee_CheckedChanged);
            // 
            // rdb_tea
            // 
            this.rdb_tea.AutoSize = true;
            this.rdb_tea.BackColor = System.Drawing.Color.Transparent;
            this.rdb_tea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_tea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdb_tea.Location = new System.Drawing.Point(245, 134);
            this.rdb_tea.Name = "rdb_tea";
            this.rdb_tea.Size = new System.Drawing.Size(68, 29);
            this.rdb_tea.TabIndex = 1;
            this.rdb_tea.Text = "Tea";
            this.rdb_tea.UseVisualStyleBackColor = false;
            this.rdb_tea.CheckedChanged += new System.EventHandler(this.rdb_tea_CheckedChanged);
            // 
            // grb_Coffee
            // 
            this.grb_Coffee.BackColor = System.Drawing.Color.Transparent;
            this.grb_Coffee.Controls.Add(this.lst_Coffee);
            this.grb_Coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Coffee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb_Coffee.Location = new System.Drawing.Point(12, 169);
            this.grb_Coffee.Name = "grb_Coffee";
            this.grb_Coffee.Size = new System.Drawing.Size(176, 238);
            this.grb_Coffee.TabIndex = 2;
            this.grb_Coffee.TabStop = false;
            this.grb_Coffee.Text = "Coffee Selection";
            this.grb_Coffee.Visible = false;
            // 
            // lst_Coffee
            // 
            this.lst_Coffee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_Coffee.FormattingEnabled = true;
            this.lst_Coffee.ItemHeight = 25;
            this.lst_Coffee.Location = new System.Drawing.Point(6, 25);
            this.lst_Coffee.Name = "lst_Coffee";
            this.lst_Coffee.Size = new System.Drawing.Size(164, 204);
            this.lst_Coffee.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Teal;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(157, 429);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 35);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add to cart";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pouring in Your Cup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Develop a new taste new different experience.";
            // 
            // grb_Tea
            // 
            this.grb_Tea.BackColor = System.Drawing.Color.Transparent;
            this.grb_Tea.Controls.Add(this.lst_Tea);
            this.grb_Tea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Tea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb_Tea.Location = new System.Drawing.Point(245, 169);
            this.grb_Tea.Name = "grb_Tea";
            this.grb_Tea.Size = new System.Drawing.Size(168, 238);
            this.grb_Tea.TabIndex = 3;
            this.grb_Tea.TabStop = false;
            this.grb_Tea.Text = "Tea Selection";
            this.grb_Tea.Visible = false;
            // 
            // lst_Tea
            // 
            this.lst_Tea.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lst_Tea.FormattingEnabled = true;
            this.lst_Tea.ItemHeight = 25;
            this.lst_Tea.Location = new System.Drawing.Point(6, 25);
            this.lst_Tea.Name = "lst_Tea";
            this.lst_Tea.Size = new System.Drawing.Size(156, 204);
            this.lst_Tea.TabIndex = 1;
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.Teal;
            this.homeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBTN.Location = new System.Drawing.Point(475, 513);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(107, 35);
            this.homeBTN.TabIndex = 8;
            this.homeBTN.Text = "Home";
            this.homeBTN.UseVisualStyleBackColor = false;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 572);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.grb_Tea);
            this.Controls.Add(this.grb_Coffee);
            this.Controls.Add(this.rdb_tea);
            this.Controls.Add(this.rdb_coffee);
            this.Name = "Drinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drinks";
            this.Load += new System.EventHandler(this.Drinks_Load);
            this.grb_Coffee.ResumeLayout(false);
            this.grb_Tea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_coffee;
        private System.Windows.Forms.RadioButton rdb_tea;
        private System.Windows.Forms.GroupBox grb_Coffee;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_Coffee;
        private System.Windows.Forms.GroupBox grb_Tea;
        private System.Windows.Forms.ListBox lst_Tea;
        private System.Windows.Forms.Button homeBTN;
    }
}