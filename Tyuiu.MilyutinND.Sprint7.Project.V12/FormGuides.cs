using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MilyutinND.Sprint7.Project.V12
{
    public partial class FormGuides: Form
    {
        public FormGuides()
        {
            InitializeComponent();
        }

        private void buttonGuidesClose_MND_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenu_MND_Click(object sender, EventArgs e)
        {
            string menuText =  "Меню:" + Environment.NewLine + Environment.NewLine + "\"Руководство\" - открывает руководство для пользователя с пояснением всех функций\n" + Environment.NewLine + Environment.NewLine + " \"Справка\" - открывает окно с информацией о программе и разработчике\n" + Environment.NewLine + Environment.NewLine + " \"Старт\" - открывает главный интерфейс программы\n" + Environment.NewLine + Environment.NewLine + " \"Выход\" - закрывает окно открытого меню.";

            textBoxGuidesMenu_MND.Text = menuText;
            
        }

        private void textBoxGuidesMenu_MND_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GenText = "Приложение:" + Environment.NewLine + Environment.NewLine +
                      " \"Открыть файл\" - открывает меню с выбором файла для открытия в программе " + Environment.NewLine + Environment.NewLine +
                      " \"Сохранить файл\" - открывает меню с выбором пути для сохранения файла " + Environment.NewLine + Environment.NewLine +
                      " \"Очистить\" - очищает таблицу " + Environment.NewLine + Environment.NewLine +
                      " \"Фильтр\" - открывает меню с выбором категории фильтрации " + Environment.NewLine + Environment.NewLine +
                      " \"Добавить\" - добавляет в таблицу новые значения из заполненных строк " + Environment.NewLine + Environment.NewLine +
                      " \"Назад в меню\" - Возвращает в главное меню.";

            textBoxGuidesMenu_MND.Text = GenText;
        }
    }
}
