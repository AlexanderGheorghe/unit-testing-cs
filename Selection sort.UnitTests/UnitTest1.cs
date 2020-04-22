using NUnit.Framework;

namespace Selection_sort.UnitTests
{
    public class SortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EquivalencePartitioning()
        {
            Assert.AreEqual(Program.Sort());
        }
    }
}