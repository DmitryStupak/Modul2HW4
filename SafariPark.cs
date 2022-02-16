using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4
{
    public class SafariPark
    {
        private List<ChordatesAnimal> _section = new List<ChordatesAnimal>();
        public SafariPark()
        {
            _section.Add((ChordatesAnimal)new Mouse());
            _section.Add((ChordatesAnimal)new Bunny());
            _section.Add((ChordatesAnimal)new Squirrel());
            _section.Add((ChordatesAnimal)new Bear());
            _section.Add((ChordatesAnimal)new Cat());
            _section.Add((ChordatesAnimal)new Wolf());
            _section.Add((ChordatesAnimal)new Dog());
            _section.Add((ChordatesAnimal)new AfricanOstrich());
            _section.Add((ChordatesAnimal)new EmperorPeguin());
            _section.Add((ChordatesAnimal)new Owl());
        }

        public SafariPark(ChordatesAnimal animal)
        {
            _section.Add(animal);
        }

        public SafariPark(List<ChordatesAnimal> animals)
        {
            _section = animals;
        }

        public List<ChordatesAnimal> Section
        {
            get => _section;
        }

        public void AddAnimalInSection(ChordatesAnimal animal)
        {
            _section.Add(animal);
        }

        public int GetCountAnimal() => _section.Count();
    }
}
