using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            ///A delegate is a type safe function pointer 
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegates");

            //OR WE CAN DIRECTLY USE
            Hello("Alternative way to call delegates");

        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadKey();
        }
    }
}
