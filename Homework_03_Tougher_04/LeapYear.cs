







static class LeapYear
{
    public static bool CheckIfLeap(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) return true;
        return false;
    }

    public static void FebruaryUpdate(int year)
    {
        MonthsArray.Months[1].daysCount = CheckIfLeap(year) ?  29 : 28;
    }
}
