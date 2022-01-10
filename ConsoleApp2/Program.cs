using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };
                //Using LINQ Queries
                UsingLINQExtensions(names);
        }  
        public static void UsingLINQExtensions(string[] names)
        {
            IEnumerable<string> query = names
                .Where(s => s.Length == 5)
                .OrderBy(s => s)
                .Select(s => s.ToUpper());
            foreach (string item in query)
                Console.WriteLine(item);
            Console.Read();
        }


      
        
    }
    
}
