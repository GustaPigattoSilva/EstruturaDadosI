using System.Globalization;

string [] months = new string[12];

Console.WriteLine("Segue os Meses do Ano");


for (int month = 1; month <=12; month++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
    string name = firstDay.ToString("MMMMMMMM", CultureInfo.CreateSpecificCulture("pt-br"));
    months[month - 1] = name;
}

foreach (string month in months)

{
    Console.WriteLine($"-> {month}");
}
