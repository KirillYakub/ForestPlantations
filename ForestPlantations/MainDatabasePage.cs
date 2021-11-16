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
    public partial class MainDatabasePage : Form
    {
        public MainDatabasePage()
        {
            InitializeComponent();
        }

        Wood wood = new Wood(); //создаем объекты наших классов
        Bush bush = new Bush();
        private static IFileWorker fileWorkerWood = new Wood(); //переменная типа интерфейс для обращения к его методам
        private static IFileWorker fileWorkerBush = new Bush();
        delegate void fileWriter();
        delegate void fileReader();
        static event fileWriter fileWriterEvent; //события, обрабатывающие соотв. делегаты
        static event fileReader fileReaderEvent;

        private void MainDatabasePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (Forest.FirstLoad == false) //при первом входе пользователь можем заполнить списки некоторым кол-вом элементов
            {
                var Yes = MessageBox.Show("Хотите заполнить базу данных?", " ", MessageBoxButtons.YesNo);
                if (Yes == DialogResult.Yes)
                {                   
                    Random random = new Random();
                    int letter, woodAge, woodHeight, bushAge, bushHeight, woodCount, bushCount;
                    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                    string woodName, bushName;

                    woodName = bushName = string.Empty;
                    woodCount = bushCount = random.Next(10, 50);
                    for (int i = 0; i < woodCount; i++) //в цикле генерируем данные для добавления в список
                    {
                        woodAge = random.Next(1, 300);
                        woodHeight = random.Next(1, 50);
                        bushAge = random.Next(1, 50);
                        bushHeight = random.Next(1, 5);
                        for (int j = 0; j < 3; j++)
                        {
                            letter = random.Next(0, letters.Length - 1);
                            woodName += letters[letter];
                            letter = random.Next(0, letters.Length - 1);
                            bushName += letters[letter];
                        }
                        wood.addToList(woodName, woodAge, woodHeight); //при помощи объектов класса добавляем элементы в список
                        bush.addToList(bushName, bushAge, bushHeight);
                        woodName = bushName = string.Empty;
                    }                  
                }
                Forest.FirstLoad = true;
            }
        }   

        private void toBushMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            BushMenu bushMenu = new BushMenu();
            bushMenu.Show();
        }

        private void toWoodMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            WoodMenu wood = new WoodMenu();
            wood.Show();
        }

        private void filereaderButton_Click(object sender, EventArgs e)
        {
            fileReaderEvent = new fileReader(fileWorkerWood.readfromFile); //событие реагирует на делегат, который в свою очередь вызывает вложенные в него методы
            fileReaderEvent += fileWorkerBush.readfromFile;
            fileReaderEvent.Invoke(); //вызываем методы для записи данных в файл
            MessageBox.Show("Данные успешно считаны из файла!");
        }

        private void filewriteButton_Click(object sender, EventArgs e)
        {
            fileWriterEvent = new fileWriter(fileWorkerWood.writetoFile);
            fileWriterEvent += fileWorkerBush.writetoFile;
            fileWriterEvent.Invoke(); //вызываем методы для считывания данных из файлоы
            MessageBox.Show("Данные успешно записаны в файл!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}