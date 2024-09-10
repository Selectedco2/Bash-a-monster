

Character Warlock = new Character();
Enemy Abomination = new Enemy();

Console.WriteLine("You encounter an abomination and a shiver runs down your spine.");
Console.WriteLine("He rushes towards you and initiates combat");
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine($"{Warlock.name} has {Warlock.health} health");
Console.WriteLine($"{Abomination.name} has {Abomination.health} health");
Console.WriteLine("Would you like to attack or make peace? [A) Attack!] [B) Pacifist]");

string firstStrike = Console.ReadLine().ToLower();

if (firstStrike == "a")
{
    Console.WriteLine("You quickly launch a fireball at your fingertips before the abomination can think");
}
else if (firstStrike == "b")
{
    Console.WriteLine("The monster ");
}

Console.ReadKey();

while (Warlock.health > 0 && Abomination.health > 0)
{
    
}


