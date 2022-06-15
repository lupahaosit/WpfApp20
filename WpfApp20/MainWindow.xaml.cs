using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<IAnimal> animals;
        Repository repository = AnimalCreation.CreateRepository();
        IAnimal x;
        int y;
        public MainWindow()
        {
            InitializeComponent();
            
            animals = repository.animals;
            DT_Animals.ItemsSource = animals;
            
            
            



        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            repository.Remove(DT_Animals.SelectedIndex);
            
        }

        private void DT_Animals_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            y = DT_Animals.SelectedIndex;

        }

        private void DT_Animals_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            x = (IAnimal)DT_Animals.SelectedItem;

            animals[y] = x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            animals.Add(AnimalFactory.GetAnimal(Type.Text, Animal.Text, Breed.Text));
        }

        private void docx_Save_Click(object sender, RoutedEventArgs e)
        {
            repository.SaveAs(2, animals);
        }

        private void Txt_Save_Click(object sender, RoutedEventArgs e)
        {
            repository.SaveAs(1, animals);
        }
    }
}
