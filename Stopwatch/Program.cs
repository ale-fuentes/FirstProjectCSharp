// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("Hello, World!\n");
    Console.WriteLine("Second => 10s then 10 second");
    Console.WriteLine("Minute => 1m = 1 minute");
    Console.WriteLine("Exit => 0e");

    string data = string.Empty;

    do
    {
        Console.WriteLine("\nWhat time of time you want count:");
        data = Console.ReadLine().ToLower();
    } while (data.Length < 2);

    char typeUnit = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (typeUnit == 'm') multiplier = 60;
    if (typeUnit == 'e') System.Environment.Exit(0);

    PreStart(time * multiplier);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(1000);

    Start(time);

}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.WriteLine("\nStopWatch finish");
    Console.ReadKey();
    Menu();
}