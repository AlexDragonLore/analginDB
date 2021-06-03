namespace analginDB
{
    partial class Klad
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
            this.tablesBox = new System.Windows.Forms.ComboBox();
            this.choiceTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tablesBox
            // 
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.Location = new System.Drawing.Point(12, 9);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(200, 21);
            this.tablesBox.TabIndex = 1;
            this.tablesBox.SelectedIndexChanged += new System.EventHandler(this.tablesBox_SelectedIndexChanged);
            // 
            // choiceTable
            // 
            this.choiceTable.Location = new System.Drawing.Point(218, 9);
            this.choiceTable.Name = "choiceTable";
            this.choiceTable.Size = new System.Drawing.Size(246, 23);
            this.choiceTable.TabIndex = 2;
            this.choiceTable.Text = "Открыть выбранную таблицу";
            this.choiceTable.UseVisualStyleBackColor = true;
            this.choiceTable.Click += new System.EventHandler(this.choiceTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(12, 366);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(92, 20);
            this.numberBox.TabIndex = 9;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(9, 350);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(65, 13);
            this.number.TabIndex = 8;
            this.number.Text = "количество";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(110, 366);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(92, 20);
            this.priceBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "цена";
            // 
            // Klad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 400);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choiceTable);
            this.Controls.Add(this.tablesBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Klad";
            this.Text = "Klad";
            this.Load += new System.EventHandler(this.Klad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tablesBox;
        private System.Windows.Forms.Button choiceTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label1;
    }
}