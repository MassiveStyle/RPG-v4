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
        private Enemy enemy;
        string battleChoice = "";

        public BattleTurnCharacter(Character character, Enemy enemy)
        {
            this.character = character;
            this.enemy = enemy;
        }

        public void TurnCharacter()
        {
            while ((battleChoice != "1") && (battleChoice != "5"))
            {
                Console.WriteLine("Was möchtest du tun? 1. Angreifen, 2. Fähigkeit benutzen, 3. Blocken, 4. Statuswerte ansehen, 5. Flüchten");
                battleChoice = Console.ReadLine();

                switch (battleChoice)
                {
                    case "1":
                        {
                            Console.WriteLine($"Du greifst {enemy.EnemyType} an und richtest {character.atk} Schaden an!\n");
                            enemy.hp = enemy.hp - character.atk;
                            Console.WriteLine($"{enemy.EnemyType} hat noch {enemy.hp} Leben.");

                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Du benutzt eine fähigkeit");
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Stats ansehen");
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Blocken");
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine("Flüchten");
                        }
                        break;


                    default:
                        {
                            Console.WriteLine("Wähle eine gültige Option");
                        }
                        break;
                }

            }
            battleChoice = "";
        }
    }
}
