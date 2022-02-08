using System;

namespace Modul2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SafariPark safariPark = new SafariPark();
            Console.WriteLine("До сортировки :");
            safariPark.Section.PrintList();
            safariPark.Section.Sort();
            Console.WriteLine("После сортировки по имени :");
            safariPark.Section.PrintList();
            Console.WriteLine("Поиск животных от 10 до 100 кг :");
            safariPark.Section.FindByWeight(10, 100).PrintList();
            safariPark.Section.Sort(new CompareAnimal());
            Console.WriteLine("После сортировки по весу :");
            safariPark.Section.PrintList();
        }
    }
}