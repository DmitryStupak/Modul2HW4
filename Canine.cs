namespace Modul2HW4
{
    public abstract class Canine : Predatory
    {
        public Canine(string name, double weight)
            : base(name, weight)
        {
        }

        public Canine(string name)
            : base(name)
        {
        }
    }
}
