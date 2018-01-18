using System;
using static System.Console;
using static System.Math;

namespace Lab1Task6
{
    static class Program
    {
        static void Main()
        {
            const int firstYear = 1800;
            const int lastYear = 2010;

            var MaltusCoef = MathExecutor.GetMaltusCoef(1800);
            var firstYearPopulation = (int)MathExecutor.GetPopulationByYear(firstYear);

            var FerhlustCoefM = -1934960;
            var FerhlustCoefR = -0.0141192;

            var x = (int)MathExecutor.GetPopulationByYear(2003);

            WriteLine("-------");
            WriteLine("Current year: " + firstYear);
            WriteLine($"Current population by formula: {firstYearPopulation}");
            WriteLine($"-------");

            for (int t = 1, year = firstYear + 1; year <= lastYear; t++, year++)
            {
                WriteLine("-------");
                WriteLine("Current year: " + year);
                var result = MathExecutor.GetPopulationByYear(year);

                var maltusResult = MathExecutor.Maltus(t, firstYearPopulation, MaltusCoef);
                var ferhlustResult = MathExecutor.Ferhlust(t, firstYearPopulation, FerhlustCoefM, FerhlustCoefR);

                WriteLine($"Maltus: {maltusResult:0}");

                WriteLine($"Ferhlust: {ferhlustResult:0}");

                WriteLine($"Maltus err: {MathExecutor.GetErr(result, maltusResult):0.00000}%");

                WriteLine($"Ferhlust err: {MathExecutor.GetErr(result, ferhlustResult):0.00000}%");
                
                WriteLine($"Fact: {result:0}");
                WriteLine("-------");
            }
        }
    }
}
