namespace FirstProgram;
/*
 * This program will ask for 3 numbers
 *      Add them together AND display the total
 */
// Programming Solution - Human thinking 
// -Ask for the numbers
// -Write down numbers as given
// -Add them together to obtain total
// -Tell the requester the total(display)
//              Programming > Code
//1. a place to write down each number - variables
//2. a place to hold the numbers
//3. a way to ask for the numbers - methods (object.method())
//4. a way to receive numbers
//5. a way to report the sum/total 

class Program
{
    static void Main(string[] args)
    {
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        int sum = 0;
        
        Console.WriteLine("--- Starting Program ---");
        
        Console.Write("Enter a number: ");
        number1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("--- Ending Program ---");
    }
}