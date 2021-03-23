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
using System.Data.SqlClient;

namespace HW
{
    
    /// <summary>
    /// Логика взаимодействия для PersonalArea_Coordinator.xaml
    /// </summary>
    public partial class PersonalArea_Coordinator : Window
    {
        AppContext db;
        public PersonalArea_Coordinator()
        {
            this.WindowState = WindowState.Maximized;

            InitializeComponent();

            db = new AppContext(); /*Создание объекта на основе класс AppContext*/

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

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            Add_Patient add_patient = new Add_Patient();
            add_patient.Show();
            Hide();
        }
    

        private void Button_Save_Numbers_Click(object sender, RoutedEventArgs e)
        {
            string numbers = Numbers.Text.Trim();
            if (!numbers.Contains("+7"))
            {
                Numbers.BorderBrush = Brushes.DarkRed;
                MessageBox.Show("Введите номер телефона начиная с +7");
            }

            else if (numbers.Length != 12) {
                Numbers.BorderBrush = Brushes.DarkRed;
                MessageBox.Show("Номер телефона должен состоять из 12 символов!");
            }

            else
                MessageBox.Show("Номер телефона добавлен!");

        }

        private void Button_email_Numbers_Click(object sender, RoutedEventArgs e)
        {
            string email = Email.Text.Trim();
            if (!email.Contains("@") || !email.Contains("."))
            {
                Numbers.BorderBrush = Brushes.DarkRed;
                MessageBox.Show("Проверьте правильность введенных данных");
            }

            else if (email.Length < 5)
            {
                Numbers.BorderBrush = Brushes.DarkRed;
                MessageBox.Show("Проверьте правильность введенных данных");
            }

            else
                MessageBox.Show("Номер телефона добавлен!");
            
            
        }

        private void Personal_thigs_Click(object sender, RoutedEventArgs e)
        {
            PersonalThings personalThings = new PersonalThings();
            personalThings.Show();
            Hide();
        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            enquiry faq = new enquiry();
            faq.Show();
        }
    }
}
