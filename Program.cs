using System;
using System.Collections.Generic;
namespace Facade_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kallar på facaden för att hämta data
            var facade = new Facade();
            var data = facade.GetAllData();
            //Skriver ut datan...
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
