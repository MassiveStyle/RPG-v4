using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class StatScreen
    {
        private Character character;

        public StatScreen(Character character)
        {
            this.character = character;
        }

        public void StatInfoScreen()
        {
            Console.WriteLine($"HP: {character.hp}, Stärke: {character.str}, Konstitution: {character.con}, " +
                              $"Geschicklichkeit: {character.dex}, Schnelligkeit: {character.quick}\n" +
                              $"Angriffskraft: {character.atk}, Verteidigung: {character.def}\n" +
                              $"Erfahrungspunkte: {character.xpCurrent}, Bis zum nächsten Level: {character.xpTreshold - character.xpCurrent}, " +
                              $"Level: {character.level}\n");
        }
    }
}
