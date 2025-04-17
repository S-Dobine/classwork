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

        Console.WriteLine("Enter a sentence.");
        string sentence = Console.ReadLine();
        
        
        List<string> splitSentence = sentence.Split(" ").ToList(); // Converts the array to a list
        
        //string[] splitSentence = sentence.Split(" ");
        
        //  for (int i = 0; i < splitSentence.Length; i++) // to process an array 
        for (int i = 0; i < splitSentence.Count(); i++) // to process a list to get # of elements
        {
            Console.WriteLine(splitSentence[i]);
            Console.WriteLine("Words #: " + (i+1) + " is: " + splitSentence[i]);
        }

        foreach (string aWord in splitSentence)
            
        {
            Console.WriteLine(aWord);
        }
        
    }
}