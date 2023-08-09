using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class Battle
    {
        private Enemy enemy;
        private Character character;
    
        public Battle(Enemy enemy, Character character)
        {
            this.enemy = enemy;
            this.character = character;
        }

        public void BattleStart()
        {
            Console.WriteLine($"Dein Gegner: {enemy.EnemyType}!");

            if (character.quick >= enemy.quick)
            {
                Console.WriteLine("Du greifst zuerst an!");
                character.turn = true;
            }
            else
            {
                Console.WriteLine($"{enemy.EnemyType} greift zuerst an!");   
                character.turn = false;
            }

        }
    }
}
