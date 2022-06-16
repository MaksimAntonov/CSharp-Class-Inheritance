namespace ClassInheritanceConsoleApp.Model
{
    public class WorkerWithHourSalary : Worker
    {
        public int WorkedHours { get; set; }

        public WorkerWithHourSalary() : this(0, 0, 0, 0, "", "") { }

        public WorkerWithHourSalary(int workedHours, double salary, double bonus, int workExperience, string firstname, string lastname) : base(salary, bonus, workExperience, firstname, lastname)
        {
            WorkedHours = workedHours;
        }

        public override double Tax()
        {
            return SalaryWithBonus() * WorkedHours * 0.13;
        }

        public override double PayCheck()
        {
            return (SalaryWithBonus() * WorkedHours) - Tax();
        }

        public override string ToString()
        {
            return $"Worker: {Fullname}, Salary in hour: {SalaryWithBonus()}, Bonus: {Bonus}, PayCheck: {PayCheck()}, Tax: {Tax()}";
        }
    }
}
