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
    ProgramInterface.ProcessDate(newDate);
    exit = ProgramInterface.IfProcessAnotherDate();
}
