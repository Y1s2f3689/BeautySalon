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
                var Beautyproduct = new BeautyProduct() { };
                ctx.BeautyProducts.Add(Beautyproduct);
                ctx.SaveChanges();
            }
        }
    }
}
