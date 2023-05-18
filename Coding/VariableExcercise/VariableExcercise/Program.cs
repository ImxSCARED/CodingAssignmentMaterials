using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableExcercise
{
    internal class Program
    {
        static void Main()
        {
            float playerHealth = 0;
            bool inCombat = false;
            float monsterHealth = 100.0f;

            playerHealth = 100.0f;
            monsterHealth = 50.0f;
           


            string battleStartText = "battle Start";
            string playerHealthText = "PlayerHP: " + playerHealth + ".";
            string monsterHealthText = "MonsterHP: " + monsterHealth + ".";


            inCombat = true;

            
            Console.WriteLine(battleStartText);
            Console.WriteLine(playerHealthText);    
            Console.WriteLine(monsterHealthText);


            Console.ReadKey();
        }
    }
}
