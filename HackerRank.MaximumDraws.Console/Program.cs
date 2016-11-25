using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank.MaximumDraws.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Convert.ToInt32(System.Console.ReadLine());
            
            for (int i = 0; i < lines; i++)
            {
                var numberLine = System.Console.ReadLine();
                var maximumDrawsProblem = new MaximumDrawsProblem(numberLine);
                var result = maximumDrawsProblem.Solve();
                
                System.Console.WriteLine(result);
            }
        }
    }

    public interface IProblem<T>
    {
        T Solve();
    }

    public class MaximumDrawsProblem : IProblem<string>
    {
        private readonly int _socks;

        public MaximumDrawsProblem(string socks)
        {
            _socks = Convert.ToInt32(socks);
        }

        public string Solve()
        {
            if (_socks == 0)
            {
                return "0";
            }

            return (_socks + 1).ToString();

        }
    }
}
