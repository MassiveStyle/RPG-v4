using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class BattleTurnEnemy
    {
        private Enemy enemy;
        private Character character;

        public BattleTurnEnemy(Enemy enemy, Character character)
        {
            this.enemy = enemy;
            this.character = character;

        }

        public void TurnEnemy()
        {
            Console.WriteLine($"{enemy.EnemyType} greift dich an und richtet {enemy.atk} Schaden an.");
            character.hp = character.hp - enemy.atk;
            Console.WriteLine($"Du hast noch {character.hp} Leben.");
        }
    }
}
