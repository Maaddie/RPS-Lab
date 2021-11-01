using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }

        public override RPSEnum GetRPS()
        {
            //getting the random number using the Random method.
            Random random = new Random();
            //returning random number up to 3 but not including 3
            int randomNumber = random.Next(3);

            if(randomNumber == 0)
            {
                return RPSEnum.Rock;
            }
            else if(randomNumber == 1)
            {
                return RPSEnum.Paper;
            }
            else if(randomNumber == 2)
            {
                return RPSEnum.Scissors;
            }
            else
            {
                Console.WriteLine("Sorry. I don't understand that. Please try again");
                return GetRPS();
                
            }
        }
    }
}
