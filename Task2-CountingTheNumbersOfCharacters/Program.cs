string inputString = "";
int stringLength = inputString.Length;
do
{
    Console.Write("What is the input string? ");
    inputString = Console.ReadLine();

    //stringLength = inputString.Length;
} while (stringLength == 0);
Console.WriteLine($"{inputString} has {stringLength} characters.");
