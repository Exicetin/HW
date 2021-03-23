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
    //Окно авторизации пользователя "AuthWindow"
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string role = Role.Text.Trim(); /*Получаем знаечние поля Login, удаляем лишние пробелы до и после и приводим к нижнему регистру*/
            string password = PassBox.Password.Trim(); /*Получаем значение поля PassBox и удаляем лишние пробелы в начале и конце строки*/

            if (password.Length < 8)
            {
                PassBox.ToolTip = "Данные введены не верно!";
                PassBox.BorderBrush =  Brushes.DarkRed;
            }

            else
            {
                PassBox.ToolTip = "";
                PassBox.BorderBrush = Brushes.LightGray;
                Role.ToolTip = "";
                Role.BorderBrush = Brushes.LightGray;

                User authUser = null;
                using (AppContext db = new AppContext()) {
                    authUser = db.Users.Where(b => b.Password == password && b.Role == role).FirstOrDefault();
                }

                if (authUser == null) {

                    Role.BorderBrush = Brushes.DarkRed;
                    PassBox.BorderBrush = Brushes.DarkRed;

                    MessageBox.Show("Необходимо заполнить поля!");

                }

                if (authUser != null)
                {
                    

                    if (role == "Координатор") {
                        MessageBox.Show("Вы успешно авторизованы!");
                        Add_Patient add_patient = new Add_Patient();
                        add_patient.Show();
                        Hide();
                    }

                    if (role == "Заведующий О.М.О") {
                        MessageBox.Show("Вы успешно авторизованы!");
                        PersonalAreaWindow personalAreaWindow = new PersonalAreaWindow();
                        personalAreaWindow.Show();
                        Hide();

                    }
                }

                else
                    MessageBox.Show("Неверно указаны данные!");
            }
        }

        private void Button_Out_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
