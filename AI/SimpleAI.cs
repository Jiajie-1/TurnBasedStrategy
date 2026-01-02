using System;
using System.Collections.Generic;
using System.Text;

using TurnBasedStrategy.Entities;
using TurnBasedStrategy.Grid;
using TurnBasedStrategy.Rules;

namespace TurnBasedStrategy.AI
{
    public class SimpleAI
    {
        public void TakeTurn(GameGrid grid, Enemy enemy, Player player)
        {
            if (RuleValidator.CanAttack(enemy, player))
            {
                enemy.Attack(player);
                Console.WriteLine("Enemy attacks player!");
                return;
            }

            int dx = player.Position.X - enemy.Position.X;
            int dy = player.Position.Y - enemy.Position.Y;

            Position newPosition;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                newPosition = enemy.Position.Move(Math.Sign(dx), 0);
            }
            else
            {
                newPosition = enemy.Position.Move(0, Math.Sign(dy));
            }


            if (RuleValidator.CanMove(grid, enemy, newPosition))
            {
                grid.MoveUnit(enemy, newPosition);
                Console.WriteLine($"Enemy moves to {enemy.Position}");
            }
        }
    }
}
