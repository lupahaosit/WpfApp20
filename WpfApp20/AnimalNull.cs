using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20
{
    class AnimalNull : IAnimal
    {
        public string Type { get; set; }

        public string Breed { get; set; }

        public string Animal { get; set; }
        public AnimalNull(string Breed, string Animal)
        {
            this.Type = "Неизвестный вид";
            this.Breed = Breed;
            this.Animal = Animal;
        }
    }
}
