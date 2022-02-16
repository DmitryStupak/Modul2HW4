using System;

namespace Modul2HW4
{
    public abstract class Rodents : ChordatesAnimal
    {
        public Rodents(string name, double weight)
            : base(name, weight, false)
        {
        }

        public Rodents(string name)
            : base(name, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine(" I can run ");
        }
    }
}
