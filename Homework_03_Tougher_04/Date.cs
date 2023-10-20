//the Date class istelf with constructor autocorrecting the dates out of range
class Date
{
    public int Day;
    public int Month;
    public int Year;

    public Date(int day, int month, int year)
    {
        int[] dateArray = { day, month, year };
        string[] datePartsNames = { "day", "month", "year" };
        (bool b, int lowerOrHigher, int index)[] safetyClauses = { (false, 0, 0), (false, 0, 1), (false, 0, 2) };

        if (month > 12)
        {
            month = 12;
            safetyClauses[1].b = true;
            safetyClauses[1].lowerOrHigher = 1;
        }
        int[] dateMaxValues = { MonthsArray.Months[month - 1].daysCount, 12, 3000 };
        
        for (int i = 0; i < 3; i++) 
        {
            if (dateArray[i] < 1)
            {
                dateArray[i] = 1;
                safetyClauses[i].b = true;
                safetyClauses[i].lowerOrHigher = 0;
            }
            if (dateArray[i] > dateMaxValues[i])
            {
                dateArray[i] = dateMaxValues[i];
                safetyClauses[i].b = true;
                safetyClauses[i].lowerOrHigher = 1;
            }
        }
        this.Day = dateArray[0];
        this.Month = dateArray[1];
        this.Year = dateArray[2];
        bool dateIncorrect = false;
        foreach ((bool b, int lowerOrHigher, int index) safetyClause in safetyClauses) 
        { 
            if (safetyClause.b == true)
            {
                dateIncorrect = true;
                switch (safetyClause.lowerOrHigher) {
                    case 0:
                    Console.WriteLine($"!!! The {datePartsNames[safetyClause.index]} cannot be less than 1, set to: 1 !!!");
                        break;
                    case 1:
                        Console.WriteLine($"!!! The {datePartsNames[safetyClause.index]}'s value too high, set to: {dateArray[safetyClause.index]} !!!");
                        break;
                } 
            }
        }
        if (dateIncorrect)
        {
            Console.WriteLine($"\nThe date has been autocorrected to {DateFunctions.SlashFormatted(this)}");
        }
        
    }
}

