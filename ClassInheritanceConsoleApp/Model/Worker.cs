using System;

namespace ClassInheritanceConsoleApp.Model
{
    public class Worker : Person
    {
        private double _bonus;
        private double _salary;
        private int _workExperience;

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public int WorkExperience 
        {
            get => _workExperience;
            set 
            { 
                _workExperience = value; 
                RecalculateBonus(); 
            }
        }
        public double Bonus 
        { 
            get => _bonus;
            set
            {
               if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(value));
                    
               _bonus = value / 100;

                RecalculateBonus();
            }
        }

        public Worker() : this(0, 0, 0, "", "", '-', DateTime.Now) { }

        public Worker(double salary, double bonus, int workExperience, string firstname, string lastname) : this(salary, bonus, workExperience, firstname, lastname, '-', DateTime.Now) { }

        public Worker(double salary, double bonus, int workExperience, string firstname, string lastname, char gender, DateTime birthday) : base(firstname, lastname, gender, birthday)
        {
            Salary = salary;
            Bonus = bonus;
            WorkExperience = workExperience;
        }

        private void RecalculateBonus()
        {
            _bonus = (_workExperience > 10) ? _bonus * 2 : _bonus;
        }

        public double SalaryWithBonus()
        {
            return _salary + _salary * _bonus;
        }


        public virtual double Tax()
        {
            return SalaryWithBonus() * 0.13;
        }

        public virtual double PayCheck()
        {
            return SalaryWithBonus() - Tax();
        }

        public override string ToString()
        {
            return $"Worker: {Fullname}, Salary: {SalaryWithBonus()}, Bonus: {Bonus}, PayCheck: {PayCheck()}, Tax: {Tax()}";
        }
    }
}
