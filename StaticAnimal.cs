using System.Collections.Generic;
using System;

namespace Modul2HW4
{
    public static class StaticAnimal
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

        public static void PrintList(this List<ChordatesAnimal> animals)
        {
            Console.WriteLine("########################################################");
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Количество животных в секции : {animals.Count}");
            Console.WriteLine(" ");
            Console.WriteLine("########################################################");
        }
    }
}
