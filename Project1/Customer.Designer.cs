namespace Project1
{
    partial class Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phonelb = new System.Windows.Forms.Label();
            this.emaillb = new System.Windows.Forms.Label();
            this.namelb = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proceedbtn);
            this.groupBox1.Controls.Add(this.phoneTB);
            this.groupBox1.Controls.Add(this.emailTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.phonelb);
            this.groupBox1.Controls.Add(this.emaillb);
            this.groupBox1.Controls.Add(this.namelb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(113, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.Location = new System.Drawing.Point(34, 178);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(120, 38);
            this.phonelb.TabIndex = 2;
            this.phonelb.Text = "Phone:";
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.Location = new System.Drawing.Point(34, 123);
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(107, 38);
            this.emaillb.TabIndex = 1;
            this.emaillb.Text = "Email:";
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.Location = new System.Drawing.Point(34, 63);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(113, 38);
            this.namelb.TabIndex = 0;
            this.namelb.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(153, 63);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(307, 45);
            this.nameTB.TabIndex = 3;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(153, 123);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(307, 45);
            this.emailTB.TabIndex = 4;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(153, 178);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(307, 45);
            this.phoneTB.TabIndex = 5;
            // 
            // proceedbtn
            // 
            this.proceedbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proceedbtn.Location = new System.Drawing.Point(346, 272);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(130, 35);
            this.proceedbtn.TabIndex = 6;
            this.proceedbtn.Text = "Proceed";
            this.proceedbtn.UseVisualStyleBackColor = true;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label phonelb;
        private System.Windows.Forms.Label emaillb;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button proceedbtn;
    }
}