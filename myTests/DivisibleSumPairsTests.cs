using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;

using Challenges;

namespace myTests
{
    public class TestDataDSPGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new int[] {1,3,2,6,1,2}, 6,3, 5},
            new object[] {new int[] {1,2,3,4,5,6}, 6,5, 3}

        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class DivisibleSumPairsTests
    {
        [Theory]
        [ClassData(typeof(TestDataDSPGenerator))]
        public void Test1(int[] ar, int n, int k, int result)
        {
            int actualResult = DivisibleSumPairs.GetPairCount(ar,n,k);

            Assert.Equal(result, actualResult);
        }
    }
}
