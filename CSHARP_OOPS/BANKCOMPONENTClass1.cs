using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_component
{
    public class Savingsbank
    {
        public double simpleinterest(double p,int t,double r)
        {
            var si = p * t * r / 100;
            return si;
        }

        public double getbalance(double p,double si)
        {
            var bal = p + si;
            return bal;
        }
    }
}
