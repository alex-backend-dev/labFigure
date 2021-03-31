using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labFigure
{
    class Program
    {
        static void Main(string[] args) // возьмем за основу равнобедренную трапецию
        {
            Console.Title = "Разработка класса трапеции";

            Console.Write("Введите верхнее основание трапеции: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Введите нижнее основание трапеции: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Введите боковую сторону: ");
            double sideC = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту трапеции: ");
            double sideH = double.Parse(Console.ReadLine());

            Trapeze newTrapeze = new Trapeze(sideA, sideB, sideC, sideH);
            if (newTrapeze.ExistanceTrapeze() == true) 
            {
                newTrapeze.OutTrapeze();
            }
            else
            {
                newTrapeze.MistakenTrapeze();
            }

            Console.ReadLine();
        }
    }
    class Trapeze 
    {
        public double a, b, c, h;

        public Trapeze ()
        {
            a = 0;
            b = 0;
            c = 0;
            h = 0;
        }

        public Trapeze(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
            return;
        }

        public double A
        {
            get => a;
            set => a = value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }
        public double H
        {
            get => h;
            set => h = value;
        }
        public bool ExistanceTrapeze() 
        {
            bool result = false;
            if (a < b + 2 * c && (b < a + b + 2 * c) && (2 * c < a + b + c))
            {
                result = true;
            }
            return result;  
        }
        public double P()
        {
            double p = a + b + 2*c; // периметр по четырем сторонам
            return p;
        }
        public double S()
        {
            double s = 0.5 * (a + b) * h; // площадь
            return s;
        }
        public void OutTrapeze() // вывод результата для существующей равнобедренной трапеции
        {
            Console.WriteLine("Периметр равнобедренной трапеции: {0}", P());
            Console.WriteLine("Площадь равнобедренной трапеции: {0}", S());
        }
        public void MistakenTrapeze () // вывод сообщения для несуществующей трапеции
        {
            Console.WriteLine("Вы ввели параметры несуществующей трапеции! ");
        }
    }
}