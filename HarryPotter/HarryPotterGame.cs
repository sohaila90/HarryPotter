namespace HarryPotter;

public class HarryPotterGame
{
    

    private List<HarryPotter> _harryPotters = new List<HarryPotter>()
    {
        new HarryPotter("Harry Potter", "Gryffindor"),
        new HarryPotter("Hermione Granger", "Slytherin"),
        new HarryPotter("Ron Weasley", "Hufflepuff"),
    };
    
    public void StartAdventure()
    {
        Console.WriteLine("Welcome to the Harry Potter game, please choose an option below to continue: ");
        Console.WriteLine("1. Introduction of the characters");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        
        var userOption = Console.ReadLine();
        switch (userOption)
        {
            case "1":
                //Intro til karakterene
                CharacterIntro();
                break;
            case "2":
                //Lag valg for å kjøpe produkter
                break;
            case "3": 
                // Lag valg for å utføre trylleformel
                break;
        }
        
        Store store = new Store();
        store.BuyAnimals(_harryPotters[0]);
        store.BuyWands(_harryPotters[0]);
        //printer ut alle karakterer
        int i = 1;
        foreach (var harryPotter in _harryPotters)
        {
            Console.WriteLine($"{i++} Your character now owns: {harryPotter.PrintInfo()}");
            
        }
        
    }
    
    public void CharacterIntro()
    {
        Console.WriteLine($"Welcome to the game, lets have an introduction of the characters  lives in");
        foreach (var character in _harryPotters)
        {
            Console.WriteLine(character.Name); 
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