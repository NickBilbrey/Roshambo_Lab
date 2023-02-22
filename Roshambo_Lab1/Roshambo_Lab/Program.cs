


using Roshambo_Lab;

bool userContinue = false;
string userAnswerToLower = "";


    Console.WriteLine("Welcome to Roshambo!!");
    Console.Write("Please enter your name: ");
   string playerName = Console.ReadLine();

do
{
    bool validOpponent = false;
    do
    {

    
        Console.Write("Please pick an opponent \"The Rock\" or \"Random Guy\": ");
        string opponent = Console.ReadLine();

     if (opponent == "The Rock")
     {
            string result = "";
         do
         {
            Console.Write("Rock, Paper, or Scissors (R/P/S) : ");
            string playerChoice = Console.ReadLine();
            string playerChoiceToLower = playerChoice.ToLower();

            TheRock playerResult = new TheRock();
            result = playerResult.RoshamboMaker(playerName, playerChoiceToLower);

            Console.WriteLine(result);

            
            string whoWins = playerResult.Showtime(playerChoiceToLower);

            Console.WriteLine(whoWins);


        } while (result == "Please make a valid entry");

            validOpponent = false;

        
     }
     else if (opponent == "Random Guy")
     {
        string result = "";
        do
        {
            Console.Write("Rock, Paper, or Scissors (R/P/S) : ");
            string playerChoice = Console.ReadLine();
            string playerChoiceToLower = playerChoice.ToLower();

            RandomGuy randomResult = new RandomGuy();
            result = randomResult.RoshamboMaker(playerName, playerChoiceToLower);

            Console.WriteLine(result);

           
            randomResult.RandomStuff(playerChoiceToLower);
            
            


        } while (result == "Please make a valid entry");

            validOpponent = false;
     }
     else
     {
            Console.WriteLine("Please pick a valid opponent");
            validOpponent= true;

     }

    } while (validOpponent == true);



    bool validAnswer = false;
	do
	{
        Console.WriteLine("Play again? y/n");

        try
        {
            string userAnswer = Console.ReadLine();
            userAnswerToLower = userAnswer.ToLower();
            validAnswer = false;
        }
        catch (Exception)
        {

            Console.WriteLine("Please enter a valid input"); 
            validAnswer = true;
        }

    } while (validAnswer == true);

    if (userAnswerToLower == "y")
    {
        userContinue = true;
    }
    else if (userAnswerToLower != "y")
    {
        userContinue= false;
    }


} while (userContinue == true);