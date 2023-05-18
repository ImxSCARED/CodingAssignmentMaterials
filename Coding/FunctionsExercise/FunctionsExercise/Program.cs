using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FunctionsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game MyGame = new Game();
            MyGame.score = 100;
            MyGame.start();

        }
    }
    internal class Game

    {
        public int score = 0;


        public void start()
        {

            Console.WriteLine("your score is " +score);
            AddToScore(score);
            PrintScore(20);

      
          Console.ReadKey();
        }
        
        public int AddToScore(int addScore)
        {
            addScore = 20;
            score += addScore;
            return score;
            
        }
        public void PrintScore(int addPrintScore)
        {
            Console.WriteLine("your score is " + score);
            Console.ReadKey();
            Console.WriteLine("you Scored! your score is currently " + AddToScore(addPrintScore));
            Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine("you Scored! your score is currently " + AddToScore(addPrintScore));
            Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine("you Scored! your score is currently " + AddToScore(addPrintScore));
            Console.ReadKey();


            //holy duck this is annoying
        }
    }
        
}
 
    

