using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class CharacterAttacks
    {
        private Character character;
        private Enemy enemy;
        private Random random = new Random();
        private double randomSkill1Mod;
        public double dmg;
        public CharacterAttacks(Character character, Enemy enemy)
        {
            this.character = character;
            this.enemy = enemy;
        }
        public void StandardAttack()
        {
            switch (character.classType)
            {
                case "Krieger":
                    {
                        dmg = Math.Round(character.atk + character.str * 0.35);
                        enemy.hp = enemy.hp - dmg;
                    }
                    break;

                case "Jäger":
                    {
                        dmg = Math.Round(character.atk + character.dex * 0.35);
                        enemy.hp = enemy.hp - dmg;
                    }
                    break;
            }

        }

        public void Skill1()
        {
            switch (character.classType)
            {
                case "Krieger":
                    {
                        randomSkill1Mod = random.Next(2, 4);
                        dmg = Math.Round(character.atk + (character.str * 0.35) + randomSkill1Mod);
                        enemy.hp = enemy.hp - dmg;
                    }
                    break;

                case "Jäger":
                    {
                        randomSkill1Mod = random.Next(2, 4);
                        dmg = Math.Round(character.atk + (character.dex * 0.35) + randomSkill1Mod);
                        enemy.hp = enemy.hp - dmg;
                    }
                    break;

            }

        }
    }
}
