

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @event
{
    class Program
    {
        public delegate void printhandler();

        public event printhandler print;

        public void onPrint()
        {
            Console.WriteLine("printing is done");

        }
        public void show()
        {
            Console.WriteLine("inside the method");
            print();
        }
        static void Main(string[] args)
        {
            Program objp = new Program();
            objp.print += new printhandler(objp.onPrint);
            objp.show();

        }
    }
}
//declare the event along with delegate
//register event handler with respective event handler through the delegete
//raise the event