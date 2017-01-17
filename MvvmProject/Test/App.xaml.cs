using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Test.Models;
using Test.ViewModel;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {

            DataBaseContext dbc = new DataBaseContext();
            dbc.dishes.Load();
            var data = dbc.dishes.Local;


            MainWindow view = new MainWindow(); // создали View
            MainWindowViewModel viewModel = new MainWindowViewModel(data, dbc);//Создали ViewModel

            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
