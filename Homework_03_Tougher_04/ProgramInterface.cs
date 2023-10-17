static class ProgramInterface
{
    
    public static Date InitialiseDate()
    {
        Console.WriteLine("\nPlease enter the date in DD/MM/YYYY format:");
        string newDateString = Console.ReadLine();
        Console.WriteLine();
        string[] newDateStringArray = newDateString.Split('/');
        int[] newDateIntArray = new int[3];
        for (int i = 0; i < 3; i++)
        {
            newDateIntArray[i] = Int32.Parse(newDateStringArray[i]);
        }
        return new Date(newDateIntArray[0], newDateIntArray[1], newDateIntArray[2]);
    }

    public static void ProcessDate(Date date)
    {
        Console.WriteLine(@"Choose option:
        [1] Add a number of DAYS to chosen date.
        [2] Add a number of MONTHS to chosen date.
        [3] Add a number of YEARS to chosen date.
         ");

        int chosenOption = Int32.Parse(Console.ReadLine());
        string[] options = { "days", "months", "years" };
        string whatToChange = options[chosenOption - 1];
        Console.WriteLine($"\nPlease eneter the number of {whatToChange} you want to add to your chosen date {DateFunctions.SlashFormatted(date)}:");
        int intToAdd = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"\nAfter adding {intToAdd} {whatToChange} to the {DateFunctions.SlashFormatted(date)} date, ");
        switch (chosenOption)
        {
            case 1:
                DateFunctions.AddDays(date, intToAdd);
                break;
            case 2:
                DateFunctions.AddMonths(date, intToAdd);
                break;
            case 3:
                DateFunctions.AddYears(date, intToAdd);
                break;
        }

        Console.WriteLine($"the new date is: {DateFunctions.SlashFormatted(date)}");
    }

    public static bool IfProcessAnotherDate()
    {
        Console.WriteLine(@"
        To process another date
        type in Y and press [eneter],
        any other option will close the program
         ");
        string option = Console.ReadLine();
        return option == "Y" ? false : true;

    }
}