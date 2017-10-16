namespace Wyznaczniki
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xProperty = new System.Windows.Forms.TextBox();
            this.yProperty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.freeWords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.TextBox();
            this.wx = new System.Windows.Forms.TextBox();
            this.wy = new System.Windows.Forms.TextBox();
            this.xSum = new System.Windows.Forms.TextBox();
            this.ySum = new System.Windows.Forms.TextBox();
            this.xProperty1 = new System.Windows.Forms.TextBox();
            this.yProperty1 = new System.Windows.Forms.TextBox();
            this.freeWords1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Pokaż wykres";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(187, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y = ";
            // 
            // xProperty
            // 
            this.xProperty.Location = new System.Drawing.Point(6, 22);
            this.xProperty.Multiline = true;
            this.xProperty.Name = "xProperty";
            this.xProperty.Size = new System.Drawing.Size(71, 34);
            this.xProperty.TabIndex = 4;
            // 
            // yProperty
            // 
            this.yProperty.Location = new System.Drawing.Point(110, 22);
            this.yProperty.Multiline = true;
            this.yProperty.Name = "yProperty";
            this.yProperty.Size = new System.Drawing.Size(71, 34);
            this.yProperty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "W = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wx = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wy = ";
            // 
            // freeWords
            // 
            this.freeWords.Location = new System.Drawing.Point(234, 22);
            this.freeWords.Multiline = true;
            this.freeWords.Name = "freeWords";
            this.freeWords.Size = new System.Drawing.Size(71, 34);
            this.freeWords.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(187, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "X = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(187, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y = ";
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(87, 150);
            this.w.Multiline = true;
            this.w.Name = "w";
            this.w.ReadOnly = true;
            this.w.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.w.Size = new System.Drawing.Size(54, 24);
            this.w.TabIndex = 12;
            // 
            // wx
            // 
            this.wx.Location = new System.Drawing.Point(87, 190);
            this.wx.Multiline = true;
            this.wx.Name = "wx";
            this.wx.ReadOnly = true;
            this.wx.Size = new System.Drawing.Size(54, 24);
            this.wx.TabIndex = 13;
            // 
            // wy
            // 
            this.wy.Location = new System.Drawing.Point(87, 227);
            this.wy.Multiline = true;
            this.wy.Name = "wy";
            this.wy.ReadOnly = true;
            this.wy.Size = new System.Drawing.Size(54, 24);
            this.wy.TabIndex = 14;
            // 
            // xSum
            // 
            this.xSum.Location = new System.Drawing.Point(234, 190);
            this.xSum.Multiline = true;
            this.xSum.Name = "xSum";
            this.xSum.ReadOnly = true;
            this.xSum.Size = new System.Drawing.Size(54, 24);
            this.xSum.TabIndex = 15;
            // 
            // ySum
            // 
            this.ySum.Location = new System.Drawing.Point(234, 227);
            this.ySum.Multiline = true;
            this.ySum.Name = "ySum";
            this.ySum.ReadOnly = true;
            this.ySum.Size = new System.Drawing.Size(54, 24);
            this.ySum.TabIndex = 16;
            // 
            // xProperty1
            // 
            this.xProperty1.Location = new System.Drawing.Point(6, 85);
            this.xProperty1.Multiline = true;
            this.xProperty1.Name = "xProperty1";
            this.xProperty1.Size = new System.Drawing.Size(71, 34);
            this.xProperty1.TabIndex = 17;
            // 
            // yProperty1
            // 
            this.yProperty1.Location = new System.Drawing.Point(120, 85);
            this.yProperty1.Multiline = true;
            this.yProperty1.Name = "yProperty1";
            this.yProperty1.Size = new System.Drawing.Size(71, 34);
            this.yProperty1.TabIndex = 18;
            // 
            // freeWords1
            // 
            this.freeWords1.Location = new System.Drawing.Point(254, 85);
            this.freeWords1.Multiline = true;
            this.freeWords1.Name = "freeWords1";
            this.freeWords1.Size = new System.Drawing.Size(71, 34);
            this.freeWords1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(83, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "X1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(197, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y1 = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 316);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.freeWords1);
            this.Controls.Add(this.yProperty1);
            this.Controls.Add(this.xProperty1);
            this.Controls.Add(this.ySum);
            this.Controls.Add(this.xSum);
            this.Controls.Add(this.wy);
            this.Controls.Add(this.wx);
            this.Controls.Add(this.w);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.freeWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yProperty);
            this.Controls.Add(this.xProperty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xProperty;
        private System.Windows.Forms.TextBox yProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox freeWords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox w;
        private System.Windows.Forms.TextBox wx;
        private System.Windows.Forms.TextBox wy;
        private System.Windows.Forms.TextBox xSum;
        private System.Windows.Forms.TextBox ySum;
        private System.Windows.Forms.TextBox xProperty1;
        private System.Windows.Forms.TextBox yProperty1;
        private System.Windows.Forms.TextBox freeWords1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

