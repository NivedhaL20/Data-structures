using BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void TestWithNoResult()
        {
            int[] array =  { 1, 2, 3, 4, 5 };
            int n = array.Length;
            int elementToFind = 10; // element is not present in array
            
            int index = Program.binarySearch(array, 0, n - 1, elementToFind);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestWithExactMidElement()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;
            int elementToFind = 3; //array[2]
            
            int index = Program.binarySearch(array, 0, n - 1, elementToFind);
            Assert.AreEqual(2, index);
        }

        [TestMethod]
        public void TestWithLeftElement()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;
            int elementToFind = 1; // array[0]
            
            int index = Program.binarySearch(array, 0, n - 1, elementToFind);
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void TestWithRightElement()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;
            int elementToFind = 5; // array[4]
           
            int index = Program.binarySearch(array, 0, n - 1, elementToFind);
            Assert.AreEqual(4, index);
        }
    }
}
