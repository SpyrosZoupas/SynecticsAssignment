Console.WriteLine("Please provide a specific year:");

string targetYear = Console.ReadLine();
int intTargetYear;
while (!int.TryParse(targetYear, out intTargetYear))
{
    Console.WriteLine("Incorrect input provided; Please provide a specific year.");
    targetYear = Console.ReadLine();
}

String line;
List<double> incomeList = new List<double>();
try
{
    StreamReader sr = new StreamReader("C:\\Users\\spiro\\source\\repos\\SynecticsAssignment\\SynecticsAssignment\\DEV-data.txt");
    line = sr.ReadLine();
    while (line != null)
    {
        string[] parts = line.Split("##");
        string[] dateParts = parts[0].Split('/');
        int year = int.Parse(dateParts[2]);
        if (year == intTargetYear)
        {
            int income = int.Parse(parts[1]);
            incomeList.Add(income);
        }
        line = sr.ReadLine();
    }

    sr.Close();

    double standardDeviation = CalculateStandardDeviation(incomeList);
    Console.WriteLine(standardDeviation);

    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("No data found for year provided.");
}

static double CalculateStandardDeviation(List<double> data)
{
    double standardDeviation = Math.Sqrt(CalculateVariance(data));
    return Math.Round(standardDeviation, 2);
}

static double CalculateVariance(List<double> data)
{
    double average = data.Average();
    double variance = data.Average(d => Math.Pow(d - average, 2));
    return variance;
}
