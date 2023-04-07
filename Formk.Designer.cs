namespace Products
{
    partial class Formk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_productname = new System.Windows.Forms.TextBox();
            this.textBox_Descriptions = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descriptions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discontinued";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_productname
            // 
            this.textBox_productname.Location = new System.Drawing.Point(203, 132);
            this.textBox_productname.Name = "textBox_productname";
            this.textBox_productname.Size = new System.Drawing.Size(187, 20);
            this.textBox_productname.TabIndex = 5;
            this.textBox_productname.TextChanged += new System.EventHandler(this.textBox_productname_TextChanged);
            // 
            // textBox_Descriptions
            // 
            this.textBox_Descriptions.Location = new System.Drawing.Point(203, 165);
            this.textBox_Descriptions.Name = "textBox_Descriptions";
            this.textBox_Descriptions.Size = new System.Drawing.Size(187, 20);
            this.textBox_Descriptions.TabIndex = 6;
            this.textBox_Descriptions.TextChanged += new System.EventHandler(this.textBox_Descriptions_TextChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(203, 200);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(187, 20);
            this.textBox_price.TabIndex = 7;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Location = new System.Drawing.Point(203, 232);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(47, 17);
            this.radioButton_true.TabIndex = 8;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "True";
            this.radioButton_true.UseVisualStyleBackColor = true;
            this.radioButton_true.CheckedChanged += new System.EventHandler(this.radioButton_true_CheckedChanged);
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Location = new System.Drawing.Point(305, 232);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(50, 17);
            this.radioButton_false.TabIndex = 9;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "False";
            this.radioButton_false.UseVisualStyleBackColor = true;
            this.radioButton_false.CheckedChanged += new System.EventHandler(this.radioButton_false_CheckedChanged);
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(203, 281);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(187, 23);
            this.button_kaydet.TabIndex = 10;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Formk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.radioButton_false);
            this.Controls.Add(this.radioButton_true);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_Descriptions);
            this.Controls.Add(this.textBox_productname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formk";
            this.Text = "Formk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_productname;
        private System.Windows.Forms.TextBox textBox_Descriptions;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.RadioButton radioButton_false;
        private System.Windows.Forms.Button button_kaydet;
    }
}