using System.ComponentModel.Design;

namespace String_Examples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    string string1 = "a";
    string string2 = "a";
    
    Console.WriteLine("String1 is " + string1)
}

if (string1.CompareTo(string2) < 0)
{
    Console.WriteLine("string 1 is less than string 2");
}
else
{
    Console.WriteLine("string 1 is not less than string 2");
}