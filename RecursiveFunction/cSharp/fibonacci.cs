using System;

namespace Fib
{
    class program
    {
        static int fib(int n)
        {
            if (n==0)
                return 0;
            if (n==1 || n==2)
                return 1;
            else 
                return(fib(n-1)+fib(n-2));
        }
        static void Main()
        {
            int n=5;
            Console.WriteLine("5 satısının fibonacci serisi :");

            for (int i=0;i<n;++)
            {
                Console.WriteLine(fib(i)+" ");
            }
        }
    }
}