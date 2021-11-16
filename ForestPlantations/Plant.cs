using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestPlantations
{
    [Serializable]
    class Plant : Forest
    {
        protected String plantName;
        protected int plantAge, plantHeight;

        public String PlantName { get { return plantName; } } //свойства позволяют получить доступ к полям класса
        public int PlantAge { get { return plantAge; } }
        public int PlantHeight { get { return plantHeight; } }

        protected Plant(String plantName, int plantAge, int plantHeight)
        {
            this.plantName = plantName;
            this.plantAge = plantAge;
            this.plantHeight = plantHeight;
            GeneralPlantsCount += 1;
        }
        protected Plant()
        { }
    }
}