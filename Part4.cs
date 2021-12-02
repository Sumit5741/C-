using System;

namespace SamplePart4
{
    class Part4
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(@"\\Hello");   // Verbatim Literal
            String name = "C\\OuterFile\\InnerFile";
            Console.WriteLine("Old File Location is : {0}", name);
            name = @"C\OuterFile\InnerFile1";
            Console.WriteLine("New File Location is : {0}", name);
            name = "\"Sumit\"";
            Console.WriteLine(name);
        }

    }
}
