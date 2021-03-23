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
    /// Логика взаимодействия для Add_Patient.xaml
    /// </summary>
    public partial class Add_Patient : Window
    {
        AppContext db;
        public Add_Patient()
        {
            this.WindowState = WindowState.Maximized;

            InitializeComponent();

            db = new AppContext();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e) //
        {
            string surname = Surname.Text.Trim();
            string name = Name.Text.Trim();
            string middle_name = Middle_Name.Text.Trim();
            string main_diagnosis = MainDiagnosis.Text;
            string additional_diagnosis = Additional_diagnosis.Text;

            Patient patient = new Patient(surname, name, middle_name, main_diagnosis, additional_diagnosis);

            db.Patients.Add(patient);
            db.SaveChanges();

        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            PersonalArea_Coordinator personalArea_Coordinator = new PersonalArea_Coordinator();
            personalArea_Coordinator.Show();
            Hide();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth_window = new AuthWindow();
            auth_window.Show();
            Hide();
        }

        private void Personalthigs_Click(object sender, RoutedEventArgs e)
        {
            PersonalThings personalThings = new PersonalThings();
            personalThings.Show();
            Hide();
        }

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            enquiry faq = new enquiry();
            faq.Show();
        }
    }
}
