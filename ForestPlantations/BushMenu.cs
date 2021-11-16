using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestPlantations
{
    public partial class BushMenu : Form
    {
        public BushMenu()
        {
            InitializeComponent();
        }

        private static IListFunctions functionsBush = new Bush(); //поля типа интерфейс для доступа к методам, которые он реализует
        private static IBushList bushList = new Bush();

        private void BushMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void outputInfo_Click(object sender, EventArgs e)
        {
            Bush[] bushArr = bushList.returnBush().ToArray(); //записываем наш список в массив
            outputBox.Text = ("Данные обо всех кустах:\n");
            for (int i = 0; i < bushArr.Length; i++) //выводим на экран элементы массива
            {
                outputBox.Text += ("Куст №" + (i + 1) + ". Название: " + bushArr[i].PlantName + "\n");
                outputBox.Text += ("Возраст: " + bushArr[i].PlantAge + " лет, Высота: " + bushArr[i].PlantHeight + " метров" + "\n\n");
            }
            outputBox.Text += ("Общее кол-во деревьев: " + Forest.GeneralPlantsCount + "\n\n");
        }

        private void sortBushArr_Click(object sender, EventArgs e)
        {
            functionsBush.sortArr(); //вызываем метод сортировки списка
            MessageBox.Show("Список отсортирован!");
        }

        private void addElement_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewBush newBush = new NewBush();
            newBush.Show();
        }

        private void deleteElement_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(inputDeleteBox.Text); //вводим номер элемента для удаления
                index--;
                functionsBush.deleteElement(index); //удаляем соотв. элемент
                MessageBox.Show("Элемент удален!");
            }
            catch(Exception exc)
            { MessageBox.Show("Ошибка: " + exc.Message); }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainDatabasePage main = new MainDatabasePage();
            main.Show();
        }
    }
}