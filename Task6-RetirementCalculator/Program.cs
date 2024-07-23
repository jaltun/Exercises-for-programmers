    Console.Write("What is your current age? ");
    int currentAge = Convert.ToInt32(Console.ReadLine());

    Console.Write("At what age would you like to retire? ");
    int retirementAge = Convert.ToInt32(Console.ReadLine());

    int currentYear = DateTime.Now.Year;

    int yearsLeft = retirementAge - currentAge;

    int retirementYear = currentYear + yearsLeft;

    Console.WriteLine($"You have {yearsLeft} years left until you can retire.");
    Console.WriteLine($"It's {currentYear}, so you can retire in {retirementYear}.");
