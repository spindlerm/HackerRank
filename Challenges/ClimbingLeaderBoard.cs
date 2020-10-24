using System;
using System.Collections.Generic;

namespace Challenges
{
    /*
    An arcade game player wants to climb to the top of the leaderboard and track their ranking. The game uses Dense Ranking, so its leaderboard works like this:

The player with the highest score is ranked number  on the leaderboard.
Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.
Example



The ranked players will have ranks , , , and , respectively. If the player's scores are ,  and , their rankings after each game are ,  and . Return .

Function Description

Complete the climbingLeaderboard function in the editor below.

climbingLeaderboard has the following parameter(s):

int ranked[n]: the leaderboard scores
int player[m]: the player's scores
Returns

int[m]: the player's rank after each new score
Input Format

The first line contains an integer , the number of players on the leaderboard.
The next line contains  space-separated integers , the leaderboard scores in decreasing order.
The next line contains an integer, , the number games the player plays.
The last line contains  space-separated integers , the game scores.

Constraints

 for 
 for 
The existing leaderboard, , is in descending order.
The player's scores, , are in ascending order.
Subtask

For  of the maximum score:

Sample Input 1

CopyDownload
Array: ranked
100
100
50
40
40
20
10

 



Array: player
5
25
50
120

 
7
100 100 50 40 40 20 10
4
5 25 50 120
Sample Output 1

6
4
2
1
    */

    public class ClimbingLeaderBoard
    {
        /*
        * Complete the 'climbingLeaderboard' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. INTEGER_ARRAY ranked
        *  2. INTEGER_ARRAY player
        */        
        public static List<int> Calculate_slow(List<int> ranked, List<int> player)
        {
            List<int> results = new List<int>();

            foreach(int playerScore in player)
            {
                int rank = 1;
                int previousRankedPlayerScore = -1;
                foreach(int rankedPlayerScore in ranked)
                {
                    if (playerScore >= rankedPlayerScore)
                    {
                       
                        break;
                    }

                    if(previousRankedPlayerScore ==-1 || rankedPlayerScore != previousRankedPlayerScore)
                        rank++;

                    previousRankedPlayerScore = rankedPlayerScore;
                }

                 results.Add(rank);
            }

            return results;
        }

        public static List<int> Calculate_efficient(List<int> rankedPlayerScores, List<int> playerScores)
        {
            List<int> results = new List<int>();
            int rank = 0;
            int curPos = 0;
            int prevRankedScore = -1;
          

            for(int i = playerScores.Count-1; i >=0; i--)
            {
                while(curPos < rankedPlayerScores.Count && rankedPlayerScores[curPos] > playerScores[i])
                {
                    // Only up the rank if different to previous score
                    if(rankedPlayerScores[curPos]!= prevRankedScore)
                        rank++;  

                    //remember the previously ranked score
                    prevRankedScore = rankedPlayerScores[curPos];
                    curPos++;
                }

                if(playerScores[i] == prevRankedScore )
                    results.Insert(0,rank);
                else{
                    results.Insert(0,rank+1);
                }

            }
            return results;
            
        }
    }
}
