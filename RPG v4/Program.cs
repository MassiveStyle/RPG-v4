using RPG_v4;

public class Rpg
{
    private static void Main(string[] args)
    {
        Character character = new Character();
        while (character.hp > 0)
        {
            Enemy enemy = new Enemy();
            StatScreen statScreen = new StatScreen(character);
            BattleTurnCharacter battleTurnCharacter = new BattleTurnCharacter(character, enemy);
            BattleTurnEnemy battleTurnEnemy = new BattleTurnEnemy(enemy, character);
            BattlePhase battlePhase = new BattlePhase(character, enemy, battleTurnCharacter, battleTurnEnemy);
            Battle battle = new Battle(enemy, character);
            Menu menu = new Menu(battle, statScreen);
            DeadOrAlive deadOrAlive = new DeadOrAlive(character, enemy);
            SkillPointDestribution skillPointDestribution = new SkillPointDestribution(character);
            CanLevelUp canLevelUp = new CanLevelUp(character, skillPointDestribution);


            menu.MainMenu();
            battlePhase.BattleRounds();
            deadOrAlive.IsDeadOrAlive();
            canLevelUp.LevelUp();
        }
        Environment.Exit(0);
    }
}