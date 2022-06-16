using System;
using System.Linq;

namespace ClassInheritanceConsoleApp.Model
{
    internal class Student : Person
    {
        private int _clazz;
        private int[] _grades;

        public int Class { get => _clazz; set => _clazz = value; }
        public int[] Grades { get => _grades; set => _grades = value; }

        public Student() : this(0, new int[] { }, "", "", '-', DateTime.Now) { }

        public Student(int clazz, int[] grades, string firstname, string lastname, char gender, DateTime birthday) : base(firstname, lastname, gender, birthday)
        {
            _clazz = clazz;
            _grades = grades;
        }

        public int CountOfLessons()
        {
            return _grades.Length;
        }

        public int NextClass()
        {
            int averageGrade = _grades.Sum() / _grades.Length;
            int nextClass = _clazz;
            if (averageGrade >= 3)
                nextClass = (_clazz < 11) ? _clazz + 1 : 20;
            else
                _grades = new int[] { };
            
            return nextClass;
        }

        public override string ToString()
        {
            return $"{Fullname}, Пол: {Gender}, Дата рождения: {Birthday:dd.MM.yyyy}, Класс: {Class}, Следующий класс: {NextClass()}, Предметов: {CountOfLessons()}, Оценки: {string.Join(",", Grades)}";
        }
    }
}
