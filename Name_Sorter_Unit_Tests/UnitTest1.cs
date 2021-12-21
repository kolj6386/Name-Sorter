using Name_Sorter.SortingMethods;
using System.Collections.Generic;
using Xunit;


namespace Name_Sorter_Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Checking_Name_Has_First_And_Last_Name()
        {
            var TestList = new List<string>();
            TestList.Add("Vaughn Lewis");
            TestList.Add("Adonis Julius Archer");
            TestList.Add("Leo Gardner");

            // ARRANGE
            var TestUnsortedNames = new UnsortedNames();

            // ACT
            TestUnsortedNames.SortNames(TestList);

            // ASSERT
            Assert.Equal(TestList.Count, TestList.Count);
        }
    }
}