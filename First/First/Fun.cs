using System;
namespace First
{
    public class Fun
    {
        public Double funTan(double x) => Math.Tan(x);
        public Double funCtan(double x) => Math.Cos(x)/Math.Sin(x);
        public Double funSin(double x) => Math.Sin(x);
        public Double funCos(double x) => Math.Cos(x);


        public void Fun_tan(double DisplayX)
        {

            double epsilon = 0.073;
            double y = 1.1;
            double step = Math.PI / 25;        
            while (y >= -1.1)
            {
                for (double x = (-DisplayX - 0.5) * Math.PI; x <= (DisplayX + 0.5) * Math.PI; x += step)
                {
                    if (Math.Abs(funTan(x) - y) >= epsilon)
                        if (Math.Abs(y) < epsilon)
                            Console.Write("-");
                        else
                        {
                            Console.Write(" ");
                        }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                y -= 0.1;
            }
        }



        public void Fun_ctan(double DisplayX)
        {

            double epsilon = 0.073;
            double y = 1.1;
            double step = Math.PI / 25;    
            while (y >= -1.1)
            {
                for (double x = -DisplayX * Math.PI; x <= DisplayX * Math.PI; x += step)
                {
                    if (Math.Abs(funCtan(x) - y) >= epsilon)
                        if (Math.Abs(y) < epsilon)
                            Console.Write("-");
                        else
                        {
                            Console.Write(" ");
                        }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                y -= 0.1;
            }
        }


        public void Fun_cos(double DisplayX)
        {

            double epsilon = 0.04;
            double y = 1.1;
            double step = Math.PI / 30;       
            while (y >= -1.1)
            {
                for (double x = -DisplayX * Math.PI; x <= DisplayX * Math.PI; x += step)
                {
                    if (Math.Abs(funCos(x) - y) >= epsilon)
                        if (Math.Abs(y) < epsilon)
                            Console.Write("-");
                        else
                        {
                            Console.Write(" ");
                        }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                y -= 0.1;
            }
        }


        public void Fun_sin(double DisplayX)
        {

            double epsilon = 0.04;
            double y = 1.1;
            double step = Math.PI / 30;       
            while (y >= -1.1)
            {
                for (double x = -DisplayX * Math.PI; x <= DisplayX * Math.PI; x += step)
                {
                    if (Math.Abs(funSin(x) - y) >= epsilon)
                        if (Math.Abs(y) < epsilon)
                            Console.Write("-");
                        else
                        {
                            Console.Write(" ");
                        }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                y -= 0.1;
            }
        }
    }
}

