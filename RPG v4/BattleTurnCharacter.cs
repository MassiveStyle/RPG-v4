using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class BattleTurnCharacter
    {
        private Character character;
        private CharacterAttacks characterAttacks;
        private Enemy enemy;
        private StatScreen statScreen;
        private Menu menu;
        string battleChoice = string.Empty;

        public BattleTurnCharacter(Character character, Enemy enemy, CharacterAttacks characterAttacks, StatScreen statScreen, Menu menu)
        {
            this.character = character;
            this.enemy = enemy;
            this.characterAttacks = characterAttacks;
            this.statScreen = statScreen;
            this.menu = menu;
        }

        public void TurnCharacter()
        {
            do
            {
                Console.WriteLine("Was möchtest du tun? 1. Angreifen, 2. Fähigkeit benutzen, 3. Blocken, 4. Statuswerte ansehen, 5. Flüchten");
                battleChoice = Console.ReadLine();

                switch (battleChoice)
                {
                    case "1":
                        {
                            characterAttacks.StandardAttack();
                            Console.WriteLine($"Du greifst {enemy.EnemyType} an und richtest {characterAttacks.dmg} Schaden an!\n");
                            if (enemy.hp > 0)
                            {
                                Console.WriteLine($"{enemy.EnemyType} hat noch {enemy.hp} Leben.");
                            }
                            else
                            {
                                Console.WriteLine($"Du hast {enemy.EnemyType} getötet!");
                            }
                            

                        }
                        break;

                    case "2":
                        {
                            characterAttacks.Skill1();
                            Console.WriteLine($"Du greifst {enemy.EnemyType} an und richtest {characterAttacks.dmg} Schaden an!\n");
                            if (enemy.hp > 0)
                            {
                                Console.WriteLine($"{enemy.EnemyType} hat noch {enemy.hp} Leben.");
                            }
                            else
                            {
                                Console.WriteLine($"Du hast {enemy.EnemyType} getötet!");
                            }

                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine($"Du blockst denn nächsten Angriff und erleidest {character.def} weniger Schaden!");
                            character.block = true;
                        }
                        break;

                    case "4":
                        {

                            statScreen.StatInfoScreen();
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine("Du Flüchtest wie ein feigling zurück in die Stadt...");
                            menu.MainMenu();
                        }
                        break;


                    default:
                        {
                            Console.WriteLine("Wähle eine gültige Option");
                        }
                        break;
                }

            } while (battleChoice == "4");
            battleChoice = string.Empty;
        }
    }
}
