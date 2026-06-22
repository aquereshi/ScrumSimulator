using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumSimulator
{
    [TestClass]
    public class SprintGoalSpecs
    {
        [TestMethod]
        public void SprintHasADefinitionOfDone()
        {
            //Arrange
            bool sprintHasADefinitionOfDone = false;
            Sprint sprint = new Sprint();

            //Act
            sprintHasADefinitionOfDone = sprint.HasDefinitionOfDone;

            //Assert
            Assert.IsTrue(sprintHasADefinitionOfDone);
        }

        [TestMethod]
        public void SprintGoalCommunicatesValue()
        {
            //Arrange
            string sprintGoal;
            Sprint sprint = new Sprint();

            //Act
            sprintGoal = sprint.GetGoal;

            //Assert
            Assert.IsTrue(sprintGoal.Contains("so that")); //Why
        }

        [TestMethod]
        public void SprintGoalMustBeFinalizedByEndOfSprintPlanning()
        {
            //Arrange
            SprintPlanning planning;
            Sprint sprint = new();

            //Act
            planning = sprint.GetPlanning;
            planning.End();
            string sprintGoal = sprint.GetGoal;


            //Assert
            Assert.IsNotNull(sprintGoal);

        }


        [TestMethod]
        public void TheSprintInitiatesSprintPlanning()
        {
            //Arrange
            SprintPlanning planning;
            Sprint sprint = new Sprint();

            //Act
            planning = sprint.GetPlanning;


            //Assert
            Assert.IsNotNull(planning);

        }
    }
}
