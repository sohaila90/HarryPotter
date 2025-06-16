namespace HarryPotter;

public class HarryPotterGame
{
    private Store _myAnimal = new Store();
    private Store _myWand = new Store();

    private List<HarryPotter> _harryPotters = new List<HarryPotter>()
    {
        new HarryPotter("Harry Potter", "Gryffindor"),
        new HarryPotter("Hermione Granger", "Slytherin"),
        new HarryPotter("Ron Weasley", "Hufflepuff"),
    };
    
    public void StartAdventure()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Harry Potter game, please choose an option below to continue: ");
            Console.WriteLine("1. Show an introduction of the characters");
            Console.WriteLine("2. Buy animals");
            Console.WriteLine("3. Buy a magic wand");
            Console.WriteLine("4. Cast a spell");
            
            var userOption = Console.ReadLine();
            switch (userOption)
            {
                case "1":
                    //Intro til karakterene
                    CharacterIntro();
                    break;
                case "2":
                    //Lag valg for å kjøpe produkter
                    // prøv å lage en metode til dette etterhvert
                    Console.WriteLine("Choose a character");
                    for (int j = 0; j < _harryPotters.Count; j++)
                    {
                        Console.WriteLine($"{j +1 }. {_harryPotters[j].Name}");
                    }
                    var userInput = Console.ReadLine();
                    int index = int.Parse(userInput) -1;
                    var chooseCharacter = _harryPotters[index];
                    _myAnimal.BuyAnimals(chooseCharacter);
                    break;
                case "3":
                    ShowWands(_harryPotters[0]);
                    break;
                case "4": 
                    // Lag valg for å utføre trylleformel
                    Console.WriteLine("Choose the spell you want to cast");
                    Console.WriteLine("1. Make a feather fly");
                    Console.WriteLine("2. Sets off fireworks");
                    var userSpellInput = Console.ReadLine();
                    switch (userSpellInput)
                    {
                        case "1":
                            Console.WriteLine($"You made a feather fly: vingardium leviosa");
                            break;
                        case "2":
                            Console.WriteLine($"Hokus pokus fireworks!!");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Press any key to go back to the menu");
            Console.ReadKey();
        }
    }

    private void CharacterIntro()
    {
        Console.WriteLine($"Here is an introduction of the characters name and houses the live in");
        foreach (var character in _harryPotters)
        {
            Console.WriteLine(character.Name);
            Console.WriteLine(character.House);
        }

    }

    private void ShowWands(HarryPotter character)
    {
        Console.WriteLine("Choose a character:");
        for (int i = 0; i < _harryPotters.Count; i++)
        {
            Console.WriteLine($"{i +1} {_harryPotters[i].Name}");
        }
        var userWandInput = Console.ReadLine();
        int index = int.Parse(userWandInput) - 1;
        var chooseCharacter = _harryPotters[index];
        var wand = _myWand.BuyWands(chooseCharacter);
        Console.WriteLine($"{chooseCharacter.Name} is now a owner of a {wand}");
    }
}