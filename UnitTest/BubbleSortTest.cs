using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BubbleSort;

namespace UnitTest
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void SortNumbers_AscendingOrder_ReturnsIndexNumber()
        {
            int[] array = { 91, 90, 34, 9, 4 };            

            int[] sortedArray = BubbleSortExercise.BubbleSort(array);
            
            Assert.AreEqual(4, sortedArray[0]);
        }
    }
}
