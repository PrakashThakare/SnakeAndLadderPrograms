using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class CheckPosition
    {
        public void CheckPositioNofPlayer()
        {
            Console.WriteLine("Enter Player name");
            string iPlayer1 = Convert.ToString(Console.ReadLine());

            int iPosition = 0;
            while (iPosition <= 100)
            {
                Random random = new Random();
                Console.ReadLine();

                int iDice = random.Next(1, 7);
                iPosition += iDice;
                Console.WriteLine("Dice Rolled :{0} \nPosition is {1}", +iDice, iPosition);


                if ((iPosition == 99) || (iPosition == 95) || (iPosition == 87) || (iPosition == 65)) // Snake
                {
                    iPosition -= 17;
                    Console.WriteLine("You Got Sneke new Position is {0}", iPosition);
                }
                else if ((iPosition == 62) || (iPosition == 54) || (iPosition == 17))   // Snake
                {
                    iPosition -= 9;
                    Console.WriteLine("You Got Sneke new Position is {0}", iPosition);
                }
                else if ((iPosition == 4) || (iPosition == 9) || (iPosition == 51) || (iPosition == 40) || (iPosition == 63) || (iPosition == 51))// Ladder
                {
                    iPosition += 13;        
                    Console.WriteLine("You Got Ladder new Position is {0}", iPosition);
                }
                else if (iPosition == 24) // Ladder
                {
                    iPosition += 48;
                    Console.WriteLine("You Got Ladder new Position is {0}", iPosition);
                }

            }

        }
    }
}

