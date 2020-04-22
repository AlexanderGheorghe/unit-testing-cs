using NUnit.Framework;

namespace Selection_sort.UnitTests
{
    public class SortTests
    {
        private int[] Sort(int[] v, bool asc = true)
        {
            Program.Sort(v, asc);
            return v;
        }
        [Test]
        public void EquivalencePartitioning()
        {
            Assert.AreEqual(new [] { 1, 2, 3 }, Sort(new[] { 3, 1, 2 }));
            Assert.AreEqual(new [] { 3, 2, 1 }, Sort(new[] { 3, 1, 2 }, false));
        }
        [Test]
        public void BoundaryValueAnalysis()
        {
            Assert.AreEqual(new int[] { }, Sort(new int[] { }));
        }
        [Test]
        public void CategoryPartitioning()
        {
            Assert.AreEqual(new int[] { }, Sort(new int[] { }));
            Assert.AreEqual(new int[] { }, Sort(new int[] { }, false));
            Assert.AreEqual(new[] { 0 }, Sort(new[] { 0 }));
            Assert.AreEqual(new[] { 0 }, Sort(new[] { 0 }, false));
            Assert.AreEqual(new[] { 1, 2, 3 }, Sort(new[] { 3, 1, 2 }));
            Assert.AreEqual(new[] { 3, 2, 1 }, Sort(new[] { 3, 1, 2 }, false));
        }
    }
}