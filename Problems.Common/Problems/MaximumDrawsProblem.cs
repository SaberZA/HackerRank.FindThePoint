using System;
using Problems.Common;

namespace HackerRank.MaximumDraws.Test
{
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