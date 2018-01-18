using static System.Math;

namespace Lab1Task6
{
    struct MathCore
    {
        public double Result(int year)
        {
            return 0.01 * Pow(2.71, 0.0375 * (year - 1350)) + Pow(year + 595, 2) - 75 * (year - 350) * Pow(1, 3.5) + 273914997;
        }

        public double BioPotencilaMaltus(double n, int time, double dN)
        {
            return dN / (time * n);
        }

        public double Maltus(double r, int year, int n0)
        {
            return n0 * Pow(2.71, r * 1);
        }

        public double Ferhlust(int n0, double r)
        {
            return n0 * r * 0.98 + n0;
        }

        public double GetErr(int n, double x, double xAverage)
        {
            double summ = 0;

            for (int i = 0; i < n; i++)
            {
                summ += Pow(x - xAverage, 2);
            }

            return Pow(summ / (n - 1), 0.25);
        }
    }
}
