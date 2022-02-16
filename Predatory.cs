using System;

namespace Modul2HW4
{
    public abstract class Predatory : ChordatesAnimal
    {
        public Predatory(string name, double weight)
            : base(name, weight, false)
        {
        }

        public Predatory(string name)
            : base(name, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine(" I can run ");
        }
    }
}
