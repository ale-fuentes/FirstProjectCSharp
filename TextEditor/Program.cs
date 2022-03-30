// See https://aka.ms/new-console-template for more information
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Hello, World!\nYour options:");
    Console.WriteLine("1- Open file");
    Console.WriteLine("2- Crate new file");
    Console.WriteLine("3- Exit");
    Console.WriteLine("\nSelect your options:");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: Open(); break;
        case 2: Edit(); break;
        case 3: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Open()
{
    Console.Clear();
    Console.WriteLine("Digit please the path and name to file: ");
    var path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.Write(text);
    }

    Console.WriteLine("\n >> File reading with success!");
    Console.ReadKey();
    Menu();
}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Digit please the name to file (ESC for exit): ");
    String text = String.Empty;

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);


}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("What name of file? :");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    Console.WriteLine("\n >> File save with success!");
    Console.ReadKey();
    Menu();

}