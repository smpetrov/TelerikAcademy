
/*
 * Прави се по лекцията на Николай Костов от Телерик.
 * Змията представлява координати върху конзолата
 * Змията се пази в опашка
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
class Snake
{
    //координати на позицията
    struct Position
    {
        public int row;
        public int col;
        //конструктор
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    static void Main()
    {
        //задаваме си помощни променливи за посоките
        byte right = 0;
        byte left = 1;
        byte down = 2;
        byte up = 3;

        //време на поява на храната 
        int lastFoodTime = 0;
        //време на годност на храната сред което изчезва и се появява нова - 8000 милисекунди
        int foodDissapearTime = 8000;
        //н тази променлива ще трупане негативни точки ако да foodDisapearTime храната не се изяде
        int negativePoints = 0;

        //възможните посоки на движение на главата на змията се пазят в directions
        Position[] directions = new Position[]
        {
            new Position(0,1), //надясно
            new Position(0,-1), //наляво
            new Position(1,0), //надолу
            new Position(-1,0), //нагоре
        };

        //така ще определяме скоростта на змията
        double sleepTime = 100;

        //текущата посока в която се движи змията се пази в direction пример: direction=1
        //т.е. directions[direction] главата се движи наляво
        int direction = right;

        //за да позтавяме храна на случайно място ни трабва случайно число
        Random randomNumbersGenerator = new Random();

        //за да не се увеличава буфера на конзолата безкрайно когато змията слиза надолу
        Console.BufferHeight = Console.WindowHeight;

        //създаваме лист с координатите на предметите препядствия
        List<Position> obstacles = new List<Position>()
        {
            new Position(12,12),
            new Position(14,20),
            new Position(20,45),
        };
        //рисуваме препядствията
        foreach (Position obstacle in obstacles)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(obstacle.col,obstacle.row);
            Console.Write("#");
        }
        //змията се пази в опашка от Position елементи
        Queue<Position> snakeElements = new Queue<Position>();
        //задаваме начална зния с няколко елемента
        for (int i = 0; i <= 5; i++)
        {
            snakeElements.Enqueue(new Position(0, i));
        }
        //изписваме змията на конзолата
        foreach (Position position in snakeElements)
        {
            Console.SetCursorPosition(position.col, position.row);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("*");
        }

        //определяме позицията на храната така че да не попада върху препядствие
        Position food;
        do
        {
            food = new Position(randomNumbersGenerator.Next(0,Console.WindowHeight),
                                randomNumbersGenerator.Next(0,Console.WindowWidth));
        }
        while (snakeElements.Contains(food) || obstacles.Contains(food));
        //записваме времето в което е създадена храната - TcokCount е брой милисекунди от стартиране на процесора
        lastFoodTime = Environment.TickCount;

        //изписваме храната
        Console.SetCursorPosition(food.col, food.row);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("@");

        //през определен период от време ще се прерисува конзолата
        while (true)
        {
            //змиата се движи наляво т.к direction = 0
            //проверяваме дали нещо е въведено от конзолата
            if (Console.KeyAvailable)
            {
                //прихващаме какво е въведено от конзолата
                ConsoleKeyInfo userInput = Console.ReadKey();
                //проверяваме какво е въведено от потребителя и задаваме посокото в която 
                //да се движи змията
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    //проверяваме дали не се опитваме да върмен змията назад т.е. тя се движи
                    //наляво а ние и задаваме да се движи надясно
                    if (direction != left) direction = right;
                }
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    //проверяваме дали не се опитваме да върмен змията назад т.е. тя се движи
                    //надясно а ние и задаваме да се движи наляво
                    if (direction != right) direction = left;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    //проверяваме дали не се опитваме да върмен змията назад т.е. тя се движи
                    //нагоре а ние и задаваме да се движи надолу
                    if (direction != up) direction = down;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    //проверяваме дали не се опитваме да върмен змията назад т.е. тя се движи
                    //надолу а ние и задаваме да се движи нагоре
                    if (direction != down) direction = up;
                }
            }

            //движението на змията става като записваме нов елемент в snakeElements 
            //с новите координати на главата на змията в зависимост от въведената от 
            //потребителя посока и да изтрием последния елемент на масива /т.е. първия добавен/

            //запазваме текущата позиция на главата на змиата
            Position snakeHead = snakeElements.Last();
            
            //вземане посоката в която ще се движи змията
            Position nexrDirection = directions[direction];
            //задаваме новата позиция на главата на змията т.е. към текушата позиция на главата
            //добавяме данните за определената посока
            Position snakeNewHead = new Position(snakeHead.row + nexrDirection.row,
                                                snakeHead.col + nexrDirection.col);
            //за новата позиция на главата на змията проверяваме дали не излиза извън конзолата
            //и дали не се савоизажда
            if (snakeNewHead.row < 0 || 
                snakeNewHead.col < 0 ||
                snakeNewHead.row >= Console.WindowHeight ||
                snakeNewHead.col >= Console.WindowWidth ||
                snakeElements.Contains(snakeNewHead) ||
                obstacles.Contains(snakeNewHead))
            {
                Console.SetCursorPosition(0,0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game over!");
                //даваме точки на потребителя колкото е дълга змията - 6 /началната дължина на змията/ 
                //умножено по 100 без нагативните точки
                int userPoints = (snakeElements.Count - 6) * 100 - negativePoints;
                Console.WriteLine("Your points are {0} !", userPoints);
                return;
            }

            //на мястото на старата глава слагаме * за да припокрием символа за глава
            Console.SetCursorPosition(snakeHead.col, snakeHead.row);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("*");

            //добавяме новата глава към змията и е изрисуваме
            snakeElements.Enqueue(snakeNewHead);
            Console.SetCursorPosition(snakeNewHead.col,snakeNewHead.row);
            Console.ForegroundColor = ConsoleColor.Gray;
            if (direction == right) Console.Write(">");
            if (direction == left) Console.Write("<");
            if (direction == down) Console.Write("v");
            if (direction == up) Console.Write("^");

            //за да определим дали змията е минала през храната вземаме координатите на 
            //главата на змията и ги сравняваме с тези на храната
            if ((snakeNewHead.col == food.col) && (snakeNewHead.row == food.row))
            {
                //змията се е хранила загова не махаме елемент от змията т.е. те се удължава
                //и се забързва
                sleepTime--;

                //храната е изядена затова добавяме нова и я рисуваме като проверяваме
                //новата храна да не е върху змията или препядствие
                do
                {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                                        randomNumbersGenerator.Next(0, Console.WindowWidth));
                }
                while(snakeElements.Contains(food) || obstacles.Contains(food));
                //записваме времето в което е създадена храната - TcokCount е брой милисекунди от стартиране на процесора
                lastFoodTime = Environment.TickCount;
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");

                //добавяне на случайно препядствие като проверяваме да не е върху змията
                //да не е върху старо препядствне и да не върху храната
                Position obstacle;
                do
                {
                    obstacle= new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                                          randomNumbersGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(obstacle) || obstacles.Contains(obstacle) || 
                       ((food.row != obstacle.row) && (food.col != obstacle.col)));
                obstacles.Add(obstacle);
                //изпечатваме новото препядствие
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("#");

            }
            else
            {
                //махаме последни елемент от змията т.е. тя се движи без да се е хранила
                //Dequeue освен ,че маха посведния елемент ни връща неговата стойност
                Position last = snakeElements.Dequeue();
                Console.SetCursorPosition(last.col, last.row);
                Console.Write(" ");
            }

            //проверяваме за изтекла годност на храната
            if (Environment.TickCount - lastFoodTime > foodDissapearTime)
            {
                //не е изядена храната за foodDissapearTime време и затова трупане негативни точки
                negativePoints += 50;

                //извеждаме нова храна след като на предната и изтече срока
                Console.SetCursorPosition(food.col, food.row);
                Console.Write(" ");

                //нова храната е добавена - рисуваме я като проверяваме
                //новата храна да не е върху змията или препяствие
                do
                {
                    food = new Position(randomNumbersGenerator.Next(0, Console.WindowHeight),
                                        randomNumbersGenerator.Next(0, Console.WindowWidth));
                }
                while (snakeElements.Contains(food) || obstacles.Contains(food));
                //записваме времето в което е създадена храната - TcokCount е брой милисекунди от стартиране на процесора
                lastFoodTime = Environment.TickCount;
                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
            }

            //задаваме период за изчакване потребителя да въведе клавиш
            //ако не се въведе нищо движението продържава в предишната посока
            //като сме направили sleepTime double осигуряваме по плавно увеличаване на скоростта
            sleepTime-=0.01;
            Thread.Sleep((int)sleepTime);
        }
    }
}
