using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Common;
using Problems.Common.Problems;

namespace HackerRank.FindThePoint.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathSolver = new MathSolver();
            var lines = Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var numberLine = System.Console.ReadLine();

                var result = mathSolver.Solve(new FindThePointProblem(numberLine));
                System.Console.WriteLine(result);
            }
        }
    }
}
