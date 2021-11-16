using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ForestPlantations
{
    //дочерний класс Bush наследует методы от интерфейсов, а также имеет доступ к полям базового класса Plant
    [Serializable]
    class Bush : Plant, IListFunctions, IFileWorker, IBushList
    {
        private static List<Bush> bushes = new List<Bush>(); //список для хранения данных

        List<Bush> IBushList.returnBush() //функция для возврата нашего списка и его дальнейшего вывода на экран
        { return bushes; }
        void IListFunctions.sortArr() //функция для сортировки нашего списка
        {
            Bush[] bushesArr = bushes.ToArray(); //записываем список в массив объектов
            for (int i = 0; i < bushesArr.Length; i++) //производим сортировку пузырьковым методом
            {
                for (int j = 0; j < bushesArr.Length - 1; j++)
                {
                    if (bushesArr[j].PlantAge > bushesArr[j + 1].PlantAge)
                    {
                        Bush bush = bushesArr[j];
                        bushesArr[j] = bushesArr[j + 1];
                        bushesArr[j + 1] = bush;
                    }
                }
            }
            GeneralPlantsCount -= bushes.Count;
            bushes.Clear(); //очищаем список
            for (int i = 0; i < bushesArr.Length; i++) //добавляем в список элементы уже отсортированного массива
                addToList(bushesArr[i].plantName, bushesArr[i].plantAge, bushesArr[i].plantHeight);
        }
        void IListFunctions.addElement(String newPlantname, int newPlantage, int newPlantheight) //добавляем элементы в список
        {
            addToList(newPlantname, newPlantage, newPlantheight);
        }
        void IListFunctions.deleteElement(int deleteIndex) //удаляем элемент списка по его индексу
        {
            bushes.RemoveAt(deleteIndex);
            GeneralPlantsCount--;
        }
        void IFileWorker.writetoFile() //метод для записи в файл
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter(); //хранить данные мы будем в бинарном виде
            using (FileStream fileStream = new FileStream("Bushes.bin", FileMode.OpenOrCreate)) //поток данных будет храниться в указанном файле
            {
                binaryFormatter.Serialize(fileStream, bushes); //сохраняем данные в бинарном виде в указанный файл
            }
        }
        void IFileWorker.readfromFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("Bushes.bin", FileMode.Open))
            {
                GeneralPlantsCount -= bushes.Count;
                bushes.Clear(); 
                bushes = (List<Bush>)binaryFormatter.Deserialize(fileStream); //считываем данные в наш список из файла
                GeneralPlantsCount += bushes.Count;
            }
        }

        public void addToList(String plantName, int plantAge, int plantHeight)
        { bushes.Add(new Bush(plantName, plantAge, plantHeight)); } //добавляем объект класса в список

        public Bush(String plantName, int plantAge, int plantHeight) : base(plantName, plantAge, plantHeight)
        { }
        public Bush() : base()
        { }
    }
}