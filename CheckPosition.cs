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
            int iPosition1 = 0, iPosition2 = 0, iDice1 = 0, iDice2 = 0;


            Console.WriteLine("Enter 1st Player name");
            string sPlayer1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter 2nd Player name");
            string sPlayer2 = Convert.ToString(Console.ReadLine());


            while ((iPosition1 <= 100) || (iPosition2 <= 100))
            {
                for (int iChange = 1; iChange <= 2; iChange++)
                {
                    Random random2 = new Random();

                    switch (iChange)
                    {
                        case 1:

                            iDice1 = random2.Next(1, 7);
                            Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}",sPlayer1, iDice1);

                            iPosition1 += iDice1;
                            Console.WriteLine("Position is : {0}\n", +iPosition1);

                            if (iPosition1 > 100)
                            {
                                iPosition1 = iPosition1 - iDice1;
                                Console.WriteLine("Not Valid your position is same : {0}\n", iPosition1);
                                break;

                            }
                            else if ((iPosition1 == 99) || (iPosition1 == 95) || (iPosition1 == 87) || (iPosition1 == 65)) // Snake
                            {
                                iPosition1 -= 17;
                                Console.WriteLine("You Got Sneke : {0} new position is : {1}\n", sPlayer1, iPosition1);
                            }
                            else if ((iPosition1 == 62) || (iPosition1 == 54) || (iPosition1 == 17))   // Snake
                            {
                                iPosition1 -= 9;
                                Console.WriteLine("You Got Sneke : {0} new positin is : {1}\n", sPlayer1, iPosition1);
                            }

                            else if ((iPosition1 == 4) || (iPosition1 == 9) || (iPosition1 == 51) || (iPosition1 == 40) || (iPosition1 == 63) || (iPosition1 == 51))// Ladder
                            {
                                iPosition1 += 13;
                                Console.WriteLine("You Got Ladder : {1} new position is : {0}\n", iPosition1, sPlayer1);

                                Console.WriteLine("Play Again\n");

                                iDice1 = random2.Next(1, 7);
                                Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}", sPlayer1, iDice1);

                                iPosition1 += iDice1;
                                Console.WriteLine("Position is : {0}\n", +iPosition1);

                            }
                            else if (iPosition1 == 24) // Ladder
                            {
                                iPosition1 += 48;
                                Console.WriteLine("You Got Ladder : {1} new position is : {0}\n", iPosition1, sPlayer1);

                                Console.WriteLine("Play Again\n");

                                iDice1 = random2.Next(1, 7);
                                Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}", sPlayer1, iDice1);

                                iPosition1 += iDice1;
                                Console.WriteLine("Position is : {0}\n", +iPosition1);

                            }
                            else if (iPosition1 <= 0)
                            {
                                iPosition1 = 0;   // reset

                            }
                            else if (iPosition1 == 100)
                            {
                                Console.WriteLine("********* Congratulation {0} You are Winner *********** ", sPlayer1);
                                return;
                            }

                            break;

                        case 2:

                            iDice2 = random2.Next(1, 7);
                            Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}",sPlayer2, iDice2);

                            iPosition2 += iDice2;
                            Console.WriteLine("Position is : {0}\n", iPosition2);

                            if (iPosition2 > 100)
                            {
                                iPosition2 = iPosition2 - iDice2;
                                Console.WriteLine("Not Valid  your position remain same : {0}\n", iPosition2);
                                break;

                            }
                            else if ((iPosition2 == 99) || (iPosition2 == 95) || (iPosition2 == 87) || (iPosition2 == 65)) // Snake
                            {
                                iPosition2 -= 17;
                                Console.WriteLine("You Got Sneke : {1} new position is : {0}\n", iPosition2, sPlayer2);
                            }
                            else if ((iPosition2 == 62) || (iPosition2 == 54) || (iPosition2 == 17))   // Snake
                            {
                                iPosition2 -= 9;
                                Console.WriteLine("You Got Sneke : {1} new position is : {0}\n", iPosition2, sPlayer2);
                            }
                            else if ((iPosition2 == 4) || (iPosition2 == 9) || (iPosition2 == 51) || (iPosition2 == 40) || (iPosition2 == 63) || (iPosition2 == 51))// Ladder
                            {
                                iPosition2 += 13;
                                Console.WriteLine("You Got Ladder : {1} new position is : {0}\n", iPosition2, sPlayer2);

                                Console.WriteLine("Play Again\n");

                                iDice2 = random2.Next(1, 7);
                                Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}", sPlayer2, iDice2);

                                iPosition2 += iDice2;
                                Console.WriteLine("Position is : {0}\n", iPosition2);
                            }
                            else if (iPosition2 == 24) // Ladder
                            {
                                iPosition2 += 48;
                                Console.WriteLine("You Got Ladder : {1} new Position is : {0}\n", iPosition2, sPlayer2);

                                Console.WriteLine("Play Again\n");

                                iDice2 = random2.Next(1, 7);
                                Console.WriteLine("Dice Rolled by : {0}\nNumber is : {1}", sPlayer2, iDice2);

                                iPosition2 += iDice2;
                                Console.WriteLine("Position is : {0}\n", iPosition2);
                            }
                            else if (iPosition2 <= 0)
                            {
                                iPosition2 = 0;   // reset

                            }
                            else if (iPosition2 == 100)
                            {
                                Console.WriteLine("*********** Congratulation {0} You are Winner ************* ", sPlayer2);
                                return;
                            }
                            break;
                    }
                }
            }

        }
    }
}



