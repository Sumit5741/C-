using System;

class Part2
{
    public static void Main()
    {
        Console.WriteLine("Enter Your First Name : ");
        String FirstName = Console.ReadLine();
        Console.WriteLine("Enter Your Last Name : ");
        String LastName = Console.ReadLine();
        Console.WriteLine("Hello "+FirstName+" "+ LastName);
        Console.WriteLine("Hello {0} {1}", FirstName , LastName); // using placeholder
    }
}