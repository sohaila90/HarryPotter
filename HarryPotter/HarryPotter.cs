namespace HarryPotter;

public class HarryPotter
{
    public string Name { get; private set; }
    public string House { get; private set; }
    public List<Item> Inventory = new List<Item>();

    public HarryPotter(string name, string house)
    {
        Name = name;
        House = house; 
    }
    
    public string PrintInfo()
    {
        return $"{Name} {House} {ShowInventory()}";

    }

    public string ShowInventory()
    {
        string items = "";
        foreach (var item in Inventory)
        {
            items += item.Name +" ";
        }

        return items;

    }
}


// Du skal starte med å lage en harrypotter character klasse med egenskaper som
// navn, house, inventory (ex wand eller pet)
//// Få applikasjonen til å printe ut en introduksjon for karakteren,
// // som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har
// //