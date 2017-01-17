using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.ViewModel
{
    public class DishesViewModel : ViewModelBase

    {
        public Dishes dishes;
        protected DataBaseContext dbContext;
        public DishesViewModel(Dishes dishes, DataBaseContext dbContext)
        {
            this.dishes = dishes;
            this.dbContext = dbContext;
        }

        public string Recipe
        {
            get { return dishes.recipe; }
            set
            {
                dishes.recipe = value;
                OnPropertyChanged("Recipe");
                dbContext.SaveChanges();
            }
        }
        public string Name
        {
            get {return dishes.name_d; }
            set
            {
                dishes.name_d = value;
                OnPropertyChanged("Name");
                dbContext.SaveChanges();
            }
        }

    }
}
