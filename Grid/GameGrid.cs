using System;
using System.Collections.Generic;
using System.Text;

using TurnBasedStrategy.Entities;

namespace TurnBasedStrategy.Grid
{
    public class GameGrid
    {
        public int Width { get; }
        public int Height { get; }

        private Unit?[,] cells;

        public GameGrid(int width, int height)
        {
            Width = width;
            Height = height;
            cells = new Unit[width, height];
        }

        public bool IsInside(Position position)
        {
            return position.X >= 0 && position.X < Width &&
                   position.Y >= 0 && position.Y < Height;
        }

        public bool IsEmpty(Position position)
        {
            return IsInside(position) && cells[position.X, position.Y] == null;
        }

        public void PlaceUnit(Unit unit, Position position)
        {
            if (!IsEmpty(position))
                throw new InvalidOperationException("Cell is not empty.");

            unit.Position = position;
            cells[position.X, position.Y] = unit;
        }

        public void MoveUnit(Unit unit, Position newPosition)
        {
            if (!IsEmpty(newPosition))
                throw new InvalidOperationException("Target cell is not empty.");

            cells[unit.Position.X, unit.Position.Y] = null;
            unit.Position = newPosition;
            cells[newPosition.X, newPosition.Y] = unit;
        }
    }
}

