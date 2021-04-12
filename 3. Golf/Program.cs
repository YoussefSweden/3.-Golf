using System;
using System.Collections.Generic;
using System.Linq;

namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            double startGoal = rd.Next(300, 500); //var  målet ligger
            Console.WriteLine(startGoal);

            List<double> slagLengd = new List<double>();
            double summaSlaglengd = 0;

            List<double> tillHål = new List<double>();
            double summatillHole = 0;//test

            int antalSlag = 0;//slagräknare


            while (startGoal != summaSlaglengd)
            {
                slagLengd.Add(slaget());
                summaSlaglengd = slagLengd.Sum();
                summatillHole = startGoal - summaSlaglengd;

                Console.WriteLine("slaget " + summaSlaglengd);
                Console.WriteLine("kvar " + summatillHole);
                antalSlag++;
            }

            // skriva ut längden och antal slag
            Console.WriteLine("\nGrattis, krävdes " + antalSlag + " slag");
            Console.WriteLine("\nHär är längden per slag i meter:\n");
            for (int i = 0; i < slagLengd.Count; i++)
            {
                Console.WriteLine("slag " + (i + 1) + ": " + slagLengd[i]);
            }

            //swingen

            static double slaget()
            {
                Console.Write("Ange ett heltal för vinkel: ");
                int angle = int.Parse(Console.ReadLine());

                //try
                //{
                //if (angle >= 90 || angle<=0)
                //{
                //    throw new ArithmeticException();
                //}

                //}
                //catch (ArithmeticException e)
                //{
                //    Console.WriteLine(e);
                //}


                Console.Write("ett heltal för hastighet: ");
                int velocity = int.Parse(Console.ReadLine());

                double angleInRadians = (Math.PI / 180) * angle;
                double distance = Math.Round(Math.Pow(velocity, 2) / Golf.GRAVITY * Math.Sin(2 * angleInRadians), 0);
                return distance;
            }
        }
    }
}
