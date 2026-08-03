Console.WriteLine("==============");
Console.WriteLine(" Number Guessing game ");
Console.WriteLine("==============");

Random random = new Random();

int secretNumber = random.Next(1, 101);

int attempts = 0;

while (true)
{

Console.Write("Enter your guess (between 1 and 100): ");

string? input  = Console.ReadLine();

if (!int.TryParse(input, out int userGuess) || userGuess < 1 || userGuess > 100)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
    continue;
}

attempts++;

Console.WriteLine($"You guessed: {userGuess}");

if (userGuess < secretNumber)
{
    Console.WriteLine("Too low! Try again.");
}
else if (userGuess > secretNumber)
{
    Console.WriteLine("Too high! Try again.");
}
else
{
    Console.WriteLine("Congratulations! You guessed the correct number!");
    Console.WriteLine($"You guessed the number in {attempts} attempts.");
    break;
}
}