using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Human J=new Human("Josh", 30, 4);
            Human A=new Human("Torus", 50, 7, 5, 150);
            Console.WriteLine(A.Strength);
            A.Attack(J);
            A.Attack(A);

        }
    }
}
