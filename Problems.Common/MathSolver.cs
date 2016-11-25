namespace Problems.Common
{
    public class MathSolver 
    {
        public T Solve<T>(IProblem<T> problem)
        {
            return problem.Solve();
        }
    }
}