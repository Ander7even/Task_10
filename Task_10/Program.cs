using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(30, 40, 50); 
            angle.Gradus(); 
            angle.ToRadians(); 
            Console.ReadKey();
        }
    }

    class Angle 
    {
        int gradus; 
        int min; 
        int sec; 

        public int Grad 
        {
            set
            {
                if (value > 0 && value < 360) 
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов не может быть меньше 0 и больше 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min 
        {
            set
            {
                if (value > 0 && value < 60)  
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут не может быть меньше 0 и больше 60");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec 
        {
            set
            {
                if (value > 0 && value < 60)
                {
                    sec = value;

                }
                else
                {
                    Console.WriteLine("Значение не может быть меньше 0 и больше 60");
                }
            }
            get
            {
                return sec;
            }

        }

        public Angle(int grad, int min, int sec) 
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public void Gradus() 
        {
            Console.WriteLine("Угол {0} градусов {1} минут {2} секунд", Grad, Min, Sec);
        }
        public double ToRadians() 
        {
            double rad = (Grad + Min / 60 + Sec / 60 / 60) * Math.PI / 180;
            Console.WriteLine("Угол равен {0:f2} радиан", rad);
            return rad;
        }
    }



}
