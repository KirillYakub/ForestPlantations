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
    public partial class NewBush : Form
    {
        public NewBush()
        {
            InitializeComponent();
        }

        private static IListFunctions functionsBush = new Bush();

        private void NewBush_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void addBush_Click(object sender, EventArgs e)
        {
            String newPlantname;
            int newPlantage, newPlantheight;
            try
            {
                newPlantname = bushName.Text; //вводим данные, которые будем добавлять в список
                newPlantage = Convert.ToInt32(bushAge.Text);
                newPlantheight = Convert.ToInt32(bushHeight.Text);
                functionsBush.addElement(newPlantname, newPlantage, newPlantheight); //добавляем данные в список 
                MessageBox.Show("Данные успешно добавлены!");
            }
            catch(Exception exc)
            { MessageBox.Show("Ошибка: " + exc.Message); }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BushMenu bush = new BushMenu();
            bush.Show();
        }
    }
}