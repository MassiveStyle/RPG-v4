using RPG_v4;

public class Rpg
{
    private static void Main(string[] args)
    {
        Character character = new Character();
        while (character.hp > 0)
        {
            LevelCheck levelCheck = new LevelCheck(character);
            Enemy enemy = new Enemy(levelCheck);
            CharacterAttacks characterAttacks = new CharacterAttacks(character, enemy);
            EnemyAttacks enemyAttacks = new EnemyAttacks(enemy, character);
            StatScreen statScreen = new StatScreen(character);
            Battle battle = new Battle(enemy, character);
            Menu menu = new Menu(battle, statScreen);
            BattleTurnCharacter battleTurnCharacter = new BattleTurnCharacter(character, enemy, characterAttacks, statScreen, menu);
            BattleTurnEnemy battleTurnEnemy = new BattleTurnEnemy(enemy, character, enemyAttacks);
            BattlePhase battlePhase = new BattlePhase(character, enemy, battleTurnCharacter, battleTurnEnemy);
            DeadOrAlive deadOrAlive = new DeadOrAlive(character, enemy);
            SkillPointDistribution skillPointDestribution = new SkillPointDistribution(character);
            CanLevelUp canLevelUp = new CanLevelUp(character, skillPointDestribution);

            menu.MainMenu();
            battlePhase.BattleRounds();
            deadOrAlive.IsDeadOrAlive();
            canLevelUp.LevelUp();
        }
        Environment.Exit(0);
    }
}