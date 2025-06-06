Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine();
int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}