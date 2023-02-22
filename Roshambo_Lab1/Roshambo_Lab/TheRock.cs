using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
    class TheRock: Player
    {
        public string Showtime(string playerChoice)
        {
            if (playerChoice == "r")
            {
                return $"The Rock: Rock \n It's a tie!";

            }
            else if (playerChoice == "p")
            {
                return $"The Rock: Rock \n {UserName} wins!";

            }
            else if (playerChoice == "s")
            {
                return $"The Rock: Rock \n The Rock wins :( ";

            }
            else
            {
                return "Please make a valid entry";
            }
        
        }
    }
}
