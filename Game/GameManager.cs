using System;
using System.Collections.Generic;
using System.Text;

using TurnBasedStrategy.Entities;
using TurnBasedStrategy.Grid;

namespace TurnBasedStrategy.Game
{
    public class GameManager
    {
        public GameGrid Grid { get; }
        public Player Player { get; }
        public Enemy Enemy { get; }
        public TurnManager TurnManager { get; }

        public GameManager()
        {
            Grid = new GameGrid(5, 5);
            Player = new Player();
            Enemy = new Enemy();
            TurnManager = new TurnManager();

            Grid.PlaceUnit(Player, new Position(1, 1));
            Grid.PlaceUnit(Enemy, new Position(3, 3));

            TurnManager.StartGame();
        }

        public void Update()
        {
            switch (TurnManager.CurrentState)
            {
                case GameState.PlayerTurn:
                    Console.WriteLine("Player turn");
                    TurnManager.EndPlayerTurn();
                    break;

                case GameState.EnemyTurn:
                    Console.WriteLine("Enemy turn");
                    TurnManager.EndEnemyTurn();
                    break;

                case GameState.GameOver:
                    Console.WriteLine("Game Over");
                    break;
            }
        }
    }
}
