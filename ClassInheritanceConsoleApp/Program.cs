using System;
using System.Collections.Generic;
using ClassInheritanceConsoleApp.Model;

namespace ClassInheritanceConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Program app = new Program();

            //Console.WriteLine("=== PART 1 ===");
            //app.PartOne();

            //Console.WriteLine("=== PART 2 ===");
            //app.PartTwo();

            //Console.WriteLine("=== PART 1 and 2 ===");
            //app.PartOneAndTwo();

            Console.WriteLine("=== PART 3 ===");
            app.PartThree();

            Console.ReadLine();
        }

        public void PartOne()
        {
            Console.WriteLine("");
            Console.WriteLine("===== Subpart A =====");
            Console.WriteLine("");

            PartOneSubpartA();

            Console.WriteLine("");
            Console.WriteLine("===== Subpart B =====");
            Console.WriteLine("");

            PartOneSubpartB();
        }

        public void PartTwo()
        {
            List<WorkerWithHourSalary> workers = new List<WorkerWithHourSalary>();
            ConsoleKey consoleKey = ConsoleKey.Y;

            while (consoleKey == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("New worker");

                WorkerWithHourSalary worker = new WorkerWithHourSalary();
                Console.WriteLine("Имя:");
                worker.Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Фамилия:");
                worker.Lastname = Console.ReadLine().Trim();
                Console.WriteLine("Оклад:");
                worker.Salary = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Отработано часов:");
                worker.WorkedHours = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Премия %:");
                worker.Bonus = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Стаж работы:");
                worker.WorkExperience = int.Parse(Console.ReadLine().Trim());

                workers.Add(worker);

                Console.WriteLine("Add new worker? Y - yes, N - no");
                consoleKey = Console.ReadKey(true).Key;
            }

            double summaryTax = 0;
            workers.ForEach(worker => summaryTax += worker.Tax());
            Console.WriteLine($"Summary tax: {summaryTax}");

            Worker bestWorker = workers[0];
            for (int i = 1; i < workers.Count; i++)
            {
                if (workers[i].SalaryWithBonus() > workers[i - 1].SalaryWithBonus())
                    bestWorker = workers[i];
            }
            Console.WriteLine($"Best worker is {bestWorker.Lastname}");

            workers.ForEach(worker => Console.WriteLine(worker));
        }

        public void PartOneAndTwo()
        {
            List<Worker> workers = new List<Worker>();
            ConsoleKey consoleKey = ConsoleKey.Y;

            while (consoleKey == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("New worker");
                Worker worker;

                Console.WriteLine("Выберите тип ЗП: 1 - месячная, 2 - почасовая");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D2)
                {
                    WorkerWithHourSalary workerHour = new WorkerWithHourSalary();
                    Console.WriteLine("Отработано часов:");
                    workerHour.WorkedHours = int.Parse(Console.ReadLine().Trim());
                    worker = workerHour;
                }
                else if (key == ConsoleKey.D1)
                    worker = new Worker();
                else
                    return;

                Console.WriteLine("Имя:");
                worker.Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Фамилия:");
                worker.Lastname = Console.ReadLine().Trim();
                Console.WriteLine("Оклад:");
                worker.Salary = double.Parse(Console.ReadLine().Trim());

                Console.WriteLine("Премия %:");
                worker.Bonus = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Стаж работы:");
                worker.WorkExperience = int.Parse(Console.ReadLine().Trim());

                workers.Add(worker);

                Console.WriteLine("Add new worker? Y - yes, N - no");
                consoleKey = Console.ReadKey(true).Key;
            }

            double summaryTax = 0;
            workers.ForEach(worker => summaryTax += worker.Tax());
            Console.WriteLine($"Summary tax: {summaryTax}");

            Worker bestWorker = workers[0];
            for (int i = 1; i < workers.Count; i++)
            {
                if (workers[i].SalaryWithBonus() > workers[i - 1].SalaryWithBonus())
                    bestWorker = workers[i];
            }
            Console.WriteLine($"Best worker is {bestWorker.Lastname}");

            workers.ForEach(worker => Console.WriteLine(worker));
        }

        public void PartThree()
        {
            List<Student> students = new List<Student>();
            ConsoleKey consoleKey = ConsoleKey.Y;

            while (consoleKey == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("New student");

                Student student = new Student();

                Console.WriteLine("Имя:");
                student.Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Фамилия:");
                student.Lastname = Console.ReadLine().Trim();
                Console.WriteLine("Пол:");
                student.Gender = char.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Дата рождения:");
                student.Birthday = DateTime.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Класс:");
                student.Class = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Количество предметов:");
                int countOfLessons = int.Parse(Console.ReadLine().Trim());
                int[] grades = new int[countOfLessons];
                for (int i = 0; i < countOfLessons; i++)
                {
                    Console.WriteLine($"Оценка по предмету {i + 1}");
                    grades[i] = int.Parse(Console.ReadLine().Trim());
                }
                student.Grades = grades;

                students.Add(student);

                Console.WriteLine("Add new worker? Y - yes, N - no");
                consoleKey = Console.ReadKey(true).Key;
            }

            students.ForEach(student => Console.WriteLine(student));

        }

        private void PartOneSubpartA()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker(10000, 15, 2, "Петя", "Пилюлькин", 'м', DateTime.Parse("12.01.1985"))
            };

            Worker worker2 = new Worker();
            Console.WriteLine("Имя:");
            worker2.Firstname = Console.ReadLine().Trim();
            Console.WriteLine("Фамилия:");
            worker2.Lastname = Console.ReadLine().Trim();
            Console.WriteLine("Оклад:");
            worker2.Salary = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Премия %:");
            worker2.Bonus = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Стаж работы:");
            worker2.WorkExperience = int.Parse(Console.ReadLine().Trim());

            workers.Add(worker2);

            workers.ForEach(worker => Console.WriteLine(worker));
        }

        private void PartOneSubpartB()
        {
            List<Worker> workers = new List<Worker>();
            ConsoleKey consoleKey = ConsoleKey.Y;

            while (consoleKey == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("New worker");

                Worker worker = new Worker();
                Console.WriteLine("Имя:");
                worker.Firstname = Console.ReadLine().Trim();
                Console.WriteLine("Фамилия:");
                worker.Lastname = Console.ReadLine().Trim();
                Console.WriteLine("Оклад:");
                worker.Salary = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Премия %:");
                worker.Bonus = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Стаж работы:");
                worker.WorkExperience = int.Parse(Console.ReadLine().Trim());

                workers.Add(worker);

                Console.WriteLine("Add new worker? Y - yes, N - no");
                consoleKey = Console.ReadKey(true).Key;
            }

            double summaryTax = 0;
            workers.ForEach(worker => summaryTax += worker.Tax());
            Console.WriteLine($"Summary tax: {summaryTax}");

            Worker bestWorker = workers[0];
            for (int i = 1; i < workers.Count; i++)
            {
                if (workers[i].SalaryWithBonus() > workers[i-1].SalaryWithBonus())
                    bestWorker = workers[i];
            }
            Console.WriteLine($"Best worker is {bestWorker.Lastname}");
        }
    }
}
