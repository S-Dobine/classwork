namespace Day1StudentClassExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Class Example");
        
        // instantiate (define) a student class object
        
        // data-type name = initializer; int sum =0;
        
        // a class is instantiated with the new keyword
        // className name = new className(initializer);

        List<int> scores = new List<int> ();
        scores.Add(100);
        scores.Add(90);
        scores.Add(80);
        
        
        Student aStudent = new Student("Francis", scores);
        
        // display the student object we created
        Console.WriteLine("aStudent:" + aStudent);
        
        aStudent.ShowStudent();
    }
}