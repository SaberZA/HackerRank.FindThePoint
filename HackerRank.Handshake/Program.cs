using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Handshake
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Convert.ToInt32(System.Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var numberLine = System.Console.ReadLine();
                var maximumDrawsProblem = new HandshakeProblem(numberLine);
                var result = maximumDrawsProblem.Solve();

                System.Console.WriteLine(result);
            }
        }
    }

    public interface IProblem<T>
    {
        T Solve();
    }

    public class HandshakeProblem : IProblem<string>
    {
        private int _directors;

        public HandshakeProblem(string numberLine)
        {
            _directors = Convert.ToInt32(numberLine);
        }

        public string Solve()
        {
            return (_directors / 2).ToString();
        }
    }
}
