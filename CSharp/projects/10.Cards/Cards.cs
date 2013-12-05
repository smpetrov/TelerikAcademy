using System;

namespace loops
{
    class Cards
    {
        static void Main()
        {
            for (int i = 1; i <= 4; i++)
            {
                string color="";
                switch(i)
                {
                    case 1:
                        color="of spades";
                        break;
                    case 2:
                        color="of hearts";
                        break;
                    case 3:
                        color="of diamonds";
                        break;
                    case 4:
                        color="of clubs";
                        break;
                }
                for (int j = 2; j <= 14; j++)
                {
                    string card="";
                    switch (j)
                    {
                        case 2:
                            card="two";
                            break;
                        case 3:
                            card="three";
                            break;
                        case 4:
                            card="four";
                            break;
                        case 5:
                            card="five";
                            break;
                        case 6:
                            card="six";
                            break;
                        case 7:
                            card="seven";
                            break;
                        case 8:
                            card="eight";
                            break;
                        case 9:
                            card="nine";
                            break;
                        case 10:
                            card="ten";
                            break;
                        case 11:
                            card="jack";
                            break;
                        case 12:
                            card="queen";
                            break;
                        case 13:
                            card="king";
                            break;
                        case 14:
                            card="ace";
                            break;
                    }
                    Console.WriteLine(card+" "+color);
                }
                Console.WriteLine();
            }
        }
    }
}
