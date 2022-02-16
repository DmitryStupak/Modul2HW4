namespace Modul2HW4
{
    public abstract class Feline : Predatory
    {
        public Feline(string name, double weight)
            : base(name, weight)
        {
        }

        public Feline(string name)
            : base(name)
        {
        }
    }
}
