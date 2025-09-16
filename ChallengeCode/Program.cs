using System.Net.Security;

//Ask for player name and remember it
Console.WriteLine("What's up, I'm a mischievous little goblin. I've got a sword for sale. What's your name?");
string playerName = Console.ReadLine();

//Ask player for sum of held gold
Console.WriteLine($"{playerName}! That's awesome, I dig it. How much gold do ya have?");
string playerGold = Console.ReadLine();
int goldNumber = int.Parse(playerGold);

//If the player has 15 or more gold, purchase the item and deduct the cost from their gold, print out how much gold the player has left
if (goldNumber >= 15)
{
    Console.WriteLine("Oh yeah, that's perfect. Here, take it, I already stole your gold.");
    goldNumber = goldNumber - 15;
    Console.WriteLine($"({playerName} got a Bronze Sword. {playerName}'s pockets feel lighter... {playerName} has {goldNumber} gold left.)");
}

//Fallback dialogue for if the player enters a negative number
else if (goldNumber < 0)
{
    Console.WriteLine("What!? How do you have NEGATIVE GOLD!? This must be some dark magic, I'm getting outta here!");
    Console.WriteLine($"({playerName} scared the goblin off with a paranormal amount of gold. It does not seem like he will come back.)");
}

//Could I create a fallback for if the player enters a non-integer?

//If the player does not have enough gold, tell them how much more they need
else
{
    int requirement = 15 - goldNumber;
    Console.WriteLine($"Aw c'mon {playerName}, that's not enough gold to feed my goblin family. Come back when you have {requirement} more!");
    Console.WriteLine($"(It seems like the goblin will sell something for 15 gold, but {playerName} only has {goldNumber} gold.)");
}
