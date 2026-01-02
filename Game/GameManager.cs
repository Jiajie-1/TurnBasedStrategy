using System;
using TurnBasedStrategy.AI;
using TurnBasedStrategy.Entities;
using TurnBasedStrategy.Grid;
using TurnBasedStrategy.Rules;

namespace TurnBasedStrategy.Game
{
    public class GameManager
    {
        public GameGrid Grid { get; }
        public Player Player { get; }
        public Enemy Enemy { get; }
        public TurnManager TurnManager { get; }

        private SimpleAI ai;

        public GameManager()
        {
            Grid = new GameGrid(5, 5);

            Player = new Player();
            Enemy = new Enemy();

            TurnManager = new TurnManager();
            ai = new SimpleAI();

            // Initial placement
            Grid.PlaceUnit(Player, new Position(1, 1));
            Grid.PlaceUnit(Enemy, new Position(1, 3));


            TurnManager.StartGame();
        }

        public void Update()
        {
            if (TurnManager.CurrentState == GameState.GameOver)
            {
                Console.WriteLine("Game Over");
                return;
            }

            if (TurnManager.CurrentState == GameState.PlayerTurn)
            {
                Console.WriteLine("Player turn");

                if (RuleValidator.CanAttack(Player, Enemy))
                {
                    Player.Attack(Enemy);
                    Console.WriteLine("Player attacks enemy! Enemy HP: " + Enemy.HP);
                }
                else
                {
                    Console.WriteLine("Player cannot attack.");
                }

                if (!Enemy.IsAlive)
                {
                    TurnManager.EndGame();
                    Console.WriteLine("Enemy defeated!");
                    return;
                }

                TurnManager.EndPlayerTurn();
                return;
            }

            if (TurnManager.CurrentState == GameState.EnemyTurn)
            {
                Console.WriteLine("Enemy turn");

                ai.TakeTurn(Grid, Enemy, Player);

                Console.WriteLine("Enemy position: " + Enemy.Position);
                Console.WriteLine("Player HP: " + Player.HP);

                if (!Player.IsAlive)
                {
                    TurnManager.EndGame();
                    Console.WriteLine("Player defeated!");
                    return;
                }

                TurnManager.EndEnemyTurn();
            }
        }
    }
}
