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
    public partial class Admin : Form
    {
        DataSet ds = new DataSet();
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                BDAnalgin.UpdateTable(tablesBox.SelectedItem.ToString(), dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void choiceTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            tablesBox.Items.AddRange(BDAnalgin.ShowTables());
            tablesBox.SelectedIndex = 0;
            dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (DialogResult.Yes == MessageBox.Show("Хотите выбранную строку id - " +
                    (dataGridView1.SelectedRows[0].Index + 1).ToString(),
                       "удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    string idcolumnname = dataGridView1.Columns[0].Name;

                    BDAnalgin.DeleteRow(tablesBox.SelectedItem.ToString(), idcolumnname, dataGridView1.SelectedRows[0].Index + 1);

                    dataGridView1.DataSource = BDAnalgin.MySQL_ToDatagridview(tablesBox.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void tablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
