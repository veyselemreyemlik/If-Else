using System;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;
             if (time < 12)
            {
                Console.WriteLine("Günaydınn ... :) :) :)");
            }
             else if (time > 12)
            {
                Console.WriteLine("İyi Günler ... :) :) :) ");
            }
            else if ( time > 18)
            {
                Console.WriteLine(" İyi Akşamlar ... :) :) :)");
            }

            string sonuc = time <= 18 ? "İyi Günler.." : "İyi Geceler..";
            Console.WriteLine(sonuc);
        }
    }
}
