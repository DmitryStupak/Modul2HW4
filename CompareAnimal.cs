using System;
using System.Collections.Generic;

namespace Modul2HW4
{
    public class CompareAnimal : IComparer<ChordatesAnimal>
    {
        public int Compare(ChordatesAnimal x, ChordatesAnimal y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return (int)(x.Weight * 100) - (int)(y.Weight * 100);
        }
    }
}
