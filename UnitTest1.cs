using NUnit.Framework;
using TargetProject;
namespace Test
{
    [TestFixture]
    public class Tests
    {
        Problem tester = new Problem();
    
        [Test]
        public void EquivalencePartitioning()
        {
            Assert.AreEqual(-2, tester.function(0, 0, 28, "subtract"));
            Assert.AreEqual(-2, tester.function(0, 5, 28, "add"));
            Assert.AreEqual(-2, tester.function(5, 0, 28, "subtract"));
            Assert.AreEqual(-1, tester.function(5, 4, 28, "divid"));
            Assert.AreEqual(5, tester.function(5, 4, 28, "divide"));
            Assert.AreEqual(-1, tester.function(5, 4, 27, "divide"));
        }

        [Test]
        public void BoundaryValues()
        {
            Assert.AreEqual(-2, tester.function(0, 0, 28, "subtract"));
            Assert.AreEqual(-2, tester.function(0, 5, 28, "add"));
            Assert.AreEqual(-2, tester.function(5, 0, 28, "subtract"));
            Assert.AreEqual(-1, tester.function(1, 1, 28, "multiply"));
            Assert.AreEqual(4, tester.function(7, 4, 28, "divide"));
        }

        [Test]
        public void CategoryPartitioning()
        {
            Assert.AreEqual(-2, tester.function(-2, -3, 28, "subtract"));
            Assert.AreEqual(-2, tester.function(0, 0, 28, "subtract"));
            Assert.AreEqual(-2, tester.function(0, 5, 28, "subtract"));
            Assert.AreEqual(-2, tester.function(5, 0, 28, "subtract"));
            Assert.AreEqual(-1, tester.function(1, 1, 28, "subtract"));
            Assert.AreEqual(35, tester.function(7, 4, 28, "add"));
            Assert.AreEqual(21, tester.function(7, 4, 28, "subtract"));
            Assert.AreEqual(196, tester.function(7, 4, 28, "multiply"));
            Assert.AreEqual(4, tester.function(7, 4, 28, "divide"));
            Assert.AreEqual(-1, tester.function(7, 4, 27, "add"));
        }

        [Test]
        public void StatementCoverage()
        {
            Assert.AreEqual(-2, tester.function(0, 0, 20, "subtract"));
            Assert.AreEqual(13, tester.function(7, 4, 6, "add"));
            Assert.AreEqual(21, tester.function(7, 4, 28, "subtract"));
            Assert.AreEqual(196, tester.function(7, 4, 28, "multiply"));
            Assert.AreEqual(4, tester.function(7, 4, 28, "divide"));
            Assert.AreEqual(-1, tester.function(7, 4, 28, "dividde"));
            Assert.AreEqual(-1, tester.function(7, 4, 27, "add"));
        }

        [Test]
        public void BranchCoverage()
        {
            Assert.AreEqual(-2, tester.function(0, 0, 20, "subtract"));
            Assert.AreEqual(35, tester.function(7, 4, 28, "add"));
            Assert.AreEqual(21, tester.function(7, 4, 28, "subtract"));
            Assert.AreEqual(42, tester.function(7, 4, 6, "multiply"));
            Assert.AreEqual(4, tester.function(7, 4, 28, "divide"));
            Assert.AreEqual(-1, tester.function(7, 4, 28, "dividde"));
            Assert.AreEqual(-1, tester.function(7, 4, 27, "add"));
        }

        [Test]
        public void ConditionCoverage()
        {
            Assert.AreEqual(-2, tester.function(0, 0, 20, "subtract"));
            Assert.AreEqual(-2, tester.function(0, 5, 20, "subtract"));
            Assert.AreEqual(-2, tester.function(5, 0, 20, "subtract"));
            Assert.AreEqual(13, tester.function(7, 4, 6, "add"));
            Assert.AreEqual(21, tester.function(7, 4, 28, "subtract"));
            Assert.AreEqual(196, tester.function(7, 4, 28, "multiply"));
            Assert.AreEqual(4, tester.function(7, 4, 28, "divide"));
            Assert.AreEqual(-1, tester.function(7, 4, 28, "dividde"));
            Assert.AreEqual(-1, tester.function(7, 4, 27, "add"));
            Assert.AreEqual(-1, tester.function(1, 1, 27, "addd"));
        }

        [Test]
        public void KillMutants()
        {
            Assert.AreEqual(8, tester.function(1, 4, 6, "add"));
        }

    }
}


