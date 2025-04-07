namespace StringsNumbersConsole;

class Program
{
    static void Main(string[] args)
    {
        /*  Exercise 1.1: Echo String
         *  1. Prompt the user to enter a string
         *  2. Output the string back to the console
         */

        Console.WriteLine("Hello, enter your favorite color.");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine($"The color {favoriteColor} is a cool favorite color.");
        
        /*  Exercise 1.2: Adding a number to an integer
         *  1. Prompt the user to enter a number
         *  2. Add 1 to the given number
         *  3. Print the number to the console
         */
        
        Console.WriteLine("Next, enter a random number between 0 and 100.");
        int randomNumber = int.Parse(Console.ReadLine());
        ++randomNumber;
        Console.WriteLine("For my next trick, I'm going to add one... giving us..." + randomNumber);
        
        /* Exercise 1.3: Adding a number to a float
         *  1. Prompt the user to enter a number
         *  2. Add 0.5 to the given number
         *  3. Print the number to the console
         */
        
        Console.WriteLine("Now, enter another number between 0 and 100.");
        double anotherNumber = double.Parse(Console.ReadLine());    
        anotherNumber = anotherNumber + 0.5;
        Console.WriteLine("When we add 0.5 to that we get... " + anotherNumber);
        
        /*  Exercise 1.4: Adding Two Floats
         *  1. Prompt the user to enter 2 separate numbers
         *  2. Add them together
         *  3. Produce the sum to the console
         */
        
        Console.WriteLine("Now, enter a random number between 0 and 100.");
        int ranNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Next enter another random number between 0 and 100. They're going to be added together.");
        int ranNumber2 = int.Parse(Console.ReadLine());
        int sum = ranNumber + ranNumber2;
        Console.WriteLine("The sum of the 2 numbers you entered are " + sum);
        
        /*  Exercise 1.5: Multiplying Floats
         *  1. Prompt the user to enter 2 separate numbers
         *  2. Multiply them together
         *  3. Produce the product to the console
         */
        
        Console.WriteLine("Enter in a number.");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter in another number.");
        int num2 = int.Parse(Console.ReadLine());
        int product = num1 * num2;
        Console.WriteLine("The product of the numbers you entered are " + product);
        
        /*  Exercise 1.6: Dividing Integers
         *  1. Prompt the user to enter 2 separate numbers
         *  2. Divide the numbers
         *  3. Produce the quotient
         */
        
        Console.WriteLine("Enter in a number.");
        double numb1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter in another number.");
        double numb2 = int.Parse(Console.ReadLine());
        double quotient = numb1 / numb2;
        Console.WriteLine("The quotient of the number you entered are " + quotient);
        
        /* Exercise 1.7: Entering booleans
         *  1. Prompt the user to enter a boolean
         *  2. Write out the boolean value
         *  3. Write out the opposite of the boolean variable.
         */
        
         Console.WriteLine("There are 28 letters in the English Alphabet. Enter true or false.");
         string input = Console.ReadLine();

         if (input == "true")
         {
               Console.WriteLine("No, there are 26 letters in the English Alphabet.");
         }
         else if (input == "false")
         {
          Console.WriteLine("Good, you know there are 26 letters in the English Alphabet.");
         }
         
    }
}




