using System;

namespace Modul2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SafariPark safariPark = new SafariPark();
            Console.WriteLine("До сортировки :");
            foreach (var item in safariPark.Section)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Количество животных в секции : {safariPark.GetCountAnimal()}");
            Console.WriteLine($"############################################################");

            safariPark.Section.Sort();
            Console.WriteLine("После сортировки по имени :");
            foreach (var item in safariPark.Section)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Количество животных в секции : {safariPark.GetCountAnimal()}");

            Console.WriteLine($"############################################################");

            Console.WriteLine("Поиск животных от 10 до 100 кг :");
            foreach (var item in safariPark.Section.FindByWeight(10, 100))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Количество животных в секции с заданными параметрами {safariPark.Section.FindByWeight(10, 100).Count}");
            safariPark.Section.Sort(new CompareAnimal());
            Console.WriteLine($"############################################################");
            Console.WriteLine("После сортировки по весу :");
            foreach (var item in safariPark.Section)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Количество животных в секции : {safariPark.GetCountAnimal()}");
        }
    }
}