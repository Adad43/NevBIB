using System;

namespace BIB1
{
    public class Person
    {
        string N1;
        public Person(string N1)
        {
            this.N1 = N1;

            void H1()
            {
                int G1, G2 = 1, G3 = 2;
                G1 = G2 + G3;
                Console.WriteLine($"1+2={G1}");
            }
            H1();

            void H2()
            {
                double G1, G2 = 1.2, G3 = 2.3;
                G1 = G2 + G3;
                Console.WriteLine($"1+2={G1}");
            }
            H2();
            void H3()
            {
                char h;

                Console.WriteLine("Введите a или b");
                h = Convert.ToChar(Console.ReadLine());

                if (h == 'a')
                {
                    Console.WriteLine("Пока !");
                }

                else if (h == 'b')
                {
                    Console.WriteLine("Привет !");
                }
            }
            H3();

            void H4()
            {
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        Console.Write(i+"x"+j+"="+i * j + "  ");
                    }
                    Console.WriteLine();
                }
            }
            H4();

            void H5()
            {
                Console.WriteLine("Усе нет больше текста !");
            }
            H5();

        }
        public void Print() => Console.WriteLine($"{N1}");

    }
}
