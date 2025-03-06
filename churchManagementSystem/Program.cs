﻿using System;

namespace churchManagemenetSystem
{
    internal class Program
    {
        static string username = "ken";
        static string password = "123";
        static void Main(string[] args)
        {

            login_Dashboard();

        }
        static void login_Dashboard()
        {
            int userChoice;
            Console.WriteLine("\nWELCOME TO ADELINA CHRISTIAN CHURCH");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("[1] Register");
            Console.WriteLine("[2] Log in");
            Console.WriteLine("[3] Log in as an Admin (Leader)");

            Console.Write("Enter your Choice: ");
            userChoice = Convert.ToInt16(Console.ReadLine());

            while (true)
            {
                if (userChoice == 1)
                {
                    registration();
                    return;
                }
                else if (userChoice == 2)
                {
                    login();
                    return;
                }
                else if (userChoice == 3)
                {
                    leaders_login();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
        }

        static void registration()
        {
            Console.WriteLine("\nREGISTRATION");
            Console.WriteLine("-----------------------");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Email Address: ");
            string emailAddress = Console.ReadLine();
            Console.Write("Are you an Officer or an Admin? [1]Yes [2]No: ");
            int positionChoices = Convert.ToInt16(Console.ReadLine());

            if (positionChoices == 1)
            {
                Console.Write("Enter Ministry: ");
                string ministry = Console.ReadLine();
                Console.Write("Enter Position: ");
                string position = Console.ReadLine();

            }
            else if (positionChoices == 2)
            {

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.Write("Create Username: ");
            username = Console.ReadLine();


            while (true)
            {
                Console.Write("Create your Password: ");
                password = Console.ReadLine();

                Console.Write("Re-Enter your Password: ");
                string re_Enter_Password = Console.ReadLine();

                if (password != re_Enter_Password)
                {
                    Console.WriteLine("Password does not Match. Try again");

                }
                else
                {

                    Console.WriteLine("Registration Complete!!");
                    login_Dashboard();
                    return;

                }
            }
        }

        static void login()
        {
            Console.WriteLine("\nACC USER LOGIN");
            Console.WriteLine("-----------------");

            string login_userName;
            string login_password;

            int attempt = 0;
            int maxAttempt = 5;

            while (attempt < maxAttempt)
            {

                Console.Write("Username: ");
                login_userName = Console.ReadLine();
                Console.Write("Password: ");
                login_password = Console.ReadLine();

                if (username == login_userName && password == login_password)
                {
                    Console.WriteLine("Login Successfully");
                    dashBoard();
                }

                attempt++;

                if (attempt < maxAttempt)
                {
                    if (username != login_userName || password != login_password)
                    {
                        Console.WriteLine("No username or password found. Try Again");
                        Console.WriteLine($"Attampt: {attempt} of {maxAttempt}");
                    }
                }
            }
            Console.WriteLine("Oops!!! You Reached Maximum Attempt. Try Again Later");
            Thread.Sleep(10000);
            login_Dashboard();
        }

        static void leaders_login()
        {
            Console.WriteLine("\nACC LEADERS LOGIN");
            Console.WriteLine("-----------------");

            string login_userName;
            string login_password;

            int attempt = 0;
            int maxAttempt = 5;

            while (attempt < maxAttempt)
            {
                Console.Write("Ministry: ");
                string ministry = Console.ReadLine();
                Console.Write("Position: ");
                string position = Console.ReadLine();
                Console.Write("Username: ");
                login_userName = Console.ReadLine();
                Console.Write("Password: ");
                login_password = Console.ReadLine();

                if (username == login_userName && password == login_password)
                {
                    Console.WriteLine("Login Successfully");
                    dashBoard();
                    return;
                }

                attempt++;

                if (attempt < maxAttempt)
                {
                    if (username != login_userName || password != login_password)
                    {
                        Console.WriteLine("No username or password found. Try Again");
                        Console.WriteLine($"Attampt: {attempt} of {maxAttempt}");
                    }
                }
            }
            Console.WriteLine("Oops!!! You Reached Maximum Attempt. Try Again Later");
            Thread.Sleep(10000);
            login_Dashboard();
        }

        static void dashBoard()
        {
            Console.WriteLine("\n Welcome to Adelina Christian Church");
            Console.WriteLine("Ministry: ");

            string[] ministry = {"[1] Christian Education", "[2] Evagelism Ministrry",
                    "[3] Worship Ministry", "[4] Descipleship Ministry",
                    "[5] Admin", "[6] Prayer Ministry"};

            foreach (string choice in ministry)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter Choice: ");
            int userChoice = Convert.ToInt16(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    christianEdDashboard();
                    break;
                case 2:
                    evangelismDashboard();
                    break;
                case 3:
                    worshipDashboard();
                    break;
                case 4:
                    descipleshipDashboard();
                    break;
                case 5:
                    aminDashboard();
                    break;
                case 6:
                    prayerDashboard();
                    break;
                default:
                    Console.WriteLine("Invalid Input. (Exceed 1-6)");
                    dashBoard();
                    break;

            }



        }
        static void christianEdDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nChristian Education");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

        }

        static void evangelismDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nEvangelism Ministry");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        static void worshipDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nWorship Ministry");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static void descipleshipDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nDescipleship Ministry");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static void aminDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static void prayerDashboard()
        {
            while (true)
            {
                Console.WriteLine("\nPrayer Ministry");
                Console.WriteLine("------------------------");
                Console.WriteLine("No data");
                Console.WriteLine("[2] Return to User Dashboard");
                Console.Write("Action: ");
                int exit = Convert.ToInt16(Console.ReadLine());

                if (exit == 2)
                {
                    dashBoard();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

    }
}
