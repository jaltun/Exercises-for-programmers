Console.Write("Enter a noun: ");
string noun = Console.ReadLine();

Console.Write("Enter a verb: ");
string verb = Console.ReadLine();

Console.Write("Enter an adjective: ");
string adjective = Console.ReadLine();

Console.Write("Enter an adverb: ");
string adverb = Console.ReadLine();

string madLibStory = $"Do you {verb} your {adjective} {noun} {adverb}? That's hilarious!";
Console.WriteLine(madLibStory);