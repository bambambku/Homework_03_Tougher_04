Console.WriteLine("Welcome to my new program created to help you operate on dates");
Console.WriteLine(@"    ____  ___  ____________                        
   / __ \/   |/_  __/ ____/                        
  / / / / /| | / / / __/                           
 / /_/ / ___ |/ / / /___                           
/_____/_/  |_/_/ /_____/                           
   / __ \_________  ________  ______________  _____
  / /_/ / ___/ __ \/ ___/ _ \/ ___/ ___/ __ \/ ___/
 / ____/ /  / /_/ / /__/  __(__  |__  ) /_/ / /    
/_/   /_/   \____/\___/\___/____/____/\____/_/      
                                                     (by Michal Obrycki)
                                                   ");
Console.WriteLine("Let's start with you inputting the date you want to operate on.");
bool exit = false;
while (!exit)
{
    Date newDate = ProgramInterface.InitialiseDate();
    Console.WriteLine($"The date we will process is {DateFunctions.StringFormatted(newDate)}.");
    ProgramInterface.ProcessDate(newDate);
    exit = ProgramInterface.IfProcessAnotherDate();
}

/* -------------------------------------------------------------------------------------------------------------------------------
 * DISCLAIMER:                                                                                                                    
 * -------------------------------------------------------------------------------------------------------------------------------
 * I am aware of the level of imperfection of this program.                                                                       
 * Nevertheless I have spent quite a time building this product.                                                                   
 * I must say I am extremely proud of taking into account the varying number of days per month and solving the leap year problem.
 * It is worth mentioning that I decided to seperate most functionality from the Date class due to a number of reasons: 
 * - I did not want to keep all the methods in a one sack,
 * - I did not want somebody new to the program to scroll through a long page in finding the right spot,
 * - I have just started learning C# and wanted to play around with abstract classes.
 * 
 * I hope all my effort will be appreciated ;D
 * Cheers
 * -------------------------------------------------------------------------------------------------------------------------------
 */