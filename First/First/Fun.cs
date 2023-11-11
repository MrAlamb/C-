using System;
namespace First
{
    public class Fun
    {
        public double func(double x, int Ssave)
        {
            switch (Ssave)
            {
                case 0:
                    return Math.Sin(x);
                case 1:
                    return Math.Cos(x);
                case 2:
                    return Math.Sin(x) / Math.Cos(x);
                case 3:
                    return Math.Cos(x) / Math.Sin(x);
                default:
                    return 0;
            }
        }

        public double setEpsilon(int Ssave)
        {
            switch (Ssave)
            {
                case 0:
                    return 0.05;
                case 1:
                    return 0.05;
                case 2:
                    return 0.05;
                case 3:
                    return 0.05;
                default:
                    return 0;
            }
        }
        public double setStep(int Ssave)
        {
            switch (Ssave)
            {
                case 0:
                    return Math.PI / 14;
                case 1:
                    return Math.PI / 14;
                case 2:
                    return Math.PI / 26.25;
                case 3:
                    return Math.PI / 26.25;
                default:
                    return 0;
            }
        }

        public void Funuction(double DisplayX, int Save)
        {

            double epsilon = setEpsilon(Save);
            double y = 1.1;
            double step = setStep(Save);
            while (y >= -1.1)
            {
                for (double x = -DisplayX * Math.PI; x <= DisplayX * Math.PI; x += step)
                {
                    if (Math.Abs(func(x, Save) - y) > epsilon)
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

