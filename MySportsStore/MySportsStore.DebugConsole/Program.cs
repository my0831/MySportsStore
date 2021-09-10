using MySportsStore.Domain.Concrete;
using MySportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start...");

            using (var ctx = new EFDbContext())
            {

                for (int i = 0; i < 10; i++)
                {
                    var product = new Product
                    {
                        Name = $"Football{i}",
                        Price = i + 12,
                        Description = $"This is a fooball{i}"
                    };
                    ctx.Products.Add(product);
                }


                ctx.SaveChanges();
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
