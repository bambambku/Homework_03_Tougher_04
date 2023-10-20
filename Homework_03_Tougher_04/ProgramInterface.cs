using System.Text.RegularExpressions;

// Program interface functionalities: date input, date processing, and starting again.
static class ProgramInterface
{
    
    public static Date InitialiseDate()
    {
        Console.WriteLine("\nPlease enter the date in DD/MM/YYYY format:");
        bool dateOK = false;
        int[] newDateIntArray = new int[3];
        while (!dateOK)
        {
            string newDateString = Console.ReadLine();
            
            //Checking if input date is in DD/MM/YYYY format.
            Match dateIfCorrect = Regex.Match(newDateString, "^\\d{2}\\/\\d{2}\\/\\d{4}$");
            if (!dateIfCorrect.Success)
            {
                Console.WriteLine("Wrong date format. Please try again.");
                continue;
            }

            Console.WriteLine();
            
            //Splitting the input string into an Array
            string[] newDateStringArray = newDateString.Split('/');
            for (int i = 0; i < 3; i++)
            {
                newDateIntArray[i] = Int32.Parse(newDateStringArray[i]);
            }
            dateOK = true;
        }
        return new Date(newDateIntArray[0], newDateIntArray[1], newDateIntArray[2]);
    }

    // Processing the date input accoriding to a chosen option and creating output.
    public static void ProcessDate(Date date)
    {
        Console.WriteLine(@"
        Choose option:
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

        Console.WriteLine($"the new date is: {DateFunctions.StringFormatted(date)}, ({DateFunctions.SlashFormatted(date)}).");
    }

    // Anabling option to start the program again from the date input.
    public static bool IfProcessAnotherDate()
    {
        Console.WriteLine(@"
        To process another date
        type in Y and press [eneter],
        any other option will close the program
         ");
        string option = Console.ReadLine();
        option = option.ToUpper();
        return option != "Y";
    }
}