using System;
using System.IO;
using System.Text.Json;

using System.Collections.Generic;
namespace S07_Console
{
    class AccountManagement
    {
        static void init()
        {

            Console.WriteLine("Working directory -> " + Environment.CurrentDirectory);
            
            var accounts = ReadAccounts();

            Console.WriteLine("Show all accounts (and add 1 money to their balance)");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
                account.Balance += 1;
            }

            Console.WriteLine("The balance has increased by 1");
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine("Save the updated account balance");
            SaveAccounts(accounts);
        }

       public static IEnumerable<Account> ReadAccounts()
        {
            String file = "../data/account.json";

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();
                //Console.WriteLine(data);

                var json = JsonSerializer.Deserialize<Account[]>(
                    data,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                //Console.WriteLine(json[0]);
                return json;
            }
        }

        public static void PrintAccountByOwner(String id)
        {
            ReadAccounts();
            
        }

        static void SaveAccounts(IEnumerable<Account> accounts)
        {
            String file = "../data/account.json";

            using (var outputStream = File.OpenWrite(file))
            {
                JsonSerializer.Serialize<IEnumerable<Account>>(
                    new Utf8JsonWriter(
                        outputStream,
                        new JsonWriterOptions
                        {
                            SkipValidation = true,
                            Indented = true
                        }
                    ),
                    accounts
                );
            }
        }
    }
    
 
}

