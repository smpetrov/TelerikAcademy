/*
 * Прави се по лекцията на Николай Костов от Телерик.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Cars
{
    //описва количке, бонуси и препяствия
    struct Object
    {
        //координати на количката
        public int x;
        public int y;
        //символа на количката
        public char c;
        //цвят на количката
        public ConsoleColor color;
    }

    //с този метод ще пишем по конзолата символи
    static void PrintOnPosition(int x, int y, char c, 
                 ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x,y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }

    //с този метод ще пишем по конзолата стрингове
    static void PrintStringOnPosition(int x, int y, string str,
                 ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }

    static void Main()
    {
        //определяме скорост
        double speed = 100.0;

        //размер на игралното полето
        int playfieldWidth = 5;

        //брой животи - колко пъти може да ни удари удваща количка
        int livesCount = 5;

        //махане на страничине скролбар и задаваме размери на конзолата
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 30;

        //дефинираме нашата количка
        Object userCar = new Object();
        userCar.x = 2;
        userCar.y = Console.WindowHeight - 1;
        userCar.c = '@';
        userCar.color = ConsoleColor.Yellow;

        //генератор на случайни числа
        Random randomGenerator= new Random();      

        //списък на количките идващи срещу нашата количка
        List<Object> objects = new List<Object>();

        while (true)
        {
            //увеличаваме скоростта
            double acceleration = 0.5;
            speed += acceleration;
            if (speed > 400)
            {
                speed = 400;
            }

            //тук съхраняваме дали сме ударени
            bool hitted = false;           

            //създаваме нова количка или бонус на всеки ход
            int chance = randomGenerator.Next(0, 100);
            if (chance <= 10)
            {
                //add bonus , увеличава живот
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                //връща случяйно цяло число между 0 и playfieldWidth  - без playfieldWidth
                newObject.x = randomGenerator.Next(0, playfieldWidth);
                newObject.y = 0;
                newObject.c = '-';
                //добавяме новата количка в списъка с колички
                objects.Add(newObject);
            }
            else if (chance <= 20)
            {
                //add bonus , намалява скоростта
                Object newObject = new Object();
                newObject.color = ConsoleColor.Cyan;
                //връща случяйно цяло число между 0 и playfieldWidth  - без playfieldWidth
                newObject.x = randomGenerator.Next(0, playfieldWidth);
                newObject.y = 0;
                newObject.c = '*';
                //добавяме новата количка в списъка с колички
                objects.Add(newObject);
            }
            else
            {
                //add car
                Object newCar = new Object();
                newCar.color = ConsoleColor.Green;
                //връща случяйно цяло число между 0 и playfieldWidth  - без playfieldWidth
                newCar.x = randomGenerator.Next(0, playfieldWidth);
                newCar.y = 0;
                newCar.c = '#';
                //добавяме новата количка в списъка с колички
                objects.Add(newCar);
            }

            //връща случяйно цяло число между 1 и 2  - без 3
            //randomGenerator.Next(1 , 3);

            //Move our car /key pressed/
            //проверяваме има ли натиснат клавиш
            while (Console.KeyAvailable)
            {
                //прихващаме въведеното от потребителя. true - не извеждай въведения символ
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //четем докато изчистим буфера на клавиатурата
                //while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userCar.x - 1 >= 0)
                    {
                        userCar.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                { 
                    if (userCar.x + 1 < playfieldWidth)
                    {
                        userCar.x++;
                    }
                }
            }

            //Move cars
            //сэздаваме нов списък в който всички колички са с една позиция напред
            List<Object> newList = new List<Object>();
            //тук не може foreach т.к. при този цикъл не може да се променят обектите с които работи
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldOppositeCar = objects[i];
                Object newOppositeObject = new Object();
                newOppositeObject.x = oldOppositeCar.x;
                newOppositeObject.y = oldOppositeCar.y + 1;
                newOppositeObject.c = oldOppositeCar.c;
                newOppositeObject.color = oldOppositeCar.color;
                //Check if other objects are hitting us
                //ако е бонус - увеличава живот
                if ((newOppositeObject.c == '-') && (newOppositeObject.x == userCar.x) &&
                    (newOppositeObject.y == userCar.y))
                {
                    livesCount++;
                }
                //ако е бонус * намаляваме скоростта
                if ((newOppositeObject.c == '*') && (newOppositeObject.x == userCar.x) &&
                    (newOppositeObject.y == userCar.y))
                {
                    speed -= 20;
                    if (speed > 400)
                    {
                        speed = 400;
                    }
                }
                //ако сме ударени увеличава сколостта и намалява брой животи
                if ((newOppositeObject.c == '#') && (newOppositeObject.x == userCar.x) && 
                    (newOppositeObject.y == userCar.y))
                {
                    //запомняме , че сме дали ударени
                    hitted = true;                   
                    //при сблъсък уверичаваме скоростта
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }

                    // при сблъсък
                    livesCount--;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(8, 10, "GAME OVER !", ConsoleColor.Red);
                        PrintStringOnPosition(8, 12, "Press any key to exit!", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newOppositeObject.y < Console.WindowHeight)
                {
                    newList.Add(newOppositeObject);
                }
            }
            objects = newList;
            
            //Clear the console
            Console.Clear();

            //Redraw palyfield
            //рисуваме нашата количка
            if (hitted)
            {
                //при сблъсък започваме отначало т.е. изчисване количките
                objects.Clear();

                //изписваме Х ако е имало сблъсък
                PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
            }
            //рисуваме другите колички
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);    
            }
            
            
            //Draw info
            PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(8, 6, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnPosition(8, 8, "Acceleration: " + acceleration, ConsoleColor.White);

            //Console.Beep();

            //Slow down program
            Thread.Sleep((int)(600 - speed));
        }
    }
}
