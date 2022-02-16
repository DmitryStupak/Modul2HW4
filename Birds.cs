using System;

namespace Modul2HW4
{
    public abstract class Birds : ChordatesAnimal
    {
        public Birds(string name, double weight, bool canFly)
            : base(name, weight, canFly)
        {
        }

        public Birds(string name, bool canFly)
            : base(name, canFly)
        {
        }

        public override void Move()
        {
            Console.WriteLine(" I can fly ");
        }
    }
}
