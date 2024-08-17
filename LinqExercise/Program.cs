using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    internal class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        private static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var numberSum = numbers.Sum();
            Console.WriteLine(numberSum);
            Console.WriteLine();


            //TODO: Print the Average of numbers
            var numberAverage = numbers.Average();
            Console.WriteLine(numberAverage);
            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console
            var numberAscending = numbers.OrderBy(x => x);

            foreach (var num in numberAscending)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();


            //TODO: Order numbers in descending order and print to the console
            var numberDescending = numbers.OrderByDescending(x => x);

            foreach (var number in numberDescending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();


            //TODO: Print to the console only the numbers greater than 6
            var numberGreaterThan6 = numbers.Where(x => x > 6);
            foreach (var number in numberGreaterThan6)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var numList = numberAscending.ToList();
            foreach (var number in numList)
            {
                if (number < 4)
                { Console.WriteLine(number); }
            }


            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 36;
            var numberDescending2 = numbers.OrderByDescending(x => x);
            foreach (var number in numberDescending2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();



            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var employeesCOrS = employees.Where(x => x.FirstName.StartsWith("C") ||
                x.FirstName.StartsWith("S"))
                .OrderBy(x => x.FirstName);

            foreach (var employeeCOrS in employeesCOrS)
            {
                Console.WriteLine(employeeCOrS.FullName);
            }
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var employeesOver26 = employees.Where(x => x.Age > 26)
                .OrderBy(x => x.Age)
                .ThenBy(x => x.FirstName);

            foreach (var employeeOver26 in employeesOver26)
            {
                Console.WriteLine(employeeOver26.FullName);
            }
            Console.WriteLine();


            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var employeesYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var yoeSum = employeesYOE.Sum(x => x.YearsOfExperience);
            Console.WriteLine(yoeSum);
            Console.WriteLine();


            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoeAverage = employeesYOE.Average(x => x.YearsOfExperience);
            Console.WriteLine(yoeAverage);
            Console.WriteLine();


            //TODO: Add an employee to the end of the list without using employees.Add()
            var employee = new Employee("Logan", "Tolbert", 36, 0);
            var updatedEmployees = employees.Append(employee);

            foreach (var emply in updatedEmployees)
            {
                Console.WriteLine(emply.FullName);
            }
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
