using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ax=0, Ay=0, Bx=0, By=0;
            Console.WriteLine("Введите начальное и конечное положения фигуры через Enter!!");
            Ax = Convert.ToInt32(Console.Read());
            Ay = Convert.ToInt32(Console.Read());
            string space = Console.ReadLine();
            Bx = Convert.ToInt32(Console.Read());
            By = Convert.ToInt32(Console.Read());
            Check(Ax, Ay);
            Check(Bx, By);

            IsPawnsCorrect(Ax, Ay, Bx, By);
        }
        static void IsHorseCorrect(int Ax, int Ay, int Bx, int By)
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
        static void IsPawnsCorrect(int Ax, int Ay, int Bx, int By)
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
        static void Check(int x, int y)
        {
            if (x < 65 || x > 72 || !(y < 8 || y > 1))
            {
                Console.WriteLine("Одна ошибка и ты ошибся, попробуй заново");
                Console.ReadKey();
            }
        }
    }
}
