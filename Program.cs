using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру: пешка, конь, слон, ладья, ферзь или король");
            string pieces = Console.ReadLine();
            int Ax = 0, Ay = 0, Bx = 0, By = 0;
            Console.WriteLine("Введите начальное и конечное положения фигуры через Enter!!");
            Ax = Convert.ToInt32(Console.Read());
            Ay = Convert.ToInt32(Console.Read());
            string space = Console.ReadLine();
            Bx = Convert.ToInt32(Console.Read());
            By = Convert.ToInt32(Console.Read());
            Check(Ax, Ay);
            Check(Bx, By);
            if (pieces == "пешка" || pieces == "Пешка")
                IsPawnsCorrect(Ax, Ay, Bx, By);
            else if (pieces == "конь" || pieces == "Конь")
                IsKnightCorrect(Ax, Ay, Bx, By);
            else if (pieces == "слон" || pieces == "Слон")
                IsBishopCorrect(Ax, Ay, Bx, By);
            else if (pieces == "ладья" || pieces == "Ладья")
                IsRookCorrect(Ax, Ay, Bx, By);
            else if (pieces == "ферзь" || pieces == "Ферзь")
                IsQueenCorrect(Ax, Ay, Bx, By);
            else if (pieces == "король" || pieces == "Король")
                IsKingCorrect(Ax, Ay, Bx, By);
            else
            {
                Console.WriteLine("Такой фигуры нет.");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
        static void IsKnightCorrect(int Ax, int Ay, int Bx, int By) //Конь
        {
            int moving = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);

            if ((moving == 3) && (Math.Abs(Ax - Bx) == 1) || Math.Abs(Ax - Bx) == 2)
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }
        }
        static void IsPawnsCorrect(int Ax, int Ay, int Bx, int By) //Пешка
        {
            int moving = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
            if ((moving == 1) && (Math.Abs(Ax - Bx) == 0))
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }

        }
        static void IsBishopCorrect(int Ax, int Ay, int Bx, int By) //Слон
        {
            
            if (Math.Abs(Ax - Bx)==Math.Abs(Ay - By))
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }
        }
        static void IsRookCorrect(int Ax, int Ay, int Bx, int By) //Ладья
        {
            if (Math.Abs(Ax - Bx) == 0 && Math.Abs(Ay - By) != 0 || Math.Abs(Ax - Bx) != 0 && Math.Abs(Ay - By) == 0)
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }
        }
        static void IsQueenCorrect(int Ax, int Ay, int Bx, int By) //Ферзь
        {
            if (Math.Abs(Ax - Bx) == Math.Abs(Ay - By) || Math.Abs(Ax - Bx) == 0 && Math.Abs(Ay - By) != 0 || Math.Abs(Ax - Bx) != 0 && Math.Abs(Ay - By) == 0)
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }
        }
        static void IsKingCorrect(int Ax, int Ay, int Bx, int By) //Король
        {
            int moving = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
            if ((moving == 2)&&(Math.Abs(Ax - Bx) == Math.Abs(Ay - By)) || ((moving == 1) && Math.Abs(Ax - Bx) == 0 && Math.Abs(Ay - By) != 0 || Math.Abs(Ax - Bx) != 0 && Math.Abs(Ay - By) == 0))
            {
                Console.WriteLine("Ход верный");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ход неверный");
                Console.ReadKey();
            }
        }
        static void Check(int x, int y)
        {
            if (x < 65 || x > 72 || !(y < 8 || y > 1))
            {
                Console.WriteLine("Одна ошибка и ты ошибся");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
