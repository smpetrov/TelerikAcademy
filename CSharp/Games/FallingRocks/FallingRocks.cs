/*
 * Implement the "Falling Rocks" game in the text console. 
 * A small dwarf stays at the bottom of the screen and 
 * can move left and right (by the arrows keys). 
 * A number of rocks of different sizes and forms constantly 
 * fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - 
 * distributed with appropriate density. 
 * The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system
 * 
 * Прави се по лекцията на Николай Костов от Телерик за играта justcars.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class FallingRocks
{
    //структура описвща падащите скали
    struct ScreenObject
    {
        //символ на обекта
        public char c;
        //Цвят на обекта
        public ConsoleColor color;
    }

    //сртуктура описваща нашия кораб
    struct Shattle
    {
        //координати на обекта
        public int x;
        public int y;
        //символ на обекта
        public char c;
        //Цвят на обекта
        public ConsoleColor color;
    }
    
    //методи за изпечатване на екранните обекти
    static void printCharOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x , y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void printStringOnPosition(int x, int y, String c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    
    
    static void Main(string[] args)
    {
        //space
        string spaceStr = new string(' ',41);       
    
        //брой животи
        int livesCount = 5;

        //скриваме показването на курсора
        Console.CursorVisible = false;

        //скорост
        double speed = 500;

        //определяме размера на игралното поле
        int playFieldWidth = 41;

        //определяме размерите на конзолата и махаме скролбаровете
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 70;

        //дифинираме нашия кораб
        Shattle userShuttle = new Shattle();
        userShuttle.x = playFieldWidth / 2 + 1;
        userShuttle.y = Console.WindowHeight - 1; 
        userShuttle.c = 'O';
        userShuttle.color = ConsoleColor.Red;

        //масив от възможните скали
        char[] rocks = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-'};
        //масив от възможните цветове на скалите
        ConsoleColor[] colorsRocks = {ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.Green,
                                     ConsoleColor.Magenta,ConsoleColor.White};


        //масив съдържащ скалите по екрана и го запълваме с празни символи
        ScreenObject[,] screenRocks = new ScreenObject[Console.WindowHeight, playFieldWidth];
        for (int i = 0; i < Console.WindowHeight; i++)
			{
			    for (int j = 0; j < playFieldWidth; j++)
			    {
			        screenRocks[i,j].c = ' ';
                    screenRocks[i, j].color = ConsoleColor.Black;
			    }
			}

        //разчертаваме игралното поле
        for (int i = Console.WindowHeight - 1; i >= 0; i--)
        {
            printCharOnPosition(playFieldWidth, i, '|', ConsoleColor.White);
        }

        //генератор на случайни числа
        Random randomGenerator = new Random();

        while (true)
        {
            //съэдаваме на всеки ход по един ред от масива със скали със съответната плътност
            //преместваме всеки ред с един напред
            for (int i = Console.WindowHeight - 2; i >= 0; i--)
			{
			    for (int j = 0; j < playFieldWidth; j++)
			    {
	                screenRocks[i + 1,j]=screenRocks[i , j];
    			}
			}
            //изпразваме ред 0 от масива със скалите
            for (int i = 0; i < playFieldWidth; i++)
			{
			    screenRocks[0,i].c = ' ';
                screenRocks[0,i].color = ConsoleColor.Black;
			}
            //на първия ред пишем новогенерираните скали
            //генерираме нови скали
            int indexRock = randomGenerator.Next(0,rocks.Length);
            int indexColor = randomGenerator.Next(0,colorsRocks.Length);
            int indexArea = randomGenerator.Next(0,playFieldWidth);
            screenRocks[0,indexArea].c = rocks[indexRock];
            screenRocks[0,indexArea].color = colorsRocks[indexColor];

            //проверка за сблъсък
            bool hasHit = false;
            for (int i = 0; i < playFieldWidth; i++)
            {
                if ((userShuttle.x == i) && 
                    (screenRocks[Console.WindowHeight - 1 , i].c != ' '))
                {
                    hasHit = true;
                    if (livesCount-1 <= 0)
                    {
                        printStringOnPosition(50, 10, "Game over !", ConsoleColor.Green);
                        Console.ReadKey(true);
                        return;
                    }
                    else
                    {
                        livesCount--;
                    }
                }
            }

            //Move our car /key pressed/
            while (Console.KeyAvailable)
            {
                //прихващаме клавиша на тиснат от потребителя. true - не извеждай въведения символ
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userShuttle.x -1 >= 0)
                    {
                        userShuttle.x--;
                    }

                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if(userShuttle.x + 1 < playFieldWidth)
                    {
                        userShuttle.x++;
                    }
                }
            }

            //Move cars
            //Redraw palyfield
            for (int i = Console.WindowHeight - 2; i >= 0; i--)
			{
			    for (int j = 0; j < playFieldWidth; j++)
			    {
                     printCharOnPosition(j, i, screenRocks[i, j].c, screenRocks[i, j].color);
    			}
			}
            printStringOnPosition(0, userShuttle.y, spaceStr, ConsoleColor.Black);
            printCharOnPosition(userShuttle.x, userShuttle.y, userShuttle.c, userShuttle.color);

            printStringOnPosition(50, 5, "Lives = "+livesCount, ConsoleColor.Green);
            
            //Draw info
            //Slow down program
            Thread.Sleep((int)(600 - speed));
        }
    }
}
