using System;
namespace TypeConversions
{
    class Part7
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Type Conversion");
            int a = 10;
            float f = a;
            Console.WriteLine(a);
            Console.WriteLine("After Implicit Conversion the value is f is : {0}",f);
            float f1 = 12.9999f;
            int i1 = (int)f1;
            int i2 = Convert.ToInt16(f1);
            Console.WriteLine(f1);
            Console.WriteLine("After Explicit conversion the value of i1 is : {0}", i1);
            Console.WriteLine("After Explicit conversion the value of i2 is : {0}", i2);
        }
    }
}