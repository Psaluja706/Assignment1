using System;

namespace TwoStacksProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoubleStack<int> s = new DoubleStack<int>(6);
           
            s.Push1(8);
            s.Push2(10);
            s.Push1(7);
            s.Push1(5);
            s.Push2(20);
            s.Push2(30);
            Console.WriteLine(s.count1());
            Console.WriteLine(s.count2());
            s.print1();
            s.print2();




        }
    }
}
