namespace Chain_Of_Responsibility
{
    public class Major : AbstractHandler
    {
        public override object Handle(Problem problem)
        {
            if (problem.Complicacy >= 11 && problem.Complicacy <= 100)
            {
                return $"Major managed {problem.Description} problem of {problem.Complicacy} complicacy";
            }
            else
            {
                return base.Handle(problem);
            }
        }

    }
}

