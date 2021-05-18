/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            IScoreHouse h1 = new ScoreHouse();
            IScoreHouse h2 = new ScoreHouse();
            Player one = new Player("Player 1", h1);
            Player two = new Player("Player 2", h2);
            Board b = new Board(one, two);
            // rest left as exercise to reader!
        }
    }
}
