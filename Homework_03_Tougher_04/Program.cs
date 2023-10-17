

using System.Runtime.InteropServices;


var months = new (string month, int daysCount)[]
{
    ("January", 31),
    ("February", 28),
    ("March", 31),
    ("April", 30),
    ("May", 31),
    ("June", 30),
    ("July", 31),
    ("August", 31),
    ("September", 30),
    ("October", 31),
    ("November", 30),
    ("December", 31)
};

Date trainDate = new Date(15, 6, 1994);
int daysAdded = 100;
Console.WriteLine($"After adding {daysAdded} days to the {SlashFormatted(trainDate)} date, ");
AddDays(trainDate, daysAdded);
Console.WriteLine($"the new date is: {SlashFormatted(trainDate)}");

Console.WriteLine("\n");

int monthsAdded = 2;
Console.WriteLine($"After adding {monthsAdded} months to the {SlashFormatted(trainDate)} date, ");
AddMonths(trainDate, monthsAdded);
Console.WriteLine($"the new date is: {SlashFormatted(trainDate)}");

Console.WriteLine("\n");

int yearsAdded = 3;
Console.WriteLine($"After adding {yearsAdded} years to the {SlashFormatted(trainDate)} date, ");
AddYears(trainDate, yearsAdded);
Console.WriteLine($"the new date is: {SlashFormatted(trainDate)}");

Console.WriteLine("\n" + SlashFormatted(trainDate));

//Console.WriteLine("\n" + NicelyFormatted(trainDate));

//string NicelyFormatted(Date date)
//{
//    string[] endings = { "st", "nd", "rd", "th" };
//    
//}
static class DateFunctions
{
    static string SlashFormatted(Date date)
    {
        return $"{date.Day}/{date.Month}/{date.Year}";
    }
    static Date AddYears(Date date, int yearsToAdd)
    {
        date.Year += yearsToAdd;
        return date;
    }

    static Date AddMonths(Date date, int monthsToAdd)
    {
        date.Month += monthsToAdd;
        return date;
    }

    static Date AddDays(Date date, int daysToAdd)
    {
        if (daysToAdd <= 0 || date is null)
        {
            Console.WriteLine("Wrong arguments used. Please try again ;(");
        }
        int currentMonth = date.Month - 1;
        if (date.Day + daysToAdd <= months[currentMonth].daysCount)
        {
            date.Day += daysToAdd;
        }
        else
        {
            int daysLeft = daysToAdd;
            daysLeft -= months[currentMonth].daysCount - date.Day + 1;
            date.Day = 1;
            currentMonth++;
            while (daysLeft > months[currentMonth].daysCount)
            {
                daysLeft = daysLeft - months[currentMonth].daysCount;
                currentMonth++;
            }
            date.Day += daysLeft;
            date.Month = currentMonth + 1;
        }
        return date;
    }
}
class Date
{
    public int Day;
    public int Month;
    public int Year;
    public (string month, int daysCount)[] Months =
    {
    ("January", 31),
    ("February", 28),
    ("March", 31),
    ("April", 30),
    ("May", 31),
    ("June", 30),
    ("July", 31),
    ("August", 31),
    ("September", 30),
    ("October", 31),
    ("November", 30),
    ("December", 31)
};


    public Date(int day, int month, int year)
        {
            if ((day < 1 || day > Months[month - 1].daysCount) ||
                (month < 1 || month > 12) ||
                (year < 1 || year > 2100)) {
                Console.WriteLine("Input date is not correct.");
            }
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
}