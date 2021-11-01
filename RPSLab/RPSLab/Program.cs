using System;

namespace RPSLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Rocky r = new Rocky();
            //Console.WriteLine(r.GetRPS());

            //UserPlayer p = new UserPlayer();

            //RPSEnum result = p.GetRPS();

            //Console.WriteLine(result);

            while (true)
            {
                RPSApp rps = new RPSApp();
                rps.Play();

                Console.WriteLine("Would you like to continue playing? y/n");
                string userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "y" || userAnswer == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
    }
}
