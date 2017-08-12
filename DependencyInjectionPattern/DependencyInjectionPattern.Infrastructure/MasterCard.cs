using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Infrastructure
{
   public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            return "Master Card Charge";
        }
    }
}
