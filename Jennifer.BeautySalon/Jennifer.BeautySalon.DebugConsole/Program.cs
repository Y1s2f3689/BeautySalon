using Jennifer.BeautySalon.Domain.Concrete;
using Jennifer.BeautySalon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennifer.BeautySalon.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                var Beautyproduct = new BeautyProduct()
                {
                    Name = "EyebrowBrush",
                    Price = 25m,
                    Description = "This is a beauty product.",
                    Category = "BeautyProduct"
                };

                ctx.BeautyProducts.Add(Beautyproduct);
                ctx.SaveChanges();
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}

