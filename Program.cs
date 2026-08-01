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
            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine()!;
            Console.Write("Enter duration in minutes: ");
            string duration = Console.ReadLine()!;
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("dd/MM/yyyy");
            string logEntry = $"{date} | {subject} | {duration} minutes";
            File.AppendAllText("study_log.txt", logEntry + Environment.NewLine);
            Console.WriteLine("Session Logged");
            break;
        case "2":
            if(File.Exists("study_log.txt"))
            {
                string[] lines = File.ReadAllLines("study_log.txt");
                foreach(var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No sessions logged yet");
            }
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
