using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyoldal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            string[] sor = Console.ReadLine().Split(' ');
            int N = int.Parse(sor[0]);
            int M = int.Parse(sor[1]);
            int K = int.Parse(sor[2]);
            int G = int.Parse(sor[3]);

            int[,] mátrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mátrix[i, j] = 0;
                }
            }
            for (int i = 0; i < K; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                mátrix[int.Parse(s[0]), int.Parse(s[1])] = 1;

            }
            List<(int, int)> gyujtohelyek = new List<(int, int)>();
            for (int i = 0; i < G; i++)

            {
                string[] s = Console.ReadLine().Split(' ');
                gyujtohelyek.Add((-1, -1));
                gyujtohelyek[i] = (int.Parse(s[0]), int.Parse(s[1]));

            }

            Console.ReadLine();
        }
    }
}
