using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ForestPlantations
{
    //данный класс эквивалентен Bush
    [Serializable]
    class Wood : Plant, IListFunctions, IFileWorker, IWoodList
    {
        private static List<Wood> woods = new List<Wood>();

        List<Wood> IWoodList.returnWood()
        { return woods; }       
        void IListFunctions.sortArr()
        {
            Wood[] woodArr = woods.ToArray();
            for (int i = 0; i < woodArr.Length; i++)
            {
                for (int j = 0; j < woodArr.Length - 1; j++)
                {
                    if (woodArr[j].PlantAge > woodArr[j + 1].PlantAge)
                    {
                        Wood wood = woodArr[j];
                        woodArr[j] = woodArr[j + 1];
                        woodArr[j + 1] = wood;
                    }
                }
            }
            GeneralPlantsCount -= woods.Count;
            woods.Clear();
            for (int i = 0; i < woodArr.Length; i++)
                addToList(woodArr[i].plantName, woodArr[i].plantAge, woodArr[i].plantHeight);
        }
        void IListFunctions.addElement(String newPlantname, int newPlantage, int newPlantheight)
        {
            addToList(newPlantname, newPlantage, newPlantheight);
        }
        void IListFunctions.deleteElement(int deleteIndex)
        {
            woods.RemoveAt(deleteIndex);
            GeneralPlantsCount--;
        }
        void IFileWorker.writetoFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("Woods.bin", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, woods);
            }
        }
        void IFileWorker.readfromFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("Woods.bin", FileMode.Open))
            {
                GeneralPlantsCount -= woods.Count;
                woods.Clear();
                woods = (List<Wood>)binaryFormatter.Deserialize(fileStream);
                GeneralPlantsCount += woods.Count;
            }
        }

        public void addToList(String plantName, int plantAge, int plantHeight)
        { woods.Add(new Wood(plantName, plantAge, plantHeight)); }

        public Wood(String plantName, int plantAge, int plantHeight) : base(plantName, plantAge, plantHeight)
        { }
        public Wood() : base()
        { }
    }
}