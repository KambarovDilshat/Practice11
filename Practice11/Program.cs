using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Practice11
{
    public enum Vacancies
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] HireDate; // Формат [год, месяц, день]
        public int Salary;

        public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = hireDate;
            Salary = salary;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}, Vacancy: {Vacancy}, Hire Date: {HireDate[0]}-{HireDate[1]}-{HireDate[2]}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Вася Петров", Vacancies.Developer, new int[] { 2023, 5, 2 }, 40000);
            employee.DisplayInformation();
        }
    }
}