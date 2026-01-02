using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedStrategy.Grid
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position Move(int dx, int dy)
        {
            return new Position(X + dx, Y + dy);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
