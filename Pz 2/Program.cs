using System;

namespace Pz_12_3
{
    class Programma
    {
        static void Main(string[] args)
        {
            double _A;
            double _B;
            double _x;
            double _c;
            double _y;


            Console.WriteLine("");
            Read();
            root();
            _y = _A * _x + _B;
            _c = Math.Sqrt((_A * _x) + _B);
            Display();
            Console.WriteLine("");
            void root()
            {


                if (_B != 0)
                {
                    Console.WriteLine("(B) неравняется нулю");
                }
                else if (_B == 0)
                {
                    Console.WriteLine("(B) равняется нулю");
                }
                Console.WriteLine("");
            }
            void Display()
            {
                Console.WriteLine("A: {0} \nB: {1} \nx: {2} \ny: {3} \ny в корне: {4},", _A, _B, _x, _y, _c);
            }
            void Read()
            {
                Console.WriteLine("Введите А");
                _A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите B");
                _B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите x");
                _x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
            }
        }

    }


}
