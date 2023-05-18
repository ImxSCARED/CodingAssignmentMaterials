using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    internal class Program
    {
        static void Main()
        {
            string greeting = "Hello, User! The game's start condition is; ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);


            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);


           
            string gameComplete = "well Done user.. You bet The Game ";
          
            string Challenge = "the challenge is to complete the variable tutorial ";
            string challengeState = gameComplete + Challenge;
            Console.WriteLine(challengeState); 
           


            Console.ReadKey();

        }
    }
}
