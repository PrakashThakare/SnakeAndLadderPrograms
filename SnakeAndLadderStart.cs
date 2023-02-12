using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public  class SnakeAndLadderStar
    {
        public void PlayerRolled()
        {
            Console.WriteLine("Enter Player name");
            string sPlayer1 = Convert.ToString(Console.ReadLine());

            Random random = new Random();
            int iDice = random.Next(1, 7);
            Console.WriteLine("Dice Number Is :{0}", iDice);

        }
    }
}
