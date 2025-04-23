namespace Day1StudentClassExample;

public class Student
{
    /* private means only members of the class can access the data
     * 
     */
    
    private string studentName;
    private List<int> testScores;
    
    /*
     * "constructor" - a special method in a class used to initialize data
     *     1. no return type. 2. has same name as class 3. parameters are optional  4. usually pulic
     *                                  (a constructor with no param. is a "default constructor")
     */

    public Student(string name, List<int> scores)
    {
        studentName = name; // set class data to user input data 
        testScores = scores; // set class data to user input data 
    }

    public void ShowStudent()
    {
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Scores: ");

        foreach (int score in testScores)
        {
            Console.WriteLine(score);
        }
    }
}