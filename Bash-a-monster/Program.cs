

Character Warlock = new Character();
Enemy Abomination = new Enemy();

Console.WriteLine("You encounter an abomination and a shiver runs down your spine.");
Console.WriteLine("He rushes towards you and initiates combat");
Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine($"{Warlock.name} has {Warlock.health} health");
Console.WriteLine($"{Abomination.name} has {Abomination.health} health");
Console.WriteLine("Would you like to attack, make peace... or get freaky..? [A) Fireball] [B) Peace]");

string firstStrike = Console.ReadLine().ToLower();

if (firstStrike == "a")
{
    Console.WriteLine("You quickly lunge at the abomination before he can think");
}
else if (firstStrike == "b")
{
    Console.WriteLine("");
}

Console.ReadKey();

while (Warlock.health > 0 && Abomination.health > 0)
{
    
}


