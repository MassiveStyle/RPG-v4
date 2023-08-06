using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class BattlePhase
    {
        private Character character;
        private Enemy enemy;
        private BattleTurnCharacter battleTurnCharacter;
        private BattleTurnEnemy battleTurnEnemy;
        public int round;

        public BattlePhase(Character character, Enemy enemy, BattleTurnCharacter battleTurnCharacter, BattleTurnEnemy battleTurnEnemy)
        {
            this.character = character;
            this.enemy = enemy;
            this.battleTurnCharacter = battleTurnCharacter;
            this.battleTurnEnemy = battleTurnEnemy;
        }

        public void BattleRounds()
        {
            while (character.hp > 0 && enemy.hp > 0)
            {
                if ((character.turn) && (round % 2 == 0))
                {
                    battleTurnCharacter.TurnCharacter();
                    round++;
                }
                else
                {
                    battleTurnEnemy.TurnEnemy();
                    round++;
                }

            }
            round = 0;
        }
    }
}
