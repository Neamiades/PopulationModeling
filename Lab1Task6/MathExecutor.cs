using static System.Math;

namespace Lab1Task6
{
    public static class MathExecutor
    {
        public static double GetPopulationByYear(int year)
        {
            return 0.002 * (25 * Exp(0.0375 * (year - 1350)) + Pow(year + 595, 2) - 20963.1373 * (year - 350) + 273914997);
        }

        //P(t) = P0 * e ^ (a * t)
        public static double Maltus(int t, int p0, double a)
        {
            return p0 * Exp(a * t);
        }

        //P(t) = P0 * M / (P0 + (M - P0) * e ^ (-r * t))
        public static double Ferhlust(int t, int p0, double m, double r)
        {
            return p0 * m / (p0 + (m - p0) * Exp(-r * t));
        }

        public static double GetErr(double facticalPopulation, double ModelingPopulation)
        {
            return (ModelingPopulation - facticalPopulation) / facticalPopulation * 100;
        }

        public static double GetMaltusCoef(int year)
        {
            var P0 = GetPopulationByYear(year);
            var P1 = GetPopulationByYear(year + 1);

            return Log(P1 / P0);
        }
    }
}
