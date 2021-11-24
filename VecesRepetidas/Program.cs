using System;
using System.Collections;
using System.Linq;

namespace VecesRepetidas
{
    class Program
    {
        public int[] array = new int[13]; 

        public int[] NewArray(int[] num, int NumD)
        {

            array = num.Where(i => i == NumD).ToArray();


            return array;
        }

        public static void Main(string[] args)
        {
            int[] num = new[] { 1, 2, 2, 3, 4, 5, 6, 7, 3, 2, 2, 2 };

            Console.Write("Digite un numero: ");
            int NumD = int.Parse(Console.ReadLine());

            Program newA = new Program();

            int[] result = newA.NewArray(num, NumD);

            foreach (var grouping in result.GroupBy(t => t).Where(t => t.Count() != 1))
            {
                Console.WriteLine(string.Format("'{0}' está repetido {1} veces.", grouping.Key, grouping.Count()));
            }

            Console.ReadKey();
        }
    }
}
