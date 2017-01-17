using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<DishesViewModel> DishesList { get; set; }

        public MainWindowViewModel()
        {

        }

        public MainWindowViewModel(IEnumerable<Dishes> dishes, DataBaseContext dbContext)
        {
            var enumarable = dishes as IList<Dishes> ?? dishes.ToList();
            for(int i = 0; i<10; i++)
            enumarable.Add(new Dishes());
            

            DishesList = new ObservableCollection<DishesViewModel>(enumarable.Select(x => new  DishesViewModel(x, dbContext)));

        }
    }
}
