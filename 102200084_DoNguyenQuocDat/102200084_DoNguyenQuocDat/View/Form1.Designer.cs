namespace _102200084_DoNguyenQuocDat.View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxHP = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butSort = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxHP
            // 
            this.comboBoxHP.FormattingEnabled = true;
            this.comboBoxHP.Location = new System.Drawing.Point(140, 26);
            this.comboBoxHP.Name = "comboBoxHP";
            this.comboBoxHP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHP.TabIndex = 2;
            this.comboBoxHP.SelectedIndexChanged += new System.EventHandler(this.comboBoxHP_SelectedIndexChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(586, 385);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Học phần";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(123, 386);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(57, 23);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(224, 386);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(77, 23);
            this.butUpdate.TabIndex = 6;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(353, 386);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(67, 23);
            this.butDel.TabIndex = 6;
            this.butDel.Text = "Del";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(472, 386);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(72, 23);
            this.butSort.TabIndex = 6;
            this.butSort.Text = "Sort";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(729, 23);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 6;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.comboBoxHP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxHP;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butSearch;
    }
}