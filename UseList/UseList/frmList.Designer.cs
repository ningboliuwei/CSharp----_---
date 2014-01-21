namespace UseList
{
    partial class frmList
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
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnShowMultiColumn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSelectedItem.Location = new System.Drawing.Point(88, 182);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(95, 12);
            this.lblSelectedItem.TabIndex = 11;
            this.lblSelectedItem.Text = "lblSelectedItem";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 182);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "选中的项：";
            // 
            // btnShowMultiColumn
            // 
            this.btnShowMultiColumn.Location = new System.Drawing.Point(247, 217);
            this.btnShowMultiColumn.Name = "btnShowMultiColumn";
            this.btnShowMultiColumn.Size = new System.Drawing.Size(96, 33);
            this.btnShowMultiColumn.TabIndex = 9;
            this.btnShowMultiColumn.Text = "单/多列显示";
            this.btnShowMultiColumn.UseVisualStyleBackColor = true;
            this.btnShowMultiColumn.Click += new System.EventHandler(this.btnShowMultiColumn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(134, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 33);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "删除项";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加项";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 12;
            this.ListBox1.Location = new System.Drawing.Point(17, 15);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(326, 148);
            this.ListBox1.TabIndex = 5;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnShowMultiColumn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ListBox1);
            this.Name = "Form1";
            this.Text = "列表框示例";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblSelectedItem;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnShowMultiColumn;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListBox ListBox1;
    }
}

