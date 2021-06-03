namespace analginDB
{
    partial class TLine
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
            this.choiceTable = new System.Windows.Forms.Button();
            this.tablesBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceTable
            // 
            this.choiceTable.Location = new System.Drawing.Point(218, 3);
            this.choiceTable.Name = "choiceTable";
            this.choiceTable.Size = new System.Drawing.Size(246, 23);
            this.choiceTable.TabIndex = 7;
            this.choiceTable.Text = "Открыть выбранную таблицу";
            this.choiceTable.UseVisualStyleBackColor = true;
            this.choiceTable.Click += new System.EventHandler(this.choiceTable_Click);
            // 
            // tablesBox
            // 
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.Location = new System.Drawing.Point(12, 3);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(200, 21);
            this.tablesBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 397);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(12, 449);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(92, 20);
            this.numberBox.TabIndex = 11;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(12, 433);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(65, 13);
            this.number.TabIndex = 10;
            this.number.Text = "количество";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "Открыть меню для просмотра рецептов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choiceTable);
            this.Controls.Add(this.tablesBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TLine";
            this.Text = "TLine";
            this.Load += new System.EventHandler(this.TLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choiceTable;
        private System.Windows.Forms.ComboBox tablesBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button button2;
    }
}