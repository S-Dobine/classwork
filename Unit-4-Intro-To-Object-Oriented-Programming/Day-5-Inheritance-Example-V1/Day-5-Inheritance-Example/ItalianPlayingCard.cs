using Day_5_Inheritance_Example;

namespace Day_5_Inheritance_Example;

public class ItalianPlayingCard : PlayingCard
{
    //  define a constructor that calls the base class constructor
    public ItalianPlayingCard() : base(0, "Joker", "Black")
    {
    }

    public ItalianPlayingCard(int theValue, string theSuit, string theColor)
    : base(theValue, theSuit, theColor)
    {
    }
}