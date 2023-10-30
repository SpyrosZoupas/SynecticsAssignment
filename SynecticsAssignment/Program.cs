﻿Console.WriteLine("Please provide a specific year:");

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
    Console.WriteLine(e.Message);
}

static double CalculateStandardDeviation(List<double> data)
{
    double average = data.Average();
    return Math.Sqrt(data.Average(v => Math.Pow(v - average, 2)) / data.Count);
}
