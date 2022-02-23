// See https://aka.ms/new-console-template for more information
using System;

class CFG{
    //function to demonstrate
    //working of recursion in cSharp
    static void printFun(int test)
    {
        if (test<1)
            return;
        else{
            Console.Write(test+ " ");

            //statement2
            printFun(test-1);
            Console.Write(test+ " --");
            return;

        }

    }
    //Driver Code
    public static void Main(string[] args)
    {
        int test=3;
        printFun(test);
    }
}
