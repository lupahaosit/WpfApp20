using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfApp20
{
    class Repository
    {
        public ObservableCollection<IAnimal> animals;
        
        public Repository()
        {
            animals = new ObservableCollection<IAnimal>();
        }
        public Repository(List<IAnimal> x)
        {
            animals = new ObservableCollection<IAnimal>();
            foreach (var item in x)
            {
                animals.Add(item);
            }
        }

        public void Add(IAnimal animal)
        {
            animals.Add(animal);
        }
        public void Remove(int x)
        {
            animals.Remove(animals[x]);
        }

        public void SaveAs(int x, ObservableCollection<IAnimal> animals)
        {
            switch (x)
            {
                case 1:
                    Txt txt = new Txt(animals);
                    txt.SaveAsTxt();
                    break;
                case 2:
                    Docx docx = new Docx(animals);
                    docx.SaveAsDocx();
                    break;
                default:
                    break;
            }
        }
        


    }
    class Txt
    {
        public ObservableCollection<IAnimal> animals { get; set; }
        public Txt(ObservableCollection<IAnimal> animals) 
        {
            this.animals = animals;
        }
        public void SaveAsTxt()
        {
            StreamWriter sw = new StreamWriter(@"animals.txt");
            foreach (var item in this.animals)
            {
                sw.WriteLine($"{item.Animal,15}\t{item.Type,10}\t{item.Breed,10}");
            }
            sw.Close();

        }


   
    }
    class Docx
    {
        public ObservableCollection<IAnimal> animals { get; set; }
        public Docx(ObservableCollection<IAnimal> animals) 
        {
            this.animals = animals;
        }
        public void SaveAsDocx()
        {
            StreamWriter sw = new StreamWriter(@"animals.docx");
            foreach (var item in this.animals)
            {
                sw.WriteLine($"{item.Animal}\t{item.Type}\t{item.Breed}");
            }
            sw.Close();

        }
       
    }
}
