Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondtNum = Int32.Parse(Console.ReadLine());

switch(userOperator)
{
    case '+':
        Addition(firstNum, secondtNum);
        break;
    case '-':
        Subtraction(firstNum, secondtNum);
        break;
    default:
        Console.WriteLine("Error");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}