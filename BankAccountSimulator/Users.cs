public class User
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string cardNumber { get; set; }
    public string cardPin { get; set; }
    public string userBalance { get; set; }

    public User(string first, string last, string card, string pin, string balance)
    {
        firstName = first;
        lastName = last;
        cardNumber = card;
        cardPin = pin;
        userBalance = balance;
    }

}