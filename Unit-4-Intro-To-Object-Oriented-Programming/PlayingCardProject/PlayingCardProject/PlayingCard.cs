namespace PlayingCardProject;

public class PlayingCard
{
    private string suit;
    private string color;
    private int value;

    public PlayingCard(string suitName, string theColor, int theValue)
    {
        suit = suitName;
        value = theValue;
        color = theColor;
    }

    public override string ToString()
    {
        return $"Value: {value} color: {color} suit: {suit}";
    }
}