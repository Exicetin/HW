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
using System.Data.SqlClient;

namespace HW
{
    public partial class MainWindow : Window
    {
        

        AppContext db;
        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            InitializeComponent();
            db = new AppContext();
        }
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim().ToLower(); //Получаем знаечние поля Login
            string password = PassBox.Password.Trim(); //Получаем значение поля PassBox
            string role = Role.Text.Trim(); //Получаем знаечние поля Role 
            string surname = Surname.Text.Trim(); //Получаем знаечние поля Surname
            string name = Name.Text.Trim(); //Получаем знаечние поля Name
            string middle_name = Middle_name.Text.Trim(); //Получаем знаечние поля Middle_name
            string position = Position.Text.Trim(); //Получаем знаечние поля Position

            //Метод Trim() позволяет избавиться от лишних пробелов до и после введенных данных
            //Метод ToLower() приводит полученные данные к нижнему регистру

            if (!login.Contains("@") || !login.Contains("."))
            {
                Login.ToolTip = "Данные введены не верно!";
                Login.Background = Brushes.DarkGray;
            }
            else
            {
                Login.ToolTip = "";
                Login.Background = Brushes.Transparent;
            }
            if (password.Length < 8)
            {
                PassBox.ToolTip = "Данные введены не верно!";
                PassBox.Background = Brushes.DarkGray;
            }
            else
            {
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;
            }

            User user = new User(login, password, role, surname, name, middle_name, position);
            db.Users.Add(user);
            db.SaveChanges();
        }
        private void Set_Click(object sender, RoutedEventArgs e)
        {
            PersonalAreaWindow personalAreaWindow = new PersonalAreaWindow();
            personalAreaWindow.Show();
            Hide();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth_window = new AuthWindow();
            auth_window.Show();
            Hide();
        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            Enquiry_OMO enquiry_OMO = new Enquiry_OMO();
            enquiry_OMO.Show();
        }

        private void UserPersonalthigs_Click(object sender, RoutedEventArgs e)
        {
            UsersPersonalThings usersPersonalThings = new UsersPersonalThings();
            usersPersonalThings.Show();
            Hide();
        }
    }
}
