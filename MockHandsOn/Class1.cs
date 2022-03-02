using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockHandsOn
{
    internal class DelegateExample
    {
        public delegate void demoFunDelegate();

        public static void display1()
        {
            Console.WriteLine("display 1");
        }

        public static void display2()
        {
            Console.WriteLine("display 2");
        }

        public static void display3()
        {
            Console.WriteLine("display 3");
        }

        static void Main()
        {
            demoFunDelegate delg1, delg2, delg3, multicastDelg;

            delg1 = new demoFunDelegate(display1);
            delg2 = new demoFunDelegate(display2);
            delg3 = new demoFunDelegate(display3);

            Console.WriteLine("First multi-casting delegate call(Registering all methods)");
            multicastDelg = delg1 + delg2 + delg3;
            multicastDelg();

            Console.WriteLine("\nSecond multi-casting delegate call (deregistering the first method)");
            multicastDelg = multicastDelg - delg1;
            multicastDelg();



            Console.ReadKey();
        }
    }
}
