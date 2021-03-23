using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Patient
    {
        public int id { get; set; }
        private string surname, name, middle_name, main_diagnosis, additional_diagnosis;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Middle_name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }
        public string MainDiagnosis
        {
            get { return main_diagnosis; }
            set { main_diagnosis = value; }
        }

        public string AdditionalDiagnosis
        {
            get { return additional_diagnosis; }
            set { additional_diagnosis = value; }
        }
        public Patient() { } /*Конструктор создаваемый по умолчанию*/

        public Patient(string surname, string name, string middle_name, string main_diagnosis, string additional_diagnosis)
        {
            this.surname = surname;
            this.name = name;
            this.middle_name = middle_name;
            this.main_diagnosis = main_diagnosis;
            this.additional_diagnosis = additional_diagnosis;

        }
    }
}
