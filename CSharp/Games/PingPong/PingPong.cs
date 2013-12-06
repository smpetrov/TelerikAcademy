/*
 * Прави се по лекцията на Николай Костов от Телерик.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class PingPong
    {
        //координати на топчето
        static int ballPositionX = 0;
        static int ballPositionY = 0;

        //координате на хилките
        static int firstPlayerPosition = 0;
        static int secondPlayerPosition = 0;
        //размер на хилката
        static int firstPlayerPadSize = 4;
        static int secondPlayerPadSize = 4;

        //резултат - брой победи
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;

        //генератор на случайни числа
        static Random randomGenerator = new Random();

        //посоки на движение на тончета
        static bool ballDirectionUp = true;
        static bool ballDirectionRight = true;

        static void RemoveScrollBars()
        {
            //определяме игралното поле
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
        }

        //изчертаване на хилките и топчето
        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y < firstPlayerPosition+firstPlayerPadSize ; y++)
            {
                PintAtPosition(0, y, '|'); 
                PintAtPosition(1, y, '|');
            }
        }
        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + secondPlayerPadSize; y++)
            {
                PintAtPosition(Console.WindowWidth - 1, y, '|');
                PintAtPosition(Console.WindowWidth - 2, y, '|');
            }
        }

        private static void DrawBall()
        {
            PintAtPosition(ballPositionX, ballPositionY, '@');
        }


        static void PintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        //първоначална позиция на хилките и топчето
        static void SetIntialPosition()
        {
            firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
            SettBallAtTheMididdleOfTheGameField();
        }

        static void SettBallAtTheMididdleOfTheGameField()
        {
            ballPositionX = Console.WindowWidth / 2;
            ballPositionY = Console.WindowHeight / 2;
        }

        //принт на резултата
        static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.Write("{0}-{1}",firstPlayerResult,secondPlayerResult);
        }

        //местим първата хилка
        static void MoveFirstPlayerDown()
        {
            if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize)
            {
                firstPlayerPosition++;
            }
        }
        static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }
        }

        //местим втората хилка
        static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize)
            {
                secondPlayerPosition++;
            }
        }
        static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }
        }

        //логика за местене на втората хилка /компютъра/
        static void SecondPlayerAIMove()
        {
            //int randomNumber = randomGenerator.Next(0,2);
            //if (randomNumber == 0)
            //{
            //    MoveSecondPlayerUp();
            //}
            //if (randomNumber == 1)
            //{
            //    MoveSecondPlayerDown();
            //}

            int randomNumber = randomGenerator.Next(1, 101);
            if (randomNumber < 90)
            {
                if (ballDirectionUp == true)
                {
                    MoveSecondPlayerUp();
                }
                else
                {
                    MoveSecondPlayerDown();
                }
            }
        }

        //местене на топчето
        static void MoveBall()
        {
            //управление движението нагоре
            if (ballPositionY < 1)
            {
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                ballDirectionUp = true;
            }
            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }


            //управление движението встрани
            if (ballPositionX == Console.WindowWidth - 1)
            {
                //second player loses
                SettBallAtTheMididdleOfTheGameField();
                ballDirectionRight = false;
                ballDirectionUp = true;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.Write("The first player win!");
                Console.ReadKey(true);
            }
            if (ballPositionX == 0)
            {
                //first player loses
                SettBallAtTheMididdleOfTheGameField();
                ballDirectionRight = true;
                ballDirectionUp = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.Write("The Second player win!");
                Console.ReadKey(true);
            }

            //топчето е при първия играч
            if (ballPositionX < 3)
            {
                if ((ballPositionY >= firstPlayerPosition) && 
                    (ballPositionY < firstPlayerPosition + firstPlayerPadSize))
                {
                    ballDirectionRight = true;
                }
            }

            //топчето е при втория играч
            if (ballPositionX >= Console.WindowWidth -3 -1)
            {
                if ((ballPositionY >= secondPlayerPosition) &&
                    (ballPositionY < secondPlayerPosition + secondPlayerPadSize))
                {
                    ballDirectionRight = false;
                }
            }

            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }

        static void Main()
        {

            RemoveScrollBars();
            SetIntialPosition();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    //прихващаме въведеното от потребителя
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    //Move first player
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveFirstPlayerDown();
                    }
                }
                

                //Move second player
                SecondPlayerAIMove();

                //Move ball
                MoveBall();

                //Redraw all
                // - clear all
                Console.Clear();

                // -draw first player
                DrawFirstPlayer();

                // -draw secod layer
                DrawSecondPlayer();

                // -draw ball
                DrawBall();

                // -print result
                PrintResult();

                //sleep
                Thread.Sleep(60);

            }
        }




    }
}
