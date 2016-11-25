using System;

namespace Problems.Common.Problems
{
    public class FindThePointProblem : IProblem<string>
    {
        public Point2D Pq { get; set; }
        public Point2D Pp { get; set; }

        public FindThePointProblem(string numberLine)
        {
            var numbers = numberLine.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Pp = new Point2D(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
            Pq = new Point2D(Convert.ToInt32(numbers[2]), Convert.ToInt32(numbers[3]));
        }

        public string Solve()
        {
            var differenceX = Pq.X - Pp.X;
            var differenceY = Pq.Y - Pp.Y;

            var reflectionPoint = new Point2D(Pq.X + differenceX, Pq.Y + differenceY);

            return string.Format("{0} {1}", reflectionPoint.X, reflectionPoint.Y);
        }
    }
}