namespace Modul2HW4
{
    public abstract class Dogs : Canine
    {
        public Dogs(string name, double weight)
            : base(name, weight)
        {
        }

        public Dogs(string name)
            : base(name)
        {
        }
    }
}
