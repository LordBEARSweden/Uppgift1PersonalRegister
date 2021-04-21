using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift1PersonalRegister
{
    class Program
    {

        static void Main(string[] args)
        {
            bool  MainMenu = true;
            char input = ' ';
            List<Employees> infoList = new List<Employees>();

            do 
            {
                Console.WriteLine("Welcome to the emloyee directory!");
                Console.WriteLine("Press 1 to register a new employee");
                Console.WriteLine("press 2 to get the list of all employees");
                Console.WriteLine("press q to exit the program");
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException){ }
               
                switch (input)
                {
                    case 'q':
                        Console.WriteLine("You will now exit the program");
                        MainMenu = false;
                        break;

                    case '1':
                        var employee = new Employees();
                        Console.WriteLine("Register a new employee");
                        Console.WriteLine("Enter First name");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last name");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        string Salary = Console.ReadLine();
                        Console.WriteLine("Employee successfully registered");
                        employee.FirstName = FirstName;
                        employee.LastName = LastName;
                        employee.Salary = Salary;
                        infoList.Add(employee);

                        break;

                    case '2':
                        Console.WriteLine("Showing the list of all employees");
                     
                        foreach (var tmpEmployee in infoList)
                        {
                            Console.WriteLine($"{tmpEmployee.FirstName} {tmpEmployee.LastName} earns: {tmpEmployee.Salary}");
                        }
                        Console.WriteLine("Press any key to return to the main menu");
                        Console.ReadKey();
                        break;
                }
            } while (MainMenu);
        }
    }
}
