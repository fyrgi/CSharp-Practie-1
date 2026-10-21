Console.WriteLine("Extra exercise");

// Add menu for the user to select which exercise they want to run.

string choice = string.Empty;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please select an exercise to run:");
    Console.WriteLine("1. Sum of Random Numbers\n" +
        "2. Classify numbers\n" +
        "3. Simple calculator\n" +
        "9. Exit");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            SumOfRandomNumbers();
            break;
        case "2":
            ClassifyNumbers();
            break;
        case "3":
            SimpleCalculator();
            break;
        case "9":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exiting the program.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Invalid choice. Please select a valid option.");
            Console.WriteLine();
            break;
    }
} while (choice != "9");
/*
 * SumOfRandomNumbers: This method generates a specified number of random numbers between 1 and 100, calculates their sum, and prints the results to the console.
*/
static void SumOfRandomNumbers()
{
    int sum = 0;

    do
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("How many random numbers do you want to generate?");
        try
        {
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                int randomNumber = new Random().Next(1, 101);
                Console.WriteLine($"Random number is: {randomNumber}");
                sum += randomNumber;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum of all random numbers is: {sum}\n");
        }
        catch (FormatException)
        {
            // Handle the case where the input is not a valid integer. Attemt to output an error message in a different color to the console.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Invalid input. Please enter a valid integer.");
            Console.WriteLine();
        }
    } while (sum == 0);
}

/*
 * ClassifyNumbers: A random number is generated in the range [-10, 10]. The method classifies the number as odd or even and positive or negative, and prints the result to the console.
 * 0 is classified as an even number but neither positive nor negative.
*/
static void ClassifyNumbers()
{

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Generating a random number in the range [-10, 10]...");

    int number = new Random().Next(-10, 11);
    string oddOrEven = (number % 2 == 0) ? "even" : "odd";

    if (number > 0)
    {
        Console.WriteLine($"{number} is {oddOrEven} and positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} is {oddOrEven} and negative.");
    } else
    {
        Console.WriteLine($"{number} is an even number but in C# it is neither positive nor negative");
    }

}

static void SimpleCalculator()
{
    Console.WriteLine("To Do - Simple Calculator");
}