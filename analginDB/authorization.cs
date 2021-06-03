using MySql.Data.MySqlClient;
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
    public partial class Authorization : Form
    {

        public Authorization()
        {
           InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string loginAuthorization = loginBox.Text;
                string passwordAuthorization = passwordBox.Text;
                if (BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Администратор", "Логин") == loginAuthorization &&
                    BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Администратор", "Пароль") == passwordAuthorization)
                {
                    Admin admin = new Admin();
                    admin.Show();

                }
                else if (BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Кладовщик", "Логин") == loginAuthorization &&
                    BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Кладовщик", "Пароль") == passwordAuthorization)
                {
                    ///Authorization.ActiveForm.Visible = false;
                    Klad klad = new Klad();
                    klad.Show();
                }
                else if (BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Работник технологичемкой линии", "Логин") == loginAuthorization &&
                    BDAnalgin.MySQL_ReadRow("сотрудник", "Должность", "Работник технологичемкой линии", "Пароль") == passwordAuthorization)
                {
                    TLine line = new TLine();
                    line.Show();
                }
                else MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void Authorization_Load(object sender, EventArgs e)
        {
            try
            {
                BDAnalgin.OpenBD();
            }
            catch { MessageBox.Show("База данных не найденна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
