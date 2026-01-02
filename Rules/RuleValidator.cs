using System;
using System.Collections.Generic;
using System.Text;

using TurnBasedStrategy.Entities;
using TurnBasedStrategy.Grid;

namespace TurnBasedStrategy.Rules
{
    public static class RuleValidator
    {
        public static bool CanMove(GameGrid grid, Unit unit, Position target)
        {
            return grid.IsInside(target) && grid.IsEmpty(target);
        }

        public static bool CanAttack(Unit attacker, Unit target)
        {
            int dx = Math.Abs(attacker.Position.X - target.Position.X);
            int dy = Math.Abs(attacker.Position.Y - target.Position.Y);

            return dx + dy == 1; // adjacent cell
        }
    }
}
