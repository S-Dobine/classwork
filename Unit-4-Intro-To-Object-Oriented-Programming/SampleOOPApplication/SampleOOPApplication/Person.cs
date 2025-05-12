namespace SampleOOPApplication;

public class Person
{
    /* This class will represent a Person
     *
     * A class has data (attributes) and methods (behavior)
     *
     * Attributes: Name     Age     Gender   Height    Weight
     *
     */

    // Instance Variables identify attributes unique to an object of a class

    private string _name;
    private int _age;
    private string _gender;
    private double _weightPounds;
    private double _heightFeet;
    private string _eyeColor;
    private string _hairColor;

    /*****************************************************/
    // Properties to allow access to the data
    /*****************************************************/
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Gender
    {
        get => _gender;
        set => _gender = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double WeightPounds
    {
        get => _weightPounds;
        set => _weightPounds = value;
    }

    public double HeightFeet
    {
        get => _heightFeet;
        set => _heightFeet = value;
    }

    public string EyeColor
    {
        get => _eyeColor;
        set => _eyeColor = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string HairColor
    {
        get => _hairColor;
        set => _hairColor = value ?? throw new ArgumentNullException(nameof(value));
    }
}
