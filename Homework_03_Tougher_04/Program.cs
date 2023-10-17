Console.WriteLine("Welcome to my new program created to help you operate on dates");
Console.WriteLine("Let's start with you inputting the date you want to operate on.");

Console.WriteLine("Please enter the date in DD/MM/YYYY format:");
string newDateString = Console.ReadLine();
Console.WriteLine();
string[] newDateStringArray = newDateString.Split('/');
int[] newDateIntArray = new int[3];
for (int i = 0; i < 3; i++)
{
    newDateIntArray[i] = Int32.Parse(newDateStringArray[i]);
}
Date newDate = new Date(newDateIntArray[0], newDateIntArray[1], newDateIntArray[2]);

Console.WriteLine(@"Choose option:
[1] Add a number of DAYS to chosen date.
[2] Add a number of MONTHS to chosen date.
[3] Add a number of YEARS to chosen date.
[4] Check ");

int daysAdded = 11500;
Console.WriteLine($"After adding {daysAdded} days to the {DateFunctions.SlashFormatted(newDate)} date, ");
DateFunctions.AddDays(newDate, daysAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(newDate)}");

Console.WriteLine("\n");

int monthsAdded = 7;
Console.WriteLine($"After adding {monthsAdded} months to the {DateFunctions.SlashFormatted(newDate)} date, ");
DateFunctions.AddMonths(newDate, monthsAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(newDate)}");

Console.WriteLine("\n");

int yearsAdded = 3;
Console.WriteLine($"After adding {yearsAdded} years to the {DateFunctions.SlashFormatted(newDate)} date, ");
DateFunctions.AddYears(newDate, yearsAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(newDate)}");

Console.WriteLine("\n" + DateFunctions.SlashFormatted(newDate));

int testYear = 1996;
Console.WriteLine($"{testYear} is a leap year = {LeapYear.CheckIfLeap(testYear)}");

class ProgramInterface
{

}