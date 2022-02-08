using System;

namespace Modul2HW4
{
    public abstract class Ratites : Birds
    {
        public Ratites(string name, double weight)
            : base(name, weight, false)
        {
        }

        public Ratites(string name)
            : base(name, false)
        {
        }

        public override void Move()
        {
            Console.WriteLine(" I can run ");
        }
    }
}
