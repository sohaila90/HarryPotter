namespace HarryPotter;

public class Store
{
    private List<Item> _listOfAnimals = new List<Item>()
    {
        new Item("Owl", 5),
        new Item("Rat", 1),
        new Item("Cat", 10),
    };

    private List<Item> _listOfWands = new List<Item>()
    {
        new Item("Phoenix wand", 5),
        new Item("Unicorn wand", 7),
        new Item("Magic wand", 15),
    };

    public void BuyAnimals(HarryPotter character)
    {
        PrintList(_listOfAnimals);
        Console.WriteLine("Choose on of the options to buy an animal");
        var userOption = Console.ReadLine();
        var number = int.Parse(userOption);
        character.Inventory.Add(_listOfAnimals[number-1]);
    }
    
    //Du får tilgang til alle funksjonene som er public i HarryPotter class
    public string BuyWands(HarryPotter character)
    {
        PrintList(_listOfWands);
        Console.WriteLine("Choose the wand you would like to buy");
        var userOption = Console.ReadLine();
        //For å konvertere fra string til tall
        var number = int.Parse(userOption);
        //Legger til i karakterens inventory 
        character.Inventory.Add(_listOfWands[number-1]);
        return _listOfWands[number -1].Name;
    }

    public void PrintList(List<Item> list)
    {
        int i = 1;
        foreach (var item in list)
        {
            Console.WriteLine($"{i++} Product: {item.Name} Quantity: {item.Quantity}");
        }
    }
}