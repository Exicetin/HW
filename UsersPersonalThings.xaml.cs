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

namespace HW
{
    /// <summary>
    /// Логика взаимодействия для UsersPersonalThings.xaml
    /// </summary>
    public partial class UsersPersonalThings : Window
    {
        AppContext db;

        public UsersPersonalThings()
        {
            this.WindowState = WindowState.Maximized;

            InitializeComponent();

            db = new AppContext();

            List<User> users = db.Users.ToList();

            string str = "";

            foreach (User user in users)
                if (user.id > 4)
                    str += "Пользователь: " + user.Surname + " " + user.Name + "\n" + "Роль:  " + user.Role + "\n" + "Должность:  " + user.Position + "  " + "\n\n";
            Users.Text = str;
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth_window = new AuthWindow();
            auth_window.Show();
            Hide();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            PersonalAreaWindow personalAreaWindow = new PersonalAreaWindow();
            personalAreaWindow.Show();
            Hide();
        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            Enquiry_OMO faq = new Enquiry_OMO();
            faq.Show();
        }

        private void AddUsers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }
    }
}