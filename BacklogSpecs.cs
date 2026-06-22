namespace ScrumSimulator
{
    [TestClass]
    public sealed class BacklogSpecs
    {
        [TestMethod]
        public void BacklogItemHasSize()
        {
            //Arrange
            BacklogItem item = new BacklogItem();

            //Act
            int size = item.GetSize();

            //Assert
            Assert.IsFalse(String.IsNullOrEmpty(size.ToString()));
        }

        [TestMethod]
        public void SizeOfBacklogIsSumOfBacklogItemSizes()
        {
            //Arrange
            BacklogItem item1 = new BacklogItem();
            BacklogItem item2 = new BacklogItem();
            Backlog backlog = new Backlog();

            //Act
            backlog.Add(item1);
            backlog.Add(item2);
            int sumOfitems = item1.GetSize() + item2.GetSize();
                

            //Assert
            Assert.IsTrue(backlog.GetSize() == sumOfitems);
        }
    }
}
