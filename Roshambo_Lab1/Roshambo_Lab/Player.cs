using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Lab
{
      abstract class Player
    {
        public string UserName { get; set; }
        public string UserChoice { get; set; }

        public enum MyRoshamboEnum
        {
            Rock,
            Paper,
            Scissors
        }

        public string RoshamboMaker(string userName, string userChoice)
        {
            UserName = userName;


            if (userChoice == "r")
            {
                UserChoice = "Rock";
            }
            else if (userChoice == "p")
            {
                UserChoice = "Paper";
            }
            else if (userChoice == "s")
            {
                UserChoice = "Scissors";
            }
            else
            {
                return "Please make a valid entry";
            }

            return UserName + ": " + UserChoice;
        }
    }

}
