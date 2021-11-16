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
    public partial class WoodMenu : Form
    {
        //данное окно эквивалентно BushMenu
        public WoodMenu()
        {
            InitializeComponent();
        }

        private static IListFunctions functionsWood = new Wood();
        private static IWoodList woodList = new Wood();

        private void WoodMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void outputInfo_Click(object sender, EventArgs e)
        {
            Wood[] woodArr = woodList.returnWood().ToArray();
            outputBox.Text = ("Данные обо всех деревьях:\n");
            for (int i = 0; i < woodArr.Length; i++)
            {
                outputBox.Text += ("Дерево №" + (i + 1) + ". Название: " + woodArr[i].PlantName + "\n");
                outputBox.Text += ("Возраст: " + woodArr[i].PlantAge + " лет, Высота: " + woodArr[i].PlantHeight + " метров" + "\n\n");
            }
            outputBox.Text += ("Общее кол-во деревьев: " + Forest.GeneralPlantsCount + "\n\n");
        }

        private void sortWoodArr_Click(object sender, EventArgs e)
        {
            functionsWood.sortArr();
            MessageBox.Show("Список отсортирован!");
        }

        private void addElement_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewWood newWood = new NewWood();
            newWood.Show();
        }

        private void deleteElement_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(inputDeleteBox.Text);
                index--;
                functionsWood.deleteElement(index);
                MessageBox.Show("Элемент удален!");
            }
            catch (Exception exc)
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