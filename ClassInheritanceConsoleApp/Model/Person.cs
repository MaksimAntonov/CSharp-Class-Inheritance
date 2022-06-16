using System;

namespace ClassInheritanceConsoleApp.Model
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private char _gender;
        private DateTime _birthday;

        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Fullname => $"{_firstname} {_lastname}";
        public char Gender { get => _gender; set => _gender = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        public Person() : this("","",'-', DateTime.Now) { }

        public Person(string firstname, string lastname, char gender, DateTime birthday) 
        {
            _firstname = firstname;
            _lastname = lastname;   
            _gender = gender;
            _birthday = birthday;
        }
    }
}
