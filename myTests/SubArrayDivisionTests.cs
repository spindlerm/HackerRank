using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;

using Challenges;

namespace myTests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new List<int>{4},4,1,1},
            new object[] {new List<int>{1,2,1,3,2},3,2,2}

        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class SubArrayDivisionTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Test1(List<int> s, int d, int m, int result)
        {
            int actualResult = SubArrayDivision.birthday(s,d,m);

            Assert.Equal(result, actualResult);
        }
    }
}
