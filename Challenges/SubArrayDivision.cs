using System;
using System.Collections.Generic;

namespace Challenges
{
/* Given a chocolate bar, two children, Lily and Ron, are determining how to share it. Each of the squares has an integer on it.

Lily decides to share a contiguous segment of the bar selected such that:

The length of the segment matches Ron's birth month, and,
The sum of the integers on the squares is equal to his birth day.
You must determine how many ways she can divide the chocolate.

Consider the chocolate bar as an array of squares, . She wants to find segments summing to Ron's birth day,  with a length equalling his birth month, . In this case, there are two segments meeting her criteria:  and .

Function Description

Complete the birthday function in the editor below. It should return an integer denoting the number of ways Lily can divide the chocolate bar.

birthday has the following parameter(s):

s: an array of integers, the numbers on each of the squares of chocolate
d: an integer, Ron's birth day
m: an integer, Ron's birth month
Input Format

The first line contains an integer , the number of squares in the chocolate bar.
The second line contains  space-separated integers , the numbers on the chocolate squares where .
The third line contains two space-separated integers,  and , Ron's birth day and his birth month.

Constraints

, where ()
Output Format

Print an integer denoting the total number of ways that Lily can portion her chocolate bar to share with Ron.

Sample Input 0

5
1 2 1 3 2
3 2
Sample Output 0

2
*/

    public class SubArrayDivision
    {
        public  SubArrayDivision()
        {

        }
        public static int birthday(List<int> s, int d, int m){

            int slen = s.Count;

            if(slen < m)
                return 0;

            int validSegments = 0;
            int segmentSum =0;  
            
            for (int i =0; i < slen ; i++){

                segmentSum = 0;
                if(i+m <= slen)
                {
                    for (int x = i;  x < i+m; x++){
                    
                        segmentSum = segmentSum + s[x];
                    }

                    if(segmentSum == d)
                        validSegments++;
                }
            }


            return validSegments;
        }
    }
}
