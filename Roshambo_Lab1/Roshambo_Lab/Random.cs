using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
    class RandomGuy: Player
    {
        public void RandomStuff(string playerChoice)
        {
            Random randomChoice = new Random();
            int randomGuyChoice = randomChoice.Next(1, 4);

            switch (randomGuyChoice)
            {
                case 1:
                    if (playerChoice == "r")
                    {
                     
                        Console.WriteLine("RandomGuy: Rock");
                        Console.WriteLine("It's a tie!");
                    }

                    else if (playerChoice == "p")
                    {
                      
                        Console.WriteLine("RandomGuy: Rock");
                        Console.WriteLine($"{UserName} wins");
                        
                    }
                    else if (playerChoice == "s")
                    {
                       
                        Console.WriteLine("RandomGuy: Rock");
                        Console.WriteLine("RandomGuy wins :( ");
                        
                    }
                    break;
                case 2:
                    if (playerChoice == "r")
                    {
                      
                        Console.WriteLine("RandomGuy: paper");
                        Console.WriteLine($"Random Guy wins");
                    }

                    else if (playerChoice == "p")
                    {
                     
                        Console.WriteLine("RandomGuy: paper");
                        Console.WriteLine($"It's a tie!");
                       
                    }
                    else if (playerChoice == "s")
                    {
                      
                        Console.WriteLine("RandomGuy: paper");
                        Console.WriteLine($"{UserName} wins :( ");
                      
                    }
                    break;
                case 3:
                    if (playerChoice == "r")
                    {
                      
                        Console.WriteLine("RandomGuy: Scissors");
                        Console.WriteLine($"{UserName} wins.");
                      
                    }

                    else if (playerChoice == "p")
                    {
                    
                        Console.WriteLine("RandomGuy: Scissors");
                        Console.WriteLine("RandomGuy wins");
                       
                    }
                    else if (playerChoice == "s")
                    {
                     
                        Console.WriteLine("Randomguy: Scissors");
                        Console.WriteLine("It's a tie!");
                    }
                    break;
            }

        }
    }
}
