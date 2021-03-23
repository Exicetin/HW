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
    /// Логика взаимодействия для PersonalThings.xaml
    /// </summary>
    public partial class PersonalThings : Window
    {
        AppContext db;

        public PersonalThings()
        {
            this.WindowState = WindowState.Maximized;

            InitializeComponent();

            db = new AppContext();

            List<Patient> patients = db.Patients.ToList();

            string str = "";

            foreach (Patient patient in patients)
                if (patient.id > 1)
                    str += "Пациент: " + patient.Surname + " " + patient.Name + " " + patient.Middle_name + "\n" + "Основной диагноз:   " + patient.MainDiagnosis + "  " + "\n\n";
            Patients.Text = str;
        }

        private void Personalthigs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            Add_Patient add_patient = new Add_Patient();
            add_patient.Show();
            Hide();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth_window = new AuthWindow();
            auth_window.Show();
            Hide();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            PersonalArea_Coordinator personalArea_Coordinator = new PersonalArea_Coordinator();
            personalArea_Coordinator.Show();
            Hide();
        }

        private void Faq_Click(object sender, RoutedEventArgs e)
        {
            enquiry faq = new enquiry();
            faq.Show();
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