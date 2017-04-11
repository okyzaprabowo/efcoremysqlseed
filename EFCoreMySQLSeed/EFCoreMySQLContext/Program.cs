using System;
using EFCoreMySQLContext.Models;
using EFCoreMySQLContext.Helpers;

namespace EFCoreMySQLContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EFCoreMySQLSeed");

            var entry = new Example()
            {
                ExampleName = "John",
                ExampleDesc = "Visit My Blog At okyzaprabowo.wordpress.com"
            };

            using(var context = BaseContext.Connect(Constants.ConnectionString))
            {
                context.Example.Add(entry);
                context.SaveChanges();
                Console.WriteLine("Data was added");
            }

            Console.ReadKey();
        }
    }
}