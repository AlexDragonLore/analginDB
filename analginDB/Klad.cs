using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analginDB
{
    public partial class Klad : Form
    {
        public Klad()
        {
            InitializeComponent();
        }

        private void choiceTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
        }

        private void Klad_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview("готовый продукт");
            tablesBox.Items.Add("готовый продукт");
            tablesBox.Items.Add("сырье");
            tablesBox.SelectedIndex = 0;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode =
                 DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void tablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numberBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                priceBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string table = tablesBox.SelectedItem.ToString();
                string idcolumnname = dataGridView1.Columns[0].Name;
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string namecolumn = dataGridView1.Columns[2].Name;
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
                }
                namecolumn = dataGridView1.Columns[3].Name;
                if (!String.IsNullOrEmpty(numberBox.Text))
                {
                    try
                    {
                        number = Convert.ToInt32(priceBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(),
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    BDAnalgin.UpdateCell(table, idcolumnname, id, namecolumn, number);
                }
                dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
            }catch
            {
                MessageBox.Show("Выбирите строку которую хотите поменять",
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
