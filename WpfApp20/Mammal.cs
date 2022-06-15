using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20
{
    class Mammal : IAnimal
    {
        public string Type { get; set; }

        public string Breed { get; set; }

        public string Animal { get; set; }
        public Mammal(string Type, string Breed, string Animal)
        {
            this.Type = Type;
            this.Breed = Breed;
            this.Animal = Animal;
        }
    }
}
