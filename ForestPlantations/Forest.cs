using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestPlantations
{
    [Serializable]
    class Forest //базовый класс, содержит информацтю об общем кол-во растений в лесу
    {
        public static int GeneralPlantsCount { get; set; } = 0;
        public static bool FirstLoad { get; set; } = false;
    } 
}