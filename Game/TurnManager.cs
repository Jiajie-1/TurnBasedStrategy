using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedStrategy.Game
{
    public class TurnManager
    {
        public GameState CurrentState { get; private set; }

        public TurnManager()
        {
            CurrentState = GameState.Start;
        }

        public void StartGame()
        {
            CurrentState = GameState.PlayerTurn;
        }

        public void EndPlayerTurn()
        {
            CurrentState = GameState.EnemyTurn;
        }

        public void EndEnemyTurn()
        {
            CurrentState = GameState.PlayerTurn;
        }

        public void EndGame()
        {
            CurrentState = GameState.GameOver;
        }
    }
}
