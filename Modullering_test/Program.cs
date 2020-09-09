using System;

namespace Modullering_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 100;
            int playerMp = 125;
            int playerSp = 150;

            int enemyStrenght = 20;
            int enemyHp = 50;

            Player player = new Player(playerHp, playerMp, playerSp);

            Console.WriteLine("Player HP is " + player.hp + "\n");
            Console.WriteLine("Player MP is " + player.mp + "\n");
            Console.WriteLine("Player SP is " + player.sp + "\n");

            Console.ReadLine();
        }

        void PlayerInfo()
        {
            
        }
    }
}
