
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
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

public class FallingRocks {
	Board br =new Board();
	
	public static JavaHowTo jht = new JavaHowTo();
	
	//клас описвща падащите скали
    class ScreenObject
    {
        //символ на обекта
        public char c;
        //Цвят на обекта
        //public Color color = new Color();
    }

    class Shattle
    {
        //координати на обекта
        public int x;
        public int y;
        //символ на обекта
        public char c;
        //Цвят на обекта
        //public Color color;
    }

	
	public static void main(String[] args) {
		//падащите скали
	    ScreenObject screenObject = new ScreenObject();

	    //нашия кораб
	    Shattle shattle = new Shattle();

	    //методи за изпечатване на екранните обекти
	    //, ConsoleColor color = ConsoleColor.Gray)
	    static void printCharOnPosition(int x, int y, char c) 
	    {
	    	jht.setCursorPosition((short)x,(short)y);
	        //Console.ForegroundColor = color;
	        System.out.print(c);
	    }
	    //, ConsoleColor color = ConsoleColor.Gray)
	    static void printStringOnPosition(int x, int y, String c)
	    {
	    	jht.setCursorPosition((short)x,(short)y);
	        //Console.ForegroundColor = color;
	    	System.out.print(c);
	    }



	        //space
	    	char[] fill = new char[41];
	    	Arrays.fill(fill,' ');
	        String spaceStr = new String(fill);

	        //брой животи
	        int livesCount = 5;
	        //levels
	        int level = 1;

	        //ponits
	        int points = 0;
	        //point level
	        ArrayList<Integer> pointLevel = new ArrayList<Integer>();
	        pointLevel.add(50);
	        pointLevel.add(100);
	        pointLevel.add(150);
	        pointLevel.add(200);
	        pointLevel.add(250);
	        pointLevel.add(300);
	        pointLevel.add(350);
	        pointLevel.add(400);
	        pointLevel.add(450);
	        pointLevel.add(500);
	        pointLevel.add(550);
	        
	        //скриваме показването на курсора
	        //Console.CursorVisible = false;

	        //скорост
	        double speed = 100;
	        //стъпка за увеличаване на скоростта
	        double accelerator = 0.5;

	        //определяме размера на игралното поле
	        int playFieldWidth = 41;

	        //определяме размерите на конзолата и махаме скролбаровете
	        //Console.BufferHeight = Console.WindowHeight = 20;
	        //Console.BufferWidth = Console.WindowWidth = 70;
	        int ConsoleWindowHeight = 20;
	        int ConsoleWindowWidth = 70;

	        //дифинираме нашия кораб
	        Shattle userShuttle = new Shattle();
	        userShuttle.x = playFieldWidth / 2 + 1;
	        userShuttle.y = ConsoleWindowHeight - 1;
	        userShuttle.c = 'O';
	        //userShuttle.color = ConsoleColor.Red;

	        //масив от възможните скали
	        char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
	        //масив от възможните цветове на скалите
	        //ConsoleColor[] colorsRocks = {ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.Green,
	        //                             ConsoleColor.Magenta,ConsoleColor.White};


	        //масив съдържащ скалите по екрана и го запълваме с празни символи
	        ScreenObject[][] screenRocks = new ScreenObject[ConsoleWindowHeight][playFieldWidth];
	        for (int i = 0; i < ConsoleWindowHeight; i++)
	        {
	            for (int j = 0; j < playFieldWidth; j++)
	            {
	                screenRocks[i][j].c = ' ';
	                //screenRocks[i][j].color = ConsoleColor.Black;
	            }
	        }

	        //разчертаваме игралното поле
	        for (int i = ConsoleWindowHeight - 1; i >= 0; i--)
	        {
	            printCharOnPosition(playFieldWidth, i, '|', ConsoleColor.White);
	        }

	        //генератор на случайни числа
	        Random randomGenerator = new Random();

	        while (true)
	        {
	            //на всяка стъпка по 1 точка
	            points++;

	            //на всяка стъпка увеличаваме скоростта
	            speed = speed + accelerator;
	            if (speed > 550)
	            {
	                speed = 550;
	            }
	            //увеличаваме нивото след всеки 50 спечелени точки и скоростта с 50
	            if (pointLevel.indexOf(points) != -1)
	            {
	                level++;
	                if (level >= 10)
	                {
	                    printStringOnPosition(50, 10, "Game over !", ConsoleColor.Green);
	                    printStringOnPosition(50, 15, "Your points " + points + " !", ConsoleColor.Green);
	                    printStringOnPosition(50, 17, "YOU WIN !!!", ConsoleColor.Cyan);
	                    return;
	                }
	                speed = speed + 50;
	                if (speed > 550)
	                {
	                    speed = 550;
	                }
	            }

	            //съэдаваме на всеки ход по един ред от масива със скали със съответната плътност
	            //преместваме всеки ред с един напред
	            for (int i = ConsoleWindowHeight - 2; i >= 0; i--)
	            {
	                for (int j = 0; j < playFieldWidth; j++)
	                {
	                    screenRocks[i + 1][j] = screenRocks[i][j];
	                }
	            }
	            //изпразваме ред 0 от масива със скалите
	            for (int i = 0; i < playFieldWidth; i++)
	            {
	                screenRocks[0][i].c = ' ';
	                //screenRocks[0][i].color = ConsoleColor.Black;
	            }

	            //на първия ред пишем новогенерираните скали
	            //генерираме нови скали
	            //колкото и нивото толкова са скалите на ред
	            for (int i = 0; i < level; i++)
	            {
	                int indexRock;
	                int indexColor;
	                int indexArea;
	                do
	                {
	                    indexRock = randomGenerator.Next(0, rocks.Length);
	                    indexColor = randomGenerator.Next(0, colorsRocks.Length);
	                    indexArea = randomGenerator.Next(0, playFieldWidth);
	                }
	                while (screenRocks[0][indexArea].c != ' ');
	                screenRocks[0][indexArea].c = rocks[indexRock];
	                //screenRocks[0][indexArea].color = colorsRocks[indexColor];
	            }

	            //проверка за сблъсък
	            boolean hasHit = false;
	            for (int i = 0; i < playFieldWidth; i++)
	            {
	                if ((userShuttle.x == i) &&
	                    (screenRocks[ConsoleWindowHeight - 1][i].c != ' '))
	                {
	                    hasHit = true;
	                    if (livesCount - 1 <= 0)
	                    {
	                        printStringOnPosition(50, 10, "Game over !");  //, ConsoleColor.Green);
	                        //Console.ReadKey(true);
	                        return;
	                    }
	                    else
	                    {
	                        livesCount--;
	                        hasHit = true;
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
	                    if (userShuttle.x - 1 >= 0)
	                    {
	                        userShuttle.x--;
	                    }

	                }
	                else if (pressedKey.Key == ConsoleKey.RightArrow)
	                {
	                    if (userShuttle.x + 1 < playFieldWidth)
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
	            if (hasHit)
	            {
	                printCharOnPosition(userShuttle.x, userShuttle.y, 'X', ConsoleColor.Red);
	                Console.Beep();
	            }
	            else
	            {
	                printCharOnPosition(userShuttle.x, userShuttle.y, userShuttle.c, userShuttle.color);
	            }

	            printStringOnPosition(50, 7, "Level = " + level, ConsoleColor.Green);
	            printStringOnPosition(50, 8, "Lives = " + livesCount, ConsoleColor.Green);
	            printStringOnPosition(50, 15, "Your points " + points + " !", ConsoleColor.Green);

	            //Draw info
	            //Slow down program
	            Thread.Sleep((int)(600 - speed));
	        }
	}

}
