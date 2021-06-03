using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analginDB
{
    public partial class recipe : Form
    {
        public recipe()
        {
            InitializeComponent();
        }
        private void recipe_Load(object sender, EventArgs e)
        {
            tablesBox.Items.Add("Анальгин");
            tablesBox.Items.Add("Баралгин М");
            tablesBox.SelectedIndex = 0;

            textRecipe.Multiline = true;
            textRecipe.ScrollBars = ScrollBars.Vertical;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TLine tables = new TLine();
            tables.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] stadiesLoses = new double[] { 0.49, 0.60, 0.84, 0.92, 0.87, 0.72, 0.68, 0.95 };
            int counter = 0;
            ///int counterForRows = 0;
            try
            {
                if (Convert.ToDouble(textNumber.Text) >= 2)
                {
                    textRecipe.Clear();
                    DataTable dt = BDAnalgin.GetRecipe(tablesBox.SelectedIndex + 1);
                    DataTable tableЬachine = BDAnalgin.MySQL_ToDatagridview("оборудование");
                    double koef = Convert.ToDouble(textNumber.Text) / 2;

                    Dictionary<string, int> numberOfMachines = new Dictionary<string, int>();
                    foreach (DataRow row in tableЬachine.Rows)
                    {
                        numberOfMachines.Add(row["Наименование"].ToString(), Convert.ToInt32(row["Количество"]));
                    }

                    Dictionary<string, double> substance = new Dictionary<string, double>();
                    foreach (DataRow row in dt.Rows)
                    {
                        substance.Add(row["Наименование1"].ToString(), Math.Round(Convert.ToDouble(row["количество(г)"]) * koef, 2));
                    }
                    dt = BDAnalgin.GetTeachLine(tablesBox.SelectedIndex + 1);

                    string tempSubst = null;
                    string temp = null;
                    int number = 1;
                    textRecipe.Text = "Для создания " + textNumber.Text + " кг " + dt.Rows[0]["Наименование"] + "(а) нужно: \r\n";
                    double weightMax = 0;
                    double weight = 0;
                    double time = 0;
                    double timeTMP = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (tempSubst != row["Наименование2"].ToString())
                        {

                            if (number != 1)
                            {
                                if (weight / weightMax <= 1)
                                {
                                    textRecipe.Text += temp + " будет загружен на " + Math.Round(weight / weightMax * 100, 2) + "%";
                                    time += Convert.ToDouble(row["Время(мин)"]);
                                }
                                else
                                {
                                    if (numberOfMachines[temp] >= Math.Ceiling(weight / weightMax))
                                    {
                                        textRecipe.Text += "Придется использовать сразу " + Math.Ceiling(weight / weightMax) + " " + temp + "(а)" +
                                            "\r\nони будут загруженны на" + Math.Round(weight / (weightMax * Math.Ceiling(weight / weightMax)) * 100, 2) + "%";
                                        time += Convert.ToDouble(row["Время(мин)"]);
                                    }
                                    else
                                    {
                                        textRecipe.Text += "Недостаточно оборудования придется запустить установки в " +
                                            Math.Ceiling(Math.Ceiling(weight / weightMax) / numberOfMachines[temp]) + "цикла(ов)";
                                        time += Convert.ToDouble(row["Время(мин)"]) * Math.Ceiling(Math.Ceiling(weight / weightMax) / numberOfMachines[temp]);
                                    }
                                }
                                if (row["Наименование3"].ToString() == "Химический рекатор" || row["Наименование3"].ToString() == "Установка для гидролиза")
                                {
                                    weight *= stadiesLoses[counter++];
                                }
                            }

                            textRecipe.Text += "\r\n\r\n";
                            textRecipe.Text += number++ + " - стадия: " + row["Наименование2"] + "\r\n" +
                        "Оборудование: " + row["Наименование3"].ToString() + ". Настройки: Время(мин) - " + row["Время(мин)"].ToString() +
                        "\r\nТемпература(°C) - " + row["Температура(°C)"].ToString() + " Давление(бар) - " + row["Давление(бар)"].ToString() +
                        " Напряжение(Вт) - " + row["Напряжение(Вт)"].ToString() + "\r\n" +
                        "Необходимые вещества: ";
                            weightMax = Convert.ToDouble(row["Обьем(литры)"]) * 1000;
                        }

                        if (row["Наименование1"].ToString() != "Ничего")
                        {
                            textRecipe.Text += row["Наименование1"].ToString() + " " + substance[row["Наименование1"].ToString()] + " г. \r\n";
                            weight += substance[row["Наименование1"].ToString()];
                        }
                        else
                        {
                            textRecipe.Text += "Только вещество полученное из прошлой стадии.\r\n";
                        }
                        tempSubst = row["Наименование2"].ToString();
                        temp = row["Наименование3"].ToString();
                        timeTMP = Convert.ToDouble(row["Время(мин)"]);
                    }

                    if (weight / weightMax <= 1)
                    {
                        textRecipe.Text += temp + " будет загружен на " + Math.Round(weight / weightMax * 100, 2) + "%";
                        time += timeTMP;
                    }
                    else
                    {
                        if (numberOfMachines[temp] >= Math.Ceiling(weight / weightMax))
                        {
                            textRecipe.Text += "Придется использовать сразу " + Math.Ceiling(weight / weightMax) + " " + temp + "(а)" +
                            "\r\nони будут загруженны на" + Math.Round(weight / (weightMax * Math.Ceiling(weight / weightMax)) * 100, 2) + "%";
                            time += timeTMP;
                        }
                        else
                        {
                            textRecipe.Text += "Недостаточно оборудования придется запустить установки в " +
                                Math.Ceiling(Math.Ceiling(weight / weightMax) / numberOfMachines[temp]) + "цикла(ов)";
                            time += timeTMP * Math.Ceiling(Math.Ceiling(weight / weightMax) / numberOfMachines[temp]);
                        }
                    }

                    textRecipe.Text += "\r\nВрямя требуемое на изготовление :" + time + " мин. ";
                }
                else
                {
                    MessageBox.Show(textNumber.Text.ToString() + " - это введеное вами число, оно должно быть меньше 2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textNumber.Text) >= 2)
                {
                    textRecipe.Clear();
                    DataTable dt = BDAnalgin.GetRecipe(tablesBox.SelectedIndex + 1);
                    double koef = Convert.ToDouble(textNumber.Text) / 2;
                    Dictionary<string, double> substance = new Dictionary<string, double>();

                    foreach (DataRow row in dt.Rows)
                    {
                        substance.Add(row["Наименование1"].ToString(), Math.Round(Convert.ToDouble(row["количество(г)"]) * koef, 2));
                    }

                    dt = BDAnalgin.MySQL_ToDatagridview("сырье");
                    double minVolume = Int32.MaxValue;
                    bool trigger = true;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (substance.ContainsKey(row["Наименование"].ToString()))
                        {
                            if (Convert.ToDouble(row["Количество(г)"]) < substance[row["Наименование"].ToString()])
                            {
                                textRecipe.Text = "Вам нехватает " + (substance[row["Наименование"].ToString()] - Convert.ToDouble(row["Количество(г)"])) + " г " +
                                    row["Наименование"].ToString() + " для начала работы реакторов";
                                trigger = false;
                                break;
                            }
                            else
                            {
                                if (minVolume > (Convert.ToDouble(row["Количество(г)"])) / substance[row["Наименование"].ToString()] * 2)
                                {
                                    minVolume = Math.Round((Convert.ToDouble(row["Количество(г)"])) / substance[row["Наименование"].ToString()] * 2, 2);
                                }
                            }
                        }
                    }
                    if (trigger)
                    {
                        textRecipe.Text += "Сырья на складе хватит для создания " + koef * 2 + " кг " + tablesBox.SelectedItem + "(a)";
                    }
                }
                else
                {
                    MessageBox.Show(textNumber.Text.ToString() + " - это введеное вами число, оно должно быть меньше 2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
