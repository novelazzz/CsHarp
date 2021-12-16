namespace Basic_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sinBut = new System.Windows.Forms.Button();
            this.tanBut = new System.Windows.Forms.Button();
            this.cosBut = new System.Windows.Forms.Button();
            this.uzeriBut = new System.Windows.Forms.Button();
            this.tersBut = new System.Windows.Forms.Button();
            this.logBut = new System.Windows.Forms.Button();
            this.uzeri2But = new System.Windows.Forms.Button();
            this.lnBut = new System.Windows.Forms.Button();
            this.uzeri3But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(58, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(322, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 10;
            // 
            // sinBut
            // 
            this.sinBut.Location = new System.Drawing.Point(58, 249);
            this.sinBut.Name = "sinBut";
            this.sinBut.Size = new System.Drawing.Size(80, 32);
            this.sinBut.TabIndex = 11;
            this.sinBut.Text = "sin";
            this.sinBut.UseVisualStyleBackColor = true;
            this.sinBut.Click += new System.EventHandler(this.sinBut_Click);
            // 
            // tanBut
            // 
            this.tanBut.Location = new System.Drawing.Point(178, 249);
            this.tanBut.Name = "tanBut";
            this.tanBut.Size = new System.Drawing.Size(83, 32);
            this.tanBut.TabIndex = 12;
            this.tanBut.Text = "tan";
            this.tanBut.UseVisualStyleBackColor = true;
            this.tanBut.Click += new System.EventHandler(this.tanBut_Click);
            // 
            // cosBut
            // 
            this.cosBut.Location = new System.Drawing.Point(58, 304);
            this.cosBut.Name = "cosBut";
            this.cosBut.Size = new System.Drawing.Size(80, 32);
            this.cosBut.TabIndex = 13;
            this.cosBut.Text = "cos";
            this.cosBut.UseVisualStyleBackColor = true;
            this.cosBut.Click += new System.EventHandler(this.cosBut_Click);
            // 
            // uzeriBut
            // 
            this.uzeriBut.Location = new System.Drawing.Point(178, 304);
            this.uzeriBut.Name = "uzeriBut";
            this.uzeriBut.Size = new System.Drawing.Size(83, 32);
            this.uzeriBut.TabIndex = 14;
            this.uzeriBut.Text = "x^y";
            this.uzeriBut.UseVisualStyleBackColor = true;
            this.uzeriBut.Click += new System.EventHandler(this.uzeriBut_Click);
            // 
            // tersBut
            // 
            this.tersBut.Location = new System.Drawing.Point(406, 354);
            this.tersBut.Name = "tersBut";
            this.tersBut.Size = new System.Drawing.Size(83, 32);
            this.tersBut.TabIndex = 15;
            this.tersBut.Text = "1/x";
            this.tersBut.UseVisualStyleBackColor = true;
            this.tersBut.Click += new System.EventHandler(this.tersBut_Click);
            // 
            // logBut
            // 
            this.logBut.Location = new System.Drawing.Point(406, 304);
            this.logBut.Name = "logBut";
            this.logBut.Size = new System.Drawing.Size(83, 32);
            this.logBut.TabIndex = 16;
            this.logBut.Text = "log";
            this.logBut.UseVisualStyleBackColor = true;
            this.logBut.Click += new System.EventHandler(this.logBut_Click);
            // 
            // uzeri2But
            // 
            this.uzeri2But.Location = new System.Drawing.Point(297, 304);
            this.uzeri2But.Name = "uzeri2But";
            this.uzeri2But.Size = new System.Drawing.Size(83, 32);
            this.uzeri2But.TabIndex = 17;
            this.uzeri2But.Text = "x^2";
            this.uzeri2But.UseVisualStyleBackColor = true;
            this.uzeri2But.Click += new System.EventHandler(this.uzeri2But_Click);
            // 
            // lnBut
            // 
            this.lnBut.Location = new System.Drawing.Point(406, 249);
            this.lnBut.Name = "lnBut";
            this.lnBut.Size = new System.Drawing.Size(83, 32);
            this.lnBut.TabIndex = 18;
            this.lnBut.Text = "ln";
            this.lnBut.UseVisualStyleBackColor = true;
            this.lnBut.Click += new System.EventHandler(this.lnBut_Click);
            // 
            // uzeri3But
            // 
            this.uzeri3But.Location = new System.Drawing.Point(297, 249);
            this.uzeri3But.Name = "uzeri3But";
            this.uzeri3But.Size = new System.Drawing.Size(83, 32);
            this.uzeri3But.TabIndex = 19;
            this.uzeri3But.Text = "x^3";
            this.uzeri3But.UseVisualStyleBackColor = true;
            this.uzeri3But.Click += new System.EventHandler(this.uzeri3But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 430);
            this.Controls.Add(this.uzeri3But);
            this.Controls.Add(this.lnBut);
            this.Controls.Add(this.uzeri2But);
            this.Controls.Add(this.logBut);
            this.Controls.Add(this.tersBut);
            this.Controls.Add(this.uzeriBut);
            this.Controls.Add(this.cosBut);
            this.Controls.Add(this.tanBut);
            this.Controls.Add(this.sinBut);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sinBut;
        private System.Windows.Forms.Button tanBut;
        private System.Windows.Forms.Button cosBut;
        private System.Windows.Forms.Button uzeriBut;
        private System.Windows.Forms.Button tersBut;
        private System.Windows.Forms.Button logBut;
        private System.Windows.Forms.Button uzeri2But;
        private System.Windows.Forms.Button lnBut;
        private System.Windows.Forms.Button uzeri3But;
    }
}

