using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestPlantations
{
    //данные интерфейсы реализуют методы для возврата соотв. списка
    interface IBushList
    {
        List<Bush> returnBush();
    }
    interface IWoodList
    {
        List<Wood> returnWood();
    }
}