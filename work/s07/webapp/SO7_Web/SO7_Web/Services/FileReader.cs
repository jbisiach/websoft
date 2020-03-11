using Newtonsoft.Json;
using SO7_Web.Models;
using System.Collections.Generic;
using System.IO;

namespace SO7_Web.Services
{
    public class FileReader
    {

        public static List<Account> ReadAccounts()
        {
            string file = "data/account.json";

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();
               //Console.WriteLine(data);

                List<Account> json = JsonConvert.DeserializeObject<List<Account>>(data);

                //Console.WriteLine(json);
                return json;
            }
        }
    }
}
