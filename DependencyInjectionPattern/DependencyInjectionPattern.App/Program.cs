using DependencyInjectionPattern.BusinessLayer;
using DependencyInjectionPattern.Infrastructure;
using DependencyInjectionPattern.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new IocContainer();
            container.Registar<IShoper, Shoper>();
            container.Registar<ICreditCard, VisaCard>();

            var shoper = container.Resolve<ICreditCard>();

            Console.WriteLine(shoper.Charge());
            Console.ReadKey();

        }
    }
}
