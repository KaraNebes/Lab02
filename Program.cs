using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {

            char Ax = Convert.ToChar(Console.Read());
            int Ay = Convert.ToInt32(Console.Read());
            char space = Convert.ToChar(Console.Read());
            char Bx = Convert.ToChar(Console.Read());
            int By = Convert.ToInt32(Console.Read());
            Check(Ax, Ay);
            Check(Bx, By);
            IsHorseCorrect(Ax, Ay, Bx, By);
        }
        static void IsHorseCorrect(char Ax, int Ay, char Bx, int By)
        {
            string alfa = "ABCDEFGH";
            int moving = Math.Abs(alfa.IndexOf(Ax) - alfa.IndexOf(Bx)) + Math.Abs(Ay - By);

            if ((moving == 3) && (Math.Abs(alfa.IndexOf(Ax) - alfa.IndexOf(Bx)) == 1) || Math.Abs(alfa.IndexOf(Ax) - alfa.IndexOf(Bx)) == 2)
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
        static void Check(char x, int y)
        {
            if (Convert.ToInt32(x) < 65 || Convert.ToInt32(x) > 72 || !(y < 8 || y > 1))
            {
                Console.WriteLine("Одна ошибка и ты ошибся");
                Console.ReadKey();
            }
        }


    }
}
