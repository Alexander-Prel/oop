namespace OOP_ICT.Models;

using EnumCard;

public class Card
{
    public Ranks Rank { get; }
    public Suites Suit { get; }

    public Card(Ranks rank, Suites suit)
    {
        Rank = rank;
        Suit = suit;
    }
}