using System;

namespace Modul2HW4
{
    public abstract class Penguins : Birds
    {
        public Penguins(string name, double weight)
            : base(name, weight, false)
        {
        }

        public Penguins(string name)
            : base(name, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine(" I can swim ");
        }
    }
}
