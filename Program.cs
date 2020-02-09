using System;
using Projekat.humanity.page.tests;

namespace Projekat
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor;
            bool izlaz = false;
            do
            {
                PrintMenu();
                izbor = int.Parse(Console.ReadLine());

                switch (izbor)
                {
                    case 0:
                        {
                            Console.WriteLine("Izlaz!");
                            izlaz = true;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Login Tests");
                            HumanityLoginTests.LoginTests();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Add Employees Tests");
                            HumanityAddNewEmployee.AddNewEmployeeTest();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Add Employees Tests");
                            HumanityProfileTests.UploadImageTests();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("All");
                            HumanityLoginTests.LoginTests();
                            HumanityAddNewEmployee.AddNewEmployeeTest();
                            HumanityProfileTests.UploadImageTests();
                            break;
                        }
                }
            } while (!izlaz);

        }

        static void PrintMenu()
        {
            Console.WriteLine("0 - Izlaz");
            Console.WriteLine("1 - Login Tests");
            Console.WriteLine("2 - Employee Tests");
            Console.WriteLine("3 - Profile Tests");
            Console.WriteLine("4 - All Tests");
        }
    }
}
