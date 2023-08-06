using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class Menu
    {
        private Battle battle;
        private StatScreen statScreen;
        string menuChoice = "";

        public Menu(Battle battle, StatScreen statScreen) 
        {
            this.battle = battle;
            this.statScreen = statScreen;
        }

        public void MainMenu()
        {

            while ((menuChoice != "1") && (menuChoice != "3"))
            {
                Console.WriteLine("1. Kämpfen, 2. Statuswerte ansehen, 3. Beenden");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        {
                            battle.BattleStart();
                        }
                        break;

                    case "2":
                        {
                            statScreen.StatInfoScreen();
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Danke fürs Spielen!");
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Bitte wähle eine gültige Option");
                        }
                        break;
                }
            }
            menuChoice = "";
        }
    }
}
