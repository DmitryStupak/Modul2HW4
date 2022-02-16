using System;

namespace Modul2HW4
{
    public abstract class ChordatesAnimal : IComparable<ChordatesAnimal>
    {
        private string _name;
        private double _weight;
        private bool _canFly;
        public ChordatesAnimal(string name, double weight, bool canFly)
        {
            Name = name;
            Weight = weight;
            _canFly = canFly;
        }

        public ChordatesAnimal(string name, bool canFly)
        {
            Name = name;
            _canFly = canFly;
            Weight = 0;
        }

        public string Name
        {
            get => _name;
            set => _name = (value == string.Empty) ? "Unknown animal" : value;
        }

        public double Weight
        {
            get => _weight;
            set => _weight = (value < 0) ? 0 : value;
        }

        public bool CanFly
        {
            get => _canFly;
        }

        public virtual void Move()
        {
            Console.WriteLine("I can move");
        }

        public int CompareTo(ChordatesAnimal other)
        {
            if (other is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name}     {Weight}kg";
        }
    }
}
