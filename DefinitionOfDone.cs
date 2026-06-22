


namespace ScrumSimulator
{
    public class DefinitionOfDone
    {
        List<bool> qualityChecklist;
        bool _isMet = false;

        public bool IsMet
        {
            get {
                _isMet = true;
                foreach (bool criteria in qualityChecklist)
                { if (criteria == false)
                        _isMet = false;
                }
                return _isMet;
            }
          }

        internal void Add(bool codeCoverageFromAutomatedTestMustBeAtLeast70Percent)
        {
            throw new NotImplementedException();
        }

        internal List<bool> GetQualityMeasures()
        {
            return new List<bool>() {true};
        }
    }
}