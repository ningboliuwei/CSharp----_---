namespace Pseudorandom
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(113, 12);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "产生多少个随机数？";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(140, 9);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(136, 21);
            this.txtNumbers.TabIndex = 7;
            this.txtNumbers.Text = "100";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(28, 89);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(368, 208);
            this.RichTextBox1.TabIndex = 5;
            this.RichTextBox1.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(300, 9);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 56);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "产生随机数";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "初始种子：";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(140, 49);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(136, 21);
            this.txtSeed.TabIndex = 6;
            this.txtSeed.Text = "34";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 309);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtSeed);
            this.Name = "Form1";
            this.Text = "运用离散数学算法产生随机数";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNumbers;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSeed;
    }
}

