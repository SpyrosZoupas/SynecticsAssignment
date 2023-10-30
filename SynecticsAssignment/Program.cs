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
