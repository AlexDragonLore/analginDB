namespace analginDB
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choiceTable = new System.Windows.Forms.Button();
            this.tablesBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 397);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // choiceTable
            // 
            this.choiceTable.Location = new System.Drawing.Point(201, 10);
            this.choiceTable.Name = "choiceTable";
            this.choiceTable.Size = new System.Drawing.Size(117, 23);
            this.choiceTable.TabIndex = 4;
            this.choiceTable.Text = "Открыть выбранную таблицу";
            this.choiceTable.UseVisualStyleBackColor = true;
            this.choiceTable.Click += new System.EventHandler(this.choiceTable_Click);
            // 
            // tablesBox
            // 
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.Location = new System.Drawing.Point(9, 12);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(186, 21);
            this.tablesBox.TabIndex = 3;
            this.tablesBox.SelectedIndexChanged += new System.EventHandler(this.tablesBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить выбранную строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.choiceTable);
            this.Controls.Add(this.tablesBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button choiceTable;
        private System.Windows.Forms.ComboBox tablesBox;
        private System.Windows.Forms.Button button2;
    }
}