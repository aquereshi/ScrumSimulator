namespace ScrumSimulator
{
    internal class Sprint
    {
        string goal = "Make Toast so that we can have breakfast";
        SprintPlanning planning;

        public Sprint()
        {
            planning = new SprintPlanning();
        }

        public string GetGoal
        {
            get { return goal; }
        }

        public SprintPlanning GetPlanning 
        {
            get { return planning; } 
        }

        public bool HasDefinitionOfDone { get; } = true;
    }
}