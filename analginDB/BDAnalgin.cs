using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analginDB
{
    class BDAnalgin
    {
        static MySqlConnection mysqlCon;

        static public void OpenBD()
        {
            string connectionMySQL = "server=localhost;user=root;database=analgin;password=Sashka981;";
            mysqlCon = new MySqlConnection(connectionMySQL);
            mysqlCon.Open();
        }
        static public DataTable MySQL_ToDatagridview(string tableName)
        {

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from `" + tableName + "`";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }
        static public DataTable TableOperatingMode()
        {

            string sqlSelectAll = "SELECT DISTINCT `Режим работы оборудования`.`idРежим работы оборудования`, " +
              "`Режим работы оборудования`.`режим`, " +
              "`Оборудование`.`Наименование`, `Режим работы оборудования`.`Время(мин)`, " +
              "`Режим работы оборудования`.`Температура(°C)`, `Режим работы оборудования`.`Давление(бар)`, " +
              "`Режим работы оборудования`.`Напряжение(Вт)`, `Режим работы оборудования`.`Обьем(литры)`" +
              "from `Режим работы оборудования` " +
            "join `Оборудование` on `Режим работы оборудования`.`Оборудование_idОборудование` = `Оборудование`.`idОборудование`";
            MySqlDataAdapter MyDA = new MySqlDataAdapter(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }
        static public DataTable TableRecipe()
        {

            string sqlSelectAll = "SELECT DISTINCT `рецепт`.`idРецепт`, `рецепт`.`количество(г)`, " +
                "`готовый продукт`.`Наименование`, `сырье`.`Наименование` from `рецепт`"+
                "join `готовый продукт` on `рецепт`.`готовый продукт_idготовый продукт` = `готовый продукт`.`idготовый продукт` " +
            "join `сырье` on `рецепт`.`сырье_idсырье` = `сырье`.`idсырье`";
            MySqlDataAdapter MyDA = new MySqlDataAdapter(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }
        static public DataTable TeachLine()
        {
            string sqlSelectAll = "SELECT DISTINCT `Технологическая линия`.`idТехнологическая линия`, " +
                "`готовый продукт`.`Наименование`, `сырье`.`Наименование`, " +
                "`стадия`.`Наименование`, `Режим работы оборудования`.`режим`, `Оборудование`.`Наименование`, " +
                "`Режим работы оборудования`.`Время(мин)`, `Режим работы оборудования`.`Температура(°C)`, " +
                "`Режим работы оборудования`.`Давление(бар)`, `Режим работы оборудования`.`Напряжение(Вт)`, " +
                "`Режим работы оборудования`.`Обьем(литры)` from `Технологическая линия`" +
                "join `готовый продукт` on `Технологическая линия`.`готовый продукт_idготовый продукт` = `готовый продукт`.`idготовый продукт` " +
                "join `Сырье` on `Технологическая линия`.`Сырье_idсырье` = `сырье`.`idсырье`" +
                "join `стадия` on `Технологическая линия`.`Стадия_idСтадия` = `стадия`.`idСтадия`" +
                "join `Режим работы оборудования` on `Технологическая линия`.`Режим работы оборудования_idРежим работы оборудования` = " +
                "`Режим работы оборудования`.`idРежим работы оборудования`" +
                "join `Оборудование` on `Режим работы оборудования`.`Оборудование_idОборудование` = `Оборудование`.`idОборудование`";
            MySqlDataAdapter MyDA = new MySqlDataAdapter(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }

        static public string MySQL_ReadRow(string tableName, string namecolumn, string nameСell, string necessaryInformation)
        {

            string selectCell = "SELECT `" + necessaryInformation + "` FROM `" + tableName + "` WHERE (`" + namecolumn + "` = '" + nameСell + "')";
            MySqlCommand command = new MySqlCommand(selectCell, mysqlCon);

            return command.ExecuteScalar().ToString();
        }
        static public void UpdateCell(string table, string idcolumnname, string id, string namecolumn, int number)
        {
            string updateCell = "UPDATE `" + table + "` SET `" + namecolumn + "` = '" + number + "' WHERE(`" + idcolumnname + "` = '" + id + "')";
            MySqlCommand command = new MySqlCommand(updateCell, mysqlCon);
            command.ExecuteNonQuery();
        }

        static public void UpdateTable(string table, DataTable dt)
        {
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommandBuilder commbuilder = new MySqlCommandBuilder(adapt);
            adapt.SelectCommand = new MySqlCommand("SELECT * FROM `" + table + "`", mysqlCon);
            MySqlCommand command = new MySqlCommand();
            ///adapt.UpdateCommand = command;
            adapt.Update(dt);
            dt.AcceptChanges();
        }
        static public void DeleteRow(string table, string idcolumnname, int id)
        {
            string deletewRow = "DELETE FROM `" + table + "`WHERE(`" + idcolumnname + "` = '" + id + "')";
            MySqlCommand command = new MySqlCommand(deletewRow, mysqlCon);
            command.ExecuteNonQuery();
        }

        static public string[] ShowTables()
        {

            MySqlCommand command = new MySqlCommand("SHOW TABLES", mysqlCon);

            MySqlDataReader reader = command.ExecuteReader();

            List<string> tables = new List<string>();
            while (reader.Read())
            {
                tables.Add(String.Format("{0}", reader[0]));
            }

            reader.Close();
            string[] tablesString = new string[tables.Count];

            int counter = 0;
            foreach (string table in tables)
            {
                tablesString[counter++] = table;
            }

            return tablesString;
        }
        static public DataTable GetRecipe(int name)
        {
            ///'Готовый продукт_idГотовый продукт from`, `сырье_idСырье`, `количество(г)`
            string sqlSelectAll = "SELECT DISTINCT " +
                "`готовый продукт`.`Наименование`,`рецепт`.`количество(г)`,  `сырье`.`Наименование` from `рецепт`" +
                "join `готовый продукт` on `рецепт`.`готовый продукт_idготовый продукт` = `готовый продукт`.`idготовый продукт` " +
            "join `сырье` on `рецепт`.`сырье_idсырье` = `сырье`.`idсырье`"+
            ///"WHERE `готовый продукт`.`Наименование` = `" + name + "`";
            "WHERE `рецепт`.`готовый продукт_idготовый продукт` = " + name;
            MySqlDataAdapter MyDA = new MySqlDataAdapter(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }
        static public DataTable GetTeachLine(int nameid)
        {
            ///'Готовый продукт_idГотовый продукт from`, `сырье_idСырье`, `количество(г)`
            string sqlSelectAll = "SELECT DISTINCT `Технологическая линия`.`idТехнологическая линия`, " +
                "`готовый продукт`.`Наименование`, `сырье`.`Наименование`, " +
                "`стадия`.`Наименование`, `Режим работы оборудования`.`режим`, `Оборудование`.`Наименование`, " +
                "`Режим работы оборудования`.`Время(мин)`, `Режим работы оборудования`.`Температура(°C)`, " +
                "`Режим работы оборудования`.`Давление(бар)`, `Режим работы оборудования`.`Напряжение(Вт)`, " +
                "`Режим работы оборудования`.`Обьем(литры)` from `Технологическая линия` " +
                "join `готовый продукт` on `Технологическая линия`.`готовый продукт_idготовый продукт` = `готовый продукт`.`idготовый продукт` " +
                "join `Сырье` on `Технологическая линия`.`Сырье_idсырье` = `сырье`.`idсырье`" +
                "join `стадия` on `Технологическая линия`.`Стадия_idСтадия` = `стадия`.`idСтадия`" +
                "join `Режим работы оборудования` on `Технологическая линия`.`Режим работы оборудования_idРежим работы оборудования` = " +
                "`Режим работы оборудования`.`idРежим работы оборудования`" +
                "join `Оборудование` on `Режим работы оборудования`.`Оборудование_idОборудование` = `Оборудование`.`idОборудование`" +
            "WHERE `Технологическая линия`.`готовый продукт_idготовый продукт` = " + nameid +
            " ORDER BY `Технологическая линия`.`idТехнологическая линия`";
            MySqlDataAdapter MyDA = new MySqlDataAdapter(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);
            return table;
        }
    }
}

