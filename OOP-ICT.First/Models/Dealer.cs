namespace OOP_ICT.Models;

public class Dealer
{
    private readonly List<Card> _deck;
    private Stack<Card> _shuffledDeck = new Stack<Card>();

    public Stack<Card> ShuffledDeck => _shuffledDeck;

    public Dealer(CardDeck deck)
    {
        _deck = deck.Deck;
    }
    
    private List<Card> Shuffle()
    {
        var shuffledDeck = _deck.OrderBy(card => Guid.NewGuid()).ToList();
        return shuffledDeck;
    }
    
    public Card GiveCard()
    {
        if (_shuffledDeck.Count == 0)
            _shuffledDeck = new Stack<Card>(Shuffle());
        return _shuffledDeck.Pop();
    }
}
