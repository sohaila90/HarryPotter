namespace HarryPotter;

public class HarryPotterGame
{
    private Store _myStore = new Store();
    

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
            Console.WriteLine("3. Cast a spell");
            
        
            var userOption = Console.ReadLine();
            switch (userOption)
            {
                case "1":
                    //Intro til karakterene
                    CharacterIntro();
                    break;
                case "2":
                    //Lag valg for å kjøpe produkter
                    // prøv å lage en metode til dette
                    Console.WriteLine("Choose a character");
                    for (int j = 0; j < _harryPotters.Count; j++)
                    {
                        Console.WriteLine($"{j +1 }. {_harryPotters[j].Name}");
                    }
                    var userInput = Console.ReadLine();
                    int index = int.Parse(userInput) -1;
                    var chooseCharacter = _harryPotters[index];
                    _myStore.BuyAnimals(chooseCharacter);
                    break; 
                case "3": 
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
        
        // trylleformler: 
        // vingardium leviosa (får en fjær til å fly)
        // hokus pokus (fyrer av fyrverkerier)
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
    
}


//Bruker skal kunne velge hvilken karakter han vil styre
//deretter lagre valget han tar
//lage switch for etter det lage et valg om bruker vil gå til butikken eller gjøre trylleformel
// eller om man vil kjøpe dyr, stav



// Få applikasjonen til å printe ut en introduksjon for karakteren,
// som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

// Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:
// ugle,rotte eller en katt. De har også mulighet til å kjøpe
// en tryllestav: føniksstav, unikornstav eller trollstav.