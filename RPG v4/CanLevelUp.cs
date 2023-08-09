using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class CanLevelUp
    {
        private Character character;
        private SkillPointDestribution skillPointDestribution;

        public CanLevelUp(Character character, SkillPointDestribution skillPointDestribution)
        {
            this.character = character;
            this.skillPointDestribution = skillPointDestribution;
        }

        public void LevelUp()
        {
            if (character.xpCurrent >= character.xpTreshold)
            {
                Console.WriteLine("Herzlichen Glückwunsch! Du bist ein Level aufgestiegen!\nDu erhählst 3 Skillpunkte zum verteilen.");
                character.level++;
                character.xpCurrent = 0;
                character.xpTreshold *= 2;
                character.skillPoints += 3;
                skillPointDestribution.Destribution();
                character.hpMax = Math.Round(character.hpMax + character.con * 1.25);
                character.hp = character.hpMax;
            }
        }
    }
}
