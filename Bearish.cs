namespace Modul2HW4
{
    public abstract class Bearish : Predatory
    {
        public Bearish(string name, double weight)
            : base(name, weight)
        {
        }

        public Bearish(string name)
            : base(name)
        {
        }
    }
}
