using OOPAdventure;

Console.WriteLine("Hello What is your name?");

var name = Console.ReadLine();

if (name == String.Empty || name == null) {
    name = "no name";
}

var player = new Player(name);

Console.WriteLine($"Welcome {player.Name} to c# oop adventure");