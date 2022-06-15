using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20
{
    class AnimalCreation 
    {

        static Random rnd;

        static AnimalCreation() { rnd = new Random(); } 
        public static Repository CreateRepository()
        {
            List<IAnimal> animals = new List<IAnimal>();

            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(1,3))
                {
                    case 1:
                        animals.Add(new Bird("Птица", Guid.NewGuid().ToString().Substring(0, 2),
                           Guid.NewGuid().ToString().Substring(0, 4)));
                        break;
                    case 2:
                        animals.Add(new Bird("Млекопитающее", Guid.NewGuid().ToString().Substring(0, 2),
                          Guid.NewGuid().ToString().Substring(0, 4)));
                        break;
                    default:
                        animals.Add(new Amphibian("Земноводное", Guid.NewGuid().ToString().Substring(0, 2),
                          Guid.NewGuid().ToString().Substring(0, 4)));
                        break;
                }
            }
            return new Repository(animals);

        }
      
       

    }
}
