namespace AddNumbers;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("---Start of Program---");

        //  Ask user for 3 numbers, 1 at a time
        // Produce a sum of these numbers

        //  1. Do this 3 times ( a loop)
        //      Ask user to enter number
        //      Get number from user
        //      Add the number to a sum

        //  2. Display sum of the numbers

        //  Data we need:
        // 1. a place to hold the numbers 
        // 2. a place to hold the sum

        // Define a place to hold the number entered by the user
        int entry = 0;

        // Define a place to hold the sum of the numbers
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Number:");
            entry = int.Parse(Console.ReadLine());

            //  Ask user to enter a number


            //  Get the number they type


            //  Add the number to the sum
            sum += entry; // or sum += entry
        }

        Console.WriteLine("The sum is "+ sum);


        

        Console.WriteLine("---End of Program---");

        
    }
}