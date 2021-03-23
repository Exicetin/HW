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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace HW
{
    /// <summary>
    /// Логика взаимодействия для PersonalAreaWindow.xaml
    /// </summary>
    public partial class PersonalAreaWindow : Window
    {
        public PersonalAreaWindow()
        {
            this.WindowState = WindowState.Maximized;

            InitializeComponent();

            AppContext db = new AppContext(); /*Создание объекта на основе класс AppContext*/

            //List<User> users = db.Users.ToList();
            //string str = "";
            //foreach (User user in users)
            //    str += user.Name;

            //Surname.Text = str;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth_window = new AuthWindow();
            auth_window.Show();
            Hide();
        }

        private void AddUsers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow add_users_window = new MainWindow();
            add_users_window.Show();
            Hide();
        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            Enquiry_OMO enquiry_OMO = new Enquiry_OMO();
            enquiry_OMO.Show();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserPersonalthigs_Click(object sender, RoutedEventArgs e)
        {
            UsersPersonalThings usersPersonalThings = new UsersPersonalThings();
            usersPersonalThings.Show();
            Hide();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
