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
                        Console.Write(i + "x" + j + "=" + i * j + "  ");
                    }
                    Console.WriteLine();
                }
            }
            H4();

            void H5()
            {
                string GetMessage()
                {
                    return "Hello BIB1 !";
                }

                string message = GetMessage();
                Console.WriteLine(message);
            }
            H5();

            void H6()
            {
                int Sum(int x, int y)
                {
                    return x + y;
                }

                int result = Sum(10, 15);
                Console.WriteLine(result);

                Console.WriteLine(Sum(5, 6));
            }
            H6();

            void H7()
            {
                void PrintPerson(string name, int age)
                {
                    if (age > 120 || age < 1)
                    {
                        Console.WriteLine("Недопустимый возраст");
                        return;
                    }
                    Console.WriteLine($"Имя: {name}  Возраст: {age}");
                }

                PrintPerson("Tom", 37);
                PrintPerson("Dunkan", 34);
            }
            H7();

             
        }
        public void Print()
        {
            Console.WriteLine($"{N1}");
        }
    }
}
