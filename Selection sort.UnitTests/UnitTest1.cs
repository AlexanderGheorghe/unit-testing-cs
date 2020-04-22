using System.Collections.Immutable;
using NUnit.Framework;

namespace Selection_sort.UnitTests
{
    public class SortTests
    {
        [Test]
        public void EquivalencePartitioning()
        {
            int[] EmptyArray = {};
            int[] ZeroArray = {0};
            int[] MultipleArray = {2, 1, 3};

            Program.Sort(EmptyArray);
            Assert.AreEqual(new int[] { }, EmptyArray);

            Program.Sort(EmptyArray, false);
            Assert.AreEqual(new int[] { }, EmptyArray);

            Program.Sort(ZeroArray);
            Assert.AreEqual(new [] {0}, ZeroArray);

            Program.Sort(ZeroArray, false);
            Assert.AreEqual(new [] {0}, ZeroArray);

            Program.Sort(MultipleArray);
            Assert.AreEqual(new [] {1, 2, 3}, MultipleArray);

            Program.Sort(MultipleArray, false);
            Assert.AreEqual(new [] {3, 2, 1}, MultipleArray);
        }
    }
}