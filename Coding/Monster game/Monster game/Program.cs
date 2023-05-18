using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static int playerHealth = 100;
        static int monsterDamage = 30;

        static void Start()
        {
            Console.WriteLine("My Game Has Begun!");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttacks(monsterDamage * 2);
            MonsterAttacks(monsterDamage);
            MonsterAttacks(monsterDamage * 3);



        }
        static void MonsterEncounter()
        {
            Console.WriteLine("A vicious Monster Appears");
            Console.ReadKey();
        }
        static void MonsterAttacks(int damage)
        {
            playerHealth -= damage;
            Console.WriteLine("The monster attacks you for " + damage + " points of damage! you have " + playerHealth + " HP left.");
            Console.ReadKey();
        }
        static void Main()
        {
            Start();

        }
    }
}
