using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestPlantations
{
    interface IFileWorker //интерфейс, хранящий методы для работы с файлами
    {
        void writetoFile();
        void readfromFile();
    }
}