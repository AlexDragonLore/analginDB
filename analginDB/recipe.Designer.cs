namespace analginDB
{
    partial class recipe
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablesBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textRecipe = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Вернуться к таблицам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Показать техгологическую линию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберете готовый продукт";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablesBox
            // 
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.Location = new System.Drawing.Point(478, 33);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(186, 21);
            this.tablesBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Введите нужное количество\r\nготового продукта (в кг)\r\nминимум 2 кг\r\n";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(478, 99);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(186, 20);
            this.textNumber.TabIndex = 20;
            this.textNumber.Text = "2.0";
            // 
            // textRecipe
            // 
            this.textRecipe.Location = new System.Drawing.Point(12, 12);
            this.textRecipe.Multiline = true;
            this.textRecipe.Name = "textRecipe";
            this.textRecipe.Size = new System.Drawing.Size(457, 567);
            this.textRecipe.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Посчитать хавтит ли сырья на складе";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 591);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textRecipe);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "recipe";
            this.Text = "recipe";
            this.Load += new System.EventHandler(this.recipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tablesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textRecipe;
        private System.Windows.Forms.Button button3;
    }
}