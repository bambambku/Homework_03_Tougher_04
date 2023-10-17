







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