while (true)
{
    Console.WriteLine("===Biochemistry Study Console===");
    Console.WriteLine("1. Log Study Session");
    Console.WriteLine("2. View Study Log");
    Console.WriteLine("3. Molecular Weight Calculator");
    Console.WriteLine("4. Biochemistry Quiz");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.WriteLine("Log Study Session - TODO");
            break;
        case "2":
            Console.WriteLine("View Study Log - TODO");
            break;
        case "3":
            Console.WriteLine("Molecular Weight Calculator - TODO");
            break;
        case "4":
            Console.WriteLine("Biochemistry Quiz - TODO");
            break;
        case "5":
            Console.WriteLine("Goodbye");
            return;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
    Console.WriteLine();
}
