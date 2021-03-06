﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;
            Console.WriteLine("5+4={0}", GetSum(x, y));
            Console.WriteLine("x " + x);

            int solution;

            Doublelt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 :{1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After Swap num1 : {0} num2 :{1}", num1, num2);

            Console.WriteLine("1+2+3={0}", GetSumeMore(1, 2, 3));

            PrintInfo(zipCode: 15147, name: "Derek");

            Console.WriteLine("5.0 + 4.5 = {0}", GetSum(5.0, 4.5));

            Console.WriteLine("5.0 + 4.5 = {0}", GetSum("5,0", "4,5"));

            CarColor car1 = CarColor.Red;
            PaintCar(car1);

            Console.ReadLine();
        }
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        static double GetSum(string x = "1", string y = "1")
        {

            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
                       
            return dblX + dblY;
        }

        static void Doublelt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static double GetSumeMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Gereen,
            Red,
            Yellow
        }

        static void PaintCar (CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
            }
}
