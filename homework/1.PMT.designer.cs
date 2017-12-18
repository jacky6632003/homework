namespace myhomework2017622
{
    partial class frmPMT
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPMT));
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YTMBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.tatol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EMAILBTN = new System.Windows.Forms.Button();
            this.EMAIL = new System.Windows.Forms.Label();
            this.EMAILBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MoneyBox
            // 
            this.MoneyBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MoneyBox.Location = new System.Drawing.Point(246, 65);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(208, 43);
            this.MoneyBox.TabIndex = 0;
            this.MoneyBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "YTM(%):";
            // 
            // YTMBox
            // 
            this.YTMBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YTMBox.Location = new System.Drawing.Point(246, 136);
            this.YTMBox.Name = "YTMBox";
            this.YTMBox.Size = new System.Drawing.Size(208, 43);
            this.YTMBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "YEARS:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearBox.Location = new System.Drawing.Point(246, 205);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(208, 43);
            this.yearBox.TabIndex = 4;
            this.yearBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tatol
            // 
            this.tatol.AutoSize = true;
            this.tatol.BackColor = System.Drawing.Color.Transparent;
            this.tatol.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tatol.Location = new System.Drawing.Point(31, 273);
            this.tatol.Name = "tatol";
            this.tatol.Size = new System.Drawing.Size(99, 35);
            this.tatol.TabIndex = 6;
            this.tatol.Text = "TATAL";
            this.tatol.Click += new System.EventHandler(this.tatol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(45, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 83);
            this.button1.TabIndex = 10;
            this.button1.Text = "TATOL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(307, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 83);
            this.button2.TabIndex = 8;
            this.button2.Text = "interest";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(563, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 83);
            this.button3.TabIndex = 9;
            this.button3.Text = "PMT TATOL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EMAILBTN
            // 
            this.EMAILBTN.Font = new System.Drawing.Font("微軟正黑體", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EMAILBTN.Location = new System.Drawing.Point(594, 25);
            this.EMAILBTN.Name = "EMAILBTN";
            this.EMAILBTN.Size = new System.Drawing.Size(340, 232);
            this.EMAILBTN.TabIndex = 11;
            this.EMAILBTN.Text = "EMAIL";
            this.EMAILBTN.UseVisualStyleBackColor = true;
            this.EMAILBTN.Click += new System.EventHandler(this.EMAILBTN_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.BackColor = System.Drawing.Color.Transparent;
            this.EMAIL.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EMAIL.Location = new System.Drawing.Point(31, 333);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(105, 35);
            this.EMAIL.TabIndex = 12;
            this.EMAIL.Text = "EMAIL:";
            // 
            // EMAILBox1
            // 
            this.EMAILBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EMAILBox1.Location = new System.Drawing.Point(246, 325);
            this.EMAILBox1.Name = "EMAILBox1";
            this.EMAILBox1.Size = new System.Drawing.Size(323, 43);
            this.EMAILBox1.TabIndex = 13;
            this.EMAILBox1.TextChanged += new System.EventHandler(this.EMAILBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 546);
            this.Controls.Add(this.EMAILBox1);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.EMAILBTN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tatol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YTMBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YTMBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label tatol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EMAILBTN;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.TextBox EMAILBox1;
    }
}

