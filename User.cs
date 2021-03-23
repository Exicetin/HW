using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class User /*Создане класса модули, описывающего таблицу "Users"*/
    {

        public int id { get; set; }

        private string login, password, role, surname, name, middle_name, position;
        public string Login {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
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
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public User() {} /*Конструктор создаваемый по умолчанию*/

        public User(string login, string password, string role, string surname, string name, string middle_name, string position) { 
        this.login = login;
        this.password = password;
        this.role = role;
        this.surname = surname;
        this.name = name;
        this.middle_name = middle_name;
        this.position = position;
        }
    }
}
