using System;
using System.Collections.Generic;
namespace Facade_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var facade = new Facade();
            var data = facade.GetAllData();
            Console.WriteLine(data);
        }
    }
}
