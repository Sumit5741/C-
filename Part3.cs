using System;
class Part3
{
    public static void Main(String [] args)
    {
        bool b = true;
        string s = "Sumit";
        int i = 123;
        float f = 124672.568868668686f;
        double d = 124.3574847775858950d;
        Console.WriteLine("Boolean Value is : {0}", b);
        Console.WriteLine("String Value is : {0}", s);
        Console.WriteLine("Integer Value is : {0}", i);
        Console.WriteLine("Float Value is : {0}", f);
        Console.WriteLine("Double Value is : {0}", d);
        double val = float.MaxValue;

        Console.WriteLine("Integer Minimum Value is : ", val);
    }
}
