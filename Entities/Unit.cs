using System;
using System.Collections.Generic;
using System.Text;

using TurnBasedStrategy.Grid;

namespace TurnBasedStrategy.Entities
{
    public abstract class Unit
    {
        public int HP { get; protected set; }
        public Position Position { get; set; }

        protected Unit(int hp)
        {
            HP = hp;
        }

        public bool IsAlive => HP > 0;

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
}
