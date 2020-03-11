using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace S07_Console
{
    class Menu
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View Account");
            Console.WriteLine("2) View Account By Number");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewAccount();
                    return true;
                case "2":
                    ViewAccountByNumber();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the account owner ID: ");
            return Console.ReadLine();
        }
        private static string ClickWhenDone()
        {
            Console.Write("Click on a key to go back to menu:");
            return Console.ReadLine();
        }

        private static void ViewAccount()
        {
            Console.Clear();
                 
            var accounts = AccountManagement.ReadAccounts();

            ConsoleTable.From<Account>(accounts).Write();


            ClickWhenDone();
        }

        private static void ViewAccountByNumber()
        {

            Console.Clear();


            char[] charArray = CaptureInput().ToCharArray();
            DisplayResult(String.Concat(charArray));


        }

        private static void RemoveWhitespace()
        {
            Console.Clear();

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string id)
        {
            Console.WriteLine($"\r\nYour input ID is: {id}");
            
            var accounts = AccountManagement.ReadAccounts();
            
            try
            {
                int result = Int32.Parse(id);
                Console.WriteLine(result);
                foreach (var account in accounts)
                {
                    if (result.Equals(account.Number))
                        //Console.WriteLine(account);
                    PrintAccount(account);

                }

                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine($"Unable to parse '{id}'");
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }


        }
        private static void PrintAccount(Account account)
        {
            var table = new ConsoleTable("Number","Balance","Label","Owner");
            table.AddRow(account.Number.ToString(), account.Balance.ToString(), account.Label, account.Owner.ToString());
            table.Write();

            
        }
    }
}