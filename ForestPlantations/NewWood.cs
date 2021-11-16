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
    public partial class NewWood : Form
    {
        public NewWood()
        {
            InitializeComponent();
        }

        private static IListFunctions functionsWood = new Wood();

        private void NewWood_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void addWood_Click(object sender, EventArgs e)
        {
            String newPlantname;
            int newPlantage, newPlantheight;
            try
            {
                newPlantname = woodName.Text; //вводим данные, которые будем добавлять в список
                newPlantage = Convert.ToInt32(woodAge.Text);
                newPlantheight = Convert.ToInt32(woodHeight.Text);
                functionsWood.addElement(newPlantname, newPlantage, newPlantheight); //добавляем данные в список
                MessageBox.Show("Данные успешно добавлены!");
            }
            catch (Exception exc)
            { MessageBox.Show("Ошибка: " + exc.Message); }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WoodMenu wood = new WoodMenu();
            wood.Show();
        }
    }
}