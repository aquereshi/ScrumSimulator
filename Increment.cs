

namespace ScrumSimulator
{
    internal class Increment
    {
        private DefinitionOfDone DoD;

        public Increment()
        {
            DoD = new DefinitionOfDone();
        }

        public bool HasBeenTested { get; internal set; } = true;
        public bool AutomatedTestsPassed { get; internal set; } = true;

        internal DefinitionOfDone GetDoD()
        {
            return DoD;
        }

        internal bool Usable()
        {
            if (DoD.IsMet)
                return true;
            else
                return false;
        }
    }
}