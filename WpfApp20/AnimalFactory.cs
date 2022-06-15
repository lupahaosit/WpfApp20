using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20
{
    class AnimalFactory
    {

        public static IAnimal GetAnimal(string Type, string Animal, string Breed)
        {
            switch (Type)
            {
                case("птица"):
                    return( new Bird(Type, Breed, Animal));
                case ("млекопитающее"):
                    return (new Mammal(Type, Breed, Animal));
                    
                case ("земноводное"):
                    return (new Amphibian(Type, Breed, Animal));
                  

                default:
                    return (new AnimalNull(Breed, Animal));
                    
            }

           
        }
    }
}
