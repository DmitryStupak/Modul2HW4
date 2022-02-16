namespace Modul2HW4
{
    public abstract class Lagomorphs : Ratites
    {
        public Lagomorphs(string name, double weight)
            : base(name, weight)
        {
        }

        public Lagomorphs(string name)
            : base(name)
        {
        }
    }
}
