using System.Collections.Generic;

namespace Modul2HW4
{
    public static class FindAnimal
    {
        public static List<ChordatesAnimal> FindByWeight(this List<ChordatesAnimal> animals, double minWeight, double maxWeight)
        {
            List<ChordatesAnimal> res = new List<ChordatesAnimal>();
            foreach (var item in animals)
            {
                if (item.Weight >= minWeight && item.Weight <= maxWeight)
                {
                    res.Add(item);
                }
            }

            return res;
        }
    }
}
