using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analginDB
{
    public partial class TLine : Form
    {
        public TLine()
        {
            InitializeComponent();
        }


        private void choiceTable_Click(object sender, EventArgs e)
        {
            if ("Режим работы оборудования" == tablesBox.SelectedItem.ToString())
            {
                dataGridView1.DataSource = BDAnalgin.TableOperatingMode();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Режим работы оборудования";
            }
            else if ("технологическая линия" == tablesBox.SelectedItem.ToString())
            {
                dataGridView1.DataSource = BDAnalgin.TeachLine();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Готовый продукт";
                dataGridView1.Columns[2].HeaderText = "Сырье";
                dataGridView1.Columns[3].HeaderText = "Стадия";
                dataGridView1.Columns[4].HeaderText = "Режим работы оборудования";
                dataGridView1.Columns[5].HeaderText = "Название Оборудования";
            }
            else if ("рецепт" == tablesBox.SelectedItem.ToString())
            {
                dataGridView1.DataSource = BDAnalgin.TableRecipe();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Готовый продукт";
                dataGridView1.Columns[3].HeaderText = "Сырье";
            }
            else
            {
                dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
            }
        }

        private void TLine_Load(object sender, EventArgs e)
        {
            string[] tables = new string[] { "готовый продукт", "сырье",
                "Режим работы оборудования", "оборудование", "рецепт", "стадия", "технологическая линия" };
            tablesBox.Items.AddRange(tables);
            tablesBox.SelectedIndex = 0;
            dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
            dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode =
                 DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tablesBox.SelectedItem.ToString() == "готовый продукт" || tablesBox.SelectedItem.ToString() == "сырье")
            {
                try
                {
                    string table = tablesBox.SelectedItem.ToString();
                    string idcolumnname = dataGridView1.Columns[0].Name;
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string namecolumn = null;
                    if (tablesBox.SelectedItem.ToString() == "сырье")
                    {
                        namecolumn = dataGridView1.Columns[2].Name;
                    }
                    else
                    {
                        namecolumn = dataGridView1.Columns[3].Name;
                    }
                    int number = 0;
                    if (!String.IsNullOrEmpty(numberBox.Text))
                    {
                        try
                        {
                            number = Convert.ToInt32(numberBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(),
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        BDAnalgin.UpdateCell(table, idcolumnname, id, namecolumn, number);
                        choiceTable_Click(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Выбирите строку которую хотите поменять",
                          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("В этой таблице вы не можете менять данные",
                          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablesBox.SelectedItem.ToString() == "готовый продукт" || tablesBox.SelectedItem.ToString() == "сырье")
            {
                try
                {
                    if (tablesBox.SelectedItem.ToString() == "сырье")
                    {
                        numberBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    }
                    else
                    {
                        numberBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                           "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            recipe calculatewRecipe = new recipe();
            calculatewRecipe.Show();
        }
    }
}
