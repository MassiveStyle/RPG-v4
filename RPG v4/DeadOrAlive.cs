using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class DeadOrAlive
    {
        private Character character;
        private Enemy enemy;

        public DeadOrAlive(Character character, Enemy enemy)
        {
            this.character = character;
            this.enemy = enemy;
        }


        public void IsDeadOrAlive()
        {
            if (character.hp > 0)
            {
                Console.WriteLine($"Glückwunsch du hast {enemy.EnemyType} besiegt! Du erhählst {enemy.xpWorth} Erfahrungspunkte!");
                character.xpCurrent += enemy.xpWorth;
            }
            else
            {
                Console.WriteLine($"Game Over! {enemy.EnemyType} hat dich leider getötet...");
            }
        }
    }
}
