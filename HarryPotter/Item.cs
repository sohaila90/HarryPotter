namespace HarryPotter;

public class Item
{
    public string Name { get; private set; }
    public int Quantity { get; set; }

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}