
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
// getNumbers();

static int sumN(int n)
{
    if (n <= 0) return 0;
    Console.WriteLine($"n: {n}");
    return n + sumN(n - 1);
}
// Console.WriteLine(sumN(5)); // Outputs 15 (5 + 4 + 3 + 2 + 1)

static int CountDown(int n)
{
    if (n == 0) return 0;

    Console.WriteLine(n);
    return CountDown(n - 1);
}
// CountDown(5);

static void GenerateBinaryStrings(int n, string current)
{
    if (current.Length == n)
    {
        Console.WriteLine(current);
        return;
    }

    GenerateBinaryStrings(n, current + "0");
    GenerateBinaryStrings(n, current + "1");
}
// GenerateBinaryStrings(3,"");

static void GenerateParentheses(int n, string current, int open, int close)
{
    if (current.Length == n * 2)
    {
        Console.WriteLine(current);
        return;
    }

    // Add an open parenthesis if we haven't used all n
    if (open < n)
    {
        GenerateParentheses(n, current + "(", open + 1, close);
    }

    // Add a close parenthesis if we haven't closed more than opened
    if (close < open)
    {
        GenerateParentheses(n, current + ")", open, close + 1);
    }
}

GenerateParentheses(3, "", 0, 0);


List<int> scores = [27, 45, 63, 42, 58, 76, 31, 25, 97, 98, 01, 24, 99, 12];
foreach (var score in scores)
{
    Console.WriteLine($"Score: {score}");
}
IEnumerable<int> highScore = 
    from s in scores
    where s >= 90
    select s;

var bestScore = highScore.ToList();
Console.WriteLine($"The best scores are {bestScore}");