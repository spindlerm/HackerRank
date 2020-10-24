using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;

using Challenges;

namespace myTests
{
    public class TestDataCLBGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new List<int>{100}, new List<int> {101}, new List<int> {1}},
            new object[] {new List<int>{100}, new List<int> {90}, new List<int> {2}},
            new object[] {new List<int>{100,90,90,80,75,60}, new List<int> {50,65,77,90,102}, new List<int> {6,5,4,2,1}}

        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class ClimbingLeaderBoardTests
    {
        [Theory]
        [ClassData(typeof(TestDataCLBGenerator))]
        public void CalculateRanks_slow(List<int> ranked, List<int> player, List<int> result)
        {
            List<int> actualResult = ClimbingLeaderBoard.Calculate_slow(ranked, player);

            Assert.Equal(result, actualResult);
        }

        [Theory]
        [ClassData(typeof(TestDataCLBGenerator))]
        public void CalculateRanks_efficient(List<int> ranked, List<int> player, List<int> result)
        {
            List<int> actualResult = ClimbingLeaderBoard.Calculate_efficient(ranked, player);

            Assert.Equal(result, actualResult); 
        }
    }
}
