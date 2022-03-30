// See https://aka.ms/new-console-template for more information
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("Hello, World!\n");
    Console.WriteLine("1- Addition");
    Console.WriteLine("2- Substration");
    Console.WriteLine("3- Multiplication");
    Console.WriteLine("4- Division");
    Console.WriteLine("5- Exit");
    Console.WriteLine("\nSelect your options:");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: Addition(); break;
        case 2: Substration(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Addition()
{
    Console.Clear();
    Console.WriteLine("Hello, World!");

    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 + v2;
    Console.WriteLine($"\nAddition between this two values is -> {result}");
    Console.ReadKey();
    Menu();
}

static void Substration()
{
    Console.Clear();
    Console.WriteLine("Hello, World!");

    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 - v2;
    Console.WriteLine($"\nSubstration between this two values is -> {result}");
    Console.ReadKey();
    Menu();
}

static void Multiplication()
{
    Console.Clear();
    Console.WriteLine("Hello, World!");

    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float v2 = float.Parse(Console.ReadLine());

    float result = v1 * v2;
    Console.WriteLine($"\nMultiplication between this two values is -> {result}");
    Console.ReadKey();
    Menu();
}

static void Division()
{
    Console.Clear();
    Console.WriteLine("Hello, World!");

    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());

    float v2;
    do
    {
        Console.WriteLine("Second value (different to zero): ");
        v2 = float.Parse(Console.ReadLine());
    } while (v2 == 0);


    float result = v1 / v2;
    Console.WriteLine($"\nDivision between this two values is -> {result}");
    Console.ReadKey();
    Menu();
}