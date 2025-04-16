namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        /* 1. ask user to enter a sentence
            2. display each word from the sentence
            3. split the sentence into words ( .split() will 
            extract parts of a string into an array based on characters in ()
         */

        Console.WriteLine("Enter a sentece.")
        string sentence = Console.ReadLine();
        string[] splitSentence = sentence.Split("");
    }
}