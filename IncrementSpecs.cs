using System.Reflection.Metadata;

namespace ScrumSimulator
{
    [TestClass]
    public sealed class IncrementSpecs
    {

        [TestMethod]
        public void HasBeenTested()
        {
            //Arrange
            bool hasBeenTested = false;
            Increment increment = new Increment();

            //Act
            hasBeenTested = increment.HasBeenTested;

            //Assert
            Assert.IsTrue(hasBeenTested);
        }

        [TestMethod]
        public void TheAutomatedTestMustPass()
        {
            //Arrange
            bool automatedTestsPass = false;
            Increment increment = new Increment();

            //Act
            automatedTestsPass = increment.AutomatedTestsPassed;

            //Assert
            Assert.IsTrue(automatedTestsPass);
        }

        [TestMethod]
        public void IncrementShouldHaveDoD()
        {
            //Arrange
            Increment increment;

            //Act
            increment = new Increment();

            //Assert
            Assert.IsNotNull(increment.GetDoD());
        }

        [TestMethod]
        public void DefinitionOfDoneHasFormalDescription()
        {
            //Arrange
            Increment increment;

            //Act
            increment = new Increment();
            DefinitionOfDone definition = increment.GetDoD();
            List<bool> formalDescription = definition.GetQualityMeasures();

            //Assert
            Assert.IsTrue(formalDescription.Count >=1);
        }

        [TestMethod]
        public void CanSetDefinitionOfDone()
        {
            //Arrange
            Increment increment;

            //Act
            increment = new Increment();
            DefinitionOfDone definition = increment.GetDoD();

            bool codeCoverageFromAutomatedTestMustBeAtLeast70Percent = false;
            bool manuallyTestedInUAT = false;
            bool automatedTestCasesMustPass = false;

            definition.Add(codeCoverageFromAutomatedTestMustBeAtLeast70Percent);
            definition.Add(manuallyTestedInUAT);
            definition.Add(automatedTestCasesMustPass);
            List<bool> formalDescription = definition.GetQualityMeasures();

            //Assert
            Assert.IsTrue(formalDescription.Count ==3);
        }

        [TestMethod]
        public void IncrementIsUsableWhenDoDMet()
        {
            //Arrange
            Increment increment = new Increment();

            //Act
            DefinitionOfDone dod = increment.GetDoD();
            bool codeCoverageFromAutomatedTestMustBeAtLeast70Percent = false;
            DefinitionOfDone definition = increment.GetDoD();
            definition.Add(codeCoverageFromAutomatedTestMustBeAtLeast70Percent);
            List<bool> formalDescription = definition.GetQualityMeasures();

            //Assert
            Assert.IsTrue(increment.Usable());
        }

    }
}
