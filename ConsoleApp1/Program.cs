using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(CallBack); 

            Console.ReadKey();
          }
        static void CallBack(int i)
        {            
            Console.WriteLine(i);
        }
    }
    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack nobj)
        {
            for (int i = 0; i < 3; i++)
            {
                nobj(i);
            }
        }
    }
    
    
}
