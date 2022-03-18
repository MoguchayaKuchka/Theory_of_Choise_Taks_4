using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_of_Choise_Taks_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] rating = new int[8];
            //for (int i = 1; i < 9; i++)
            //{
            //    rating[i - 1] = i;
            //}
            int[,] table = new int[12, 8] {};

            //for (int i = 0; i < 12; i++)
            //{
            //    Shuffle(rating);
            //    for (int j = 0; j < 8; j++)
            //    {
            //        table[i, j] = rating[j];
            //    }
            //}
            Table_display(table);
            Average(table);
            Console.ReadKey();
        }
        static void Shuffle(int[] arr)
        {
            Random rnd = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);

                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        static void Table_display(int[,] arr)
        {
            Console.WriteLine("№ |Пр 1|Пр 2|Пр 3|Пр 4|Пр 5|Пр 6|Пр 7|Пр 8|");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("-------------------------------------------");
                if (i + 1 < 10) Console.Write((i + 1) + " |");
                else Console.Write((i + 1) + "|");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(arr[i, j] + "   |");
                }
                Console.Write("\n");
            }
        }
        static void Average(int[,] arr)
        {
            int[] summs = new int[8];
            for (int i = 0; i < 8; i++)
            {
                int sum = 0;
                for (int j = 0; j < 12; j++)
                {
                    sum += arr[j, i];
                }
                summs[i] = sum;
            }
            Console.WriteLine("-------------------------------------------");
            Console.Write("SU|");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(summs[i] + "  |");
            }
            Console.WriteLine("\n-------------------------------------------");
            Console.Write("AV|");
            for (int i = 0; i < 8; i++)
            {

                Console.Write(Math.Round((double)summs[i] / 12, 2));
                for (int j = 0; j < 4 - Math.Round((double)summs[i] / 12, 2).ToString().Length; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
            }



        }
    }
}
