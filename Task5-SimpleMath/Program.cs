Console.Write("What is the first number? ");
string firstNumberString = Console.ReadLine();
int firstNumber = int.Parse(firstNumberString);

Console.Write("What is the second number? ");
string secondNumberString = Console.ReadLine();
int secondNumber = int.Parse(secondNumberString);

int sum = firstNumber + secondNumber;
int difference = firstNumber - secondNumber;
int product = firstNumber * secondNumber;
int quotient = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {quotient}");