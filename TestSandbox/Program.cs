
Console.WriteLine("Hello, World!");

static int Add(int a, int b)
{
    return a + b;
}

static void getNumbers()
{
    Console.WriteLine("Enter two numbers to add:");

    // Read first number
    Console.Write("First number: ");
    string? input1 = Console.ReadLine();
    int.TryParse(input1, out int number1);

    // Read second number
    Console.Write("Second number: ");
    string? input2 = Console.ReadLine();
    int.TryParse(input2, out int number2);

    Console.WriteLine($"You entered: {number1} and {number2}");

    int sum = Add(number1, number2);
    Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
}
getNumbers();
