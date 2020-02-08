using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace REFLECTION
{
    class Program
    {
        static void Main(string[] args)
        {
            //reflection in .net is all knowing the variou types.their mwthods,funtions,return types
            //as well as parameters information contained in the application during run time
            //all the references related classes are available in the namespace system.reflection

            Assembly assembly = Assembly.Load("empcomponent");
           // Assembly asse = Assembly.Load("product");
            Type[] types = assembly.GetTypes();
            foreach(Type type in types,)
            {
                Console.WriteLine("base type:{0}", type.BaseType);
                Console.WriteLine("name of the type:{0}", type.Name);

                MethodInfo[] methods = type.GetMethods();
               

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("method name:{0}", method.Name);
                    Console.WriteLine("method return type:{0}", method.ReturnType);

                    ParameterInfo[] Parameters = method.GetParameters();


                    foreach (ParameterInfo param in Parameters)
                    {
                        Console.WriteLine("parameter name:{0}", param.Name);
                        Console.WriteLine("parameter type:{0}", param.ParameterType);
                    }
                    Console.WriteLine("_______________");
                   
                }
                Console.WriteLine("_______________");

            }
            Console.WriteLine("_______________");
        }
    }
}
