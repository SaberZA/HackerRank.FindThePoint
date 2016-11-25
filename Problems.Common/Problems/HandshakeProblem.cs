using System;
using System.Numerics;

namespace Problems.Common.Problems
{
    public class HandshakeProblem : IProblem<string>
    {
        private int _directors;

        public HandshakeProblem(string numberLine)
        {
            _directors = Convert.ToInt32(numberLine);
        }

        public string Solve()
        {
            // Solve for the combination of directors vs handshake(2)
            // A difference in combinations... factorise dumbass
            return (_directors*(_directors - 1)/2).ToString();

        }
        
        
    }
    
}