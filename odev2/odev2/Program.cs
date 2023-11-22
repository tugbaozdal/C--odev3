using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = { {0,0,1,1,1,1,1,1},
                            {1,0,1,1,1,1,1,1},
                            {1,0,1,1,0,0,0,0},
                            {1,0,1,1,0,1,1,0},
                            {1,0,1,1,0,1,1,0},
                            {1,0,0,0,0,1,1,0},
                            {1,1,1,1,1,1,1,0},
                            {1,1,1,1,1,1,1,0},
            };
            int yolUzunluk = 0;
            for (int i =0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (dizi[i, j] == 0)
                    {
                        Console.Write(dizi[i, j]+" ");
                        yolUzunluk++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("yol uzunluğu: " + yolUzunluk);
            
            Console.ReadLine();

                
        }
    }
}
