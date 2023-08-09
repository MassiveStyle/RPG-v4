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
        private EnemyAttacks enemyAttacks;

        public BattleTurnEnemy(Enemy enemy, Character character, EnemyAttacks enemyAttacks)
        {
            this.enemy = enemy;
            this.character = character;
            this.enemyAttacks = enemyAttacks;
        }

        public void TurnEnemy()
        {
            if (!character.block)
            {
                enemyAttacks.Attacks();
                Console.WriteLine($"{enemy.EnemyType} greift dich an und richtet {enemyAttacks.dmg} Schaden an.");
                Console.WriteLine($"Du hast noch {character.hp} Leben.");

            }
            else
            {
                enemyAttacks.Attacks();
                Console.WriteLine($"{enemy.EnemyType} greift dich an und richtet {enemyAttacks.dmg} Schaden an.");
                Console.WriteLine($"Du hast noch {character.hp} Leben.");
                character.block = false;
            }
        }
    }
}
