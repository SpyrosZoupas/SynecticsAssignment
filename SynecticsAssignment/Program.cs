Console.WriteLine("Please provide a specific year:");
string year = Console.ReadLine();

string targetYear = Console.ReadLine();
int intTargetYear;
while (!int.TryParse(targetYear, out intTargetYear))
{
    Console.WriteLine("Incorrect input provided; Please provide a specific year.");
    targetYear = Console.ReadLine();
}

String line;
try
{
    StreamReader sr = new StreamReader("C:\\Users\\spiro\\source\\repos\\SynecticsAssignment\\SynecticsAssignment\\DEV-data.txt");
    line = sr.ReadLine();
    while (line != null)
    {
        line = sr.ReadLine();
    }

    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
