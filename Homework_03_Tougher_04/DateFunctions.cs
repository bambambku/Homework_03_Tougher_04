
static class DateFunctions
{
    //Two ways of formatting the date for an output.
    public static string StringFormatted(Date date)
    {
        return $"{date.Day} {MonthsArray.Months[date.Month - 1].month} {date.Year}";

    }
    public static string SlashFormatted(Date date)
    {
        return $"{date.Day}/{date.Month}/{date.Year}";
    }
    public static Date AddYears(Date date, int yearsToAdd)
    {
        date.Year += yearsToAdd;
        return date;
    }

    //Adding days, months or years to a date
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
        void yearUpdater()
        {
            if (currentMonth > 11)
            {
                currentMonth = 0;
                date.Year++;
                LeapYear.FebruaryUpdate(date.Year);
            }
        }
        if (daysToAdd <= 0 || date is null)
        {
            Console.WriteLine("Wrong arguments used. Returning input as output. ;(");
            return date;
        }
        currentMonth = date.Month - 1;
        LeapYear.FebruaryUpdate(date.Year);
        if (date.Day + daysToAdd <= MonthsArray.Months[currentMonth].daysCount)
        {
            date.Day += daysToAdd;
            MonthsArray.ResetFebruary();
        }
        else
        {
            int daysLeft = daysToAdd;
            daysLeft -= MonthsArray.Months[currentMonth].daysCount - date.Day + 1;
            date.Day = 1;
            currentMonth++;
            yearUpdater();
            
            while (daysLeft > MonthsArray.Months[currentMonth].daysCount)
            {
                daysLeft -= MonthsArray.Months[currentMonth].daysCount;
                currentMonth++;
                yearUpdater() ;
            }
            date.Day += daysLeft;
            date.Month = currentMonth + 1;
            
        }
        MonthsArray.ResetFebruary();
        return date;
    }
}
