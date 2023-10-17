

Date trainDate = new Date(15, 6, 1994);
int daysAdded = 500;
Console.WriteLine($"After adding {daysAdded} days to the {DateFunctions.SlashFormatted(trainDate)} date, ");
DateFunctions.AddDays(trainDate, daysAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(trainDate)}");

Console.WriteLine("\n");

int monthsAdded = 7;
Console.WriteLine($"After adding {monthsAdded} months to the {DateFunctions.SlashFormatted(trainDate)} date, ");
DateFunctions.AddMonths(trainDate, monthsAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(trainDate)}");

Console.WriteLine("\n");

int yearsAdded = 3;
Console.WriteLine($"After adding {yearsAdded} years to the {DateFunctions.SlashFormatted(trainDate)} date, ");
DateFunctions.AddYears(trainDate, yearsAdded);
Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(trainDate)}");

Console.WriteLine("\n" + DateFunctions.SlashFormatted(trainDate));

static class LeapYear
{
    public static bool CheckIfLeap(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) return true;
        return false;
    }
}

static class DateFunctions
{
    public static string SlashFormatted(Date date)
    {
        return $"{date.Day}/{date.Month}/{date.Year}";
    }
    public static Date AddYears(Date date, int yearsToAdd)
    {
        date.Year += yearsToAdd;
        return date;
    }

    public static Date AddMonths(Date date, int monthsToAdd)
    {
        int monthsSum = date.Month + monthsToAdd;
        int yearsToAdd = monthsSum / 12;
        int monthsLeft = monthsSum - 12 * yearsToAdd;
        date.Month = monthsLeft;
        date.Year += yearsToAdd;
        return date;
    }

    public static Date AddDays(Date date, int daysToAdd)
    {
        int currentMonth;
        if (daysToAdd <= 0 || date is null)
        {
            Console.WriteLine("Wrong arguments used. Returning input as output. ;(");
            return date;
        }
        currentMonth = date.Month - 1;
        Console.WriteLine(currentMonth);
        //int currentMonth = 2;
        if (date.Day + daysToAdd <= MonthsArray.Months[currentMonth].daysCount)
        {
            date.Day += daysToAdd;
        }
        else
        {
            int daysLeft = daysToAdd;
            daysLeft -= MonthsArray.Months[currentMonth].daysCount - date.Day + 1;
            date.Day = 1;
            currentMonth++;
            if (currentMonth > 11) { currentMonth = 0; }
            while (daysLeft > MonthsArray.Months[currentMonth].daysCount)
            {
                daysLeft = daysLeft - MonthsArray.Months[currentMonth].daysCount;
                currentMonth++;
                if (currentMonth > 11) { currentMonth = 0; }
            }
            date.Day += daysLeft;
            date.Month = currentMonth + 1;
            
        }
        return date;
    }
}

static class MonthsArray
{
    public static(string month, int daysCount)[] Months =
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
}

class Date
{
    public int Day;
    public int Month;
    public int Year;

    public Date(int day, int month, int year)
        {
            if ((day < 1 || day > MonthsArray.Months[month - 1].daysCount) ||
                (month < 1 || month > 12) ||
                (year < 1 || year > 2100)) {
                
            }
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
}