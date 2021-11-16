using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestPlantations
{
    interface IListFunctions //интерфейс, хранящий методы для проведения операций со списком
    {
        void sortArr();
        void deleteElement(int deleteIndex);
        void addElement(String newPlantname, int newPlantage, int newPlantheight);       
    }
}