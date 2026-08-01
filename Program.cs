Dictionary<string, double> atomicWeights = new Dictionary<string, double>
{
    {"H", 1.008}, {"C", 12.011}, {"N", 14.007}, {"O", 15.999},
    {"Na", 22.990}, {"Cl", 35.45}, {"P", 30.974}, {"S", 32.06},
    {"K", 39.098}, {"Ca", 40.078}, {"Mg", 24.305}, {"Fe", 55.845}
};

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
            if (File.Exists("study_log.txt"))
            {
                string[] lines = File.ReadAllLines("study_log.txt");
                foreach (var line in lines)
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
            Console.Write("Enter chemical formula (e.g. H2O, NaCl, C6H12O6): ");
            string formula = Console.ReadLine()!;

            double total = 0;
            int i = 0;
            bool validFormula = true;

            while (i < formula.Length)
            {
                string symbol = formula[i].ToString();
                i++;

                if (i < formula.Length && char.IsLower(formula[i]))
                {
                    symbol += formula[i];
                    i++;
                }

                string numberString = "";
                while (i < formula.Length && char.IsDigit(formula[i]))
                {
                    numberString += formula[i];
                    i++;
                }

                int count = numberString == "" ? 1 : int.Parse(numberString);

                if (atomicWeights.ContainsKey(symbol))
                {
                    total += atomicWeights[symbol] * count;
                }
                else
                {
                    Console.WriteLine($"Unknown element: {symbol}");
                    validFormula = false;
                    break;
                }
            }

            if (validFormula)
            {
                Console.WriteLine($"Molecular weight of {formula}: {total:F3} g/mol");
            }
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
