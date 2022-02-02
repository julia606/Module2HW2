using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW2
{
    public static class Dictionaries
    {
        public static Dictionary<int, string> GetYourProducts()
        {
            return new Dictionary<int, string>()
            {
                {1,"Апельсиновый сок Sandora" },
                {2, "Овсяные хлопья Elovena без глютена"},
                {3, "Оливковое масло Olio Dante Extra Virgin"},
                {4, "Конфеты Raffaello"},
                {5,"Соус Barilla Песто Дженовезе" },
                {6,"Колбаса сыровяленая Discovery Salame высшего сорта" },
                {7,"Чипсы Pringles Original" },
                {9,"Ананас кольцами Tropic Life"},
                {8,"Тунец Coloso в оливковом масле" },
                {10,"Шпроты Diplomats рижские в масле" }
            };
        }

        public static Dictionary<string, decimal> GetProductsWithPrice()
        {
            return new Dictionary<string, decimal>()
            {
                {"Апельсиновый сок Sandora",35 },
                {"Овсяные хлопья Elovena без глютена",120},
                {"Оливковое масло Olio Dante Extra Virgin",198},
                {"Конфеты Raffaello",78},
                {"Соус Barilla Песто Дженовезе",64 },
                {"Колбаса сыровяленая Discovery Salame высшего сорта",236 },
                {"Чипсы Pringles Original",69 },
                {"Ананас кольцами Tropic Life",54},
                {"Тунец Coloso в оливковом масле",85 },
                {"Шпроты Diplomats рижские в масле",77 }
            };

        }
    }
}
