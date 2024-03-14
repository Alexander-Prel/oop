namespace OOP_ICT.Models;

using EnumCard;

public class CardDeck
{
    private readonly List<Card> _cards = new();

    public List<Card> Deck => _cards.ToList();

    public CardDeck()
    {
        CreateDeck();
    }
    
    private void CreateDeck()
    {
        foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
        {
            foreach (Suites suit in Enum.GetValues(typeof(Suites)))
            {
                _cards.Add(new Card(rank, suit));
            }
        }
    }
}