namespace Modul2HW4
{
    public abstract class KeelBreasted : Birds
    {
        public KeelBreasted(string name, double weight)
            : base(name, weight, true)
        {
        }

        public KeelBreasted(string name)
            : base(name, true)
        {
        }
    }
}
