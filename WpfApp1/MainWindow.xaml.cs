using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
            List<User> users = new List<User>();
            User user1 = new User(){
                Id = 1,
                Name = "Альберт",
                LastName = "Бибурат",
                City = "Казань",
                Age = 5
            };
            User user2 = new User()
            {
                Id = 2,
                Name = "Булат",
                LastName = "Феликсович",
                City = "Казань",
                Age = 18
            };
            User user3 = new User()
            {
                Id = 3,
                Name = "Кирилл",
                LastName = "Лососев",
                City = "Казань",
                Age = 49
            };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            LvList.ItemsSource = users.ToList();
        }
    }
}
