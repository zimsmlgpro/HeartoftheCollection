namespace HeartoftheCollection.Core.Models;

public class Cards
{
    public int Id { get; set; }     //Primay ID
    public string Name { get; set; } //Name of the card
    public string Type { get; set; } //"Monster", "Spell", or "Trap"
}

public interface ICardService
{
    bool CardExists(string name);
    Cards AddCard(string name);
    IEnumerable<Cards> GetAllCards();
}
