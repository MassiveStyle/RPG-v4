using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class SkillPointDestribution
    {
        private Character character;

        public SkillPointDestribution(Character character)
        { this.character = character; }


        public void Destribution()
        {
            while (character.skillPoints > 0)
            {
                Console.WriteLine($"In was möchtest du deine Punkte investieren?\n" +
                                  $"(1) Stärke : {character.str}, (2) Konstitution : {character.con}, (3) Geschicklichkeit : {character.dex}, (4) Schnelligkeit : {character.quick}");
                string destributionChoice = Console.ReadLine();

                switch (destributionChoice)
                {
                    case "1":
                        {
                            Console.WriteLine("Wieviele Punkte möchtest du investieren? ");
                            string destributionAmmount = Console.ReadLine();

                            switch (destributionAmmount)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Du erhöhst deine Stärke um 1");
                                        character.str++;
                                        character.skillPoints--;
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.WriteLine("Du erhöhst deine Stärke um 2");
                                        character.str += 2;
                                        character.skillPoints -= 2;
                                    }
                                    break;

                                case "3":
                                    {
                                        Console.WriteLine("Du erhöhst deine Stärke um 3");
                                        character.str += 3;
                                        character.skillPoints += 3;
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Gib bitte einen Wert zwischen 1 und 3 an");
                                    }
                                    break;
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Wieviele Punkte möchtest du investieren? ");
                            string destributionAmmount = Console.ReadLine();

                            switch (destributionAmmount)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Du erhöhst deine Konstitution um 1");
                                        character.con++;
                                        character.skillPoints--;
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.WriteLine("Du erhöhst deine Konstitution um 2");
                                        character.con += 2;
                                        character.skillPoints -= 2;
                                    }
                                    break;

                                case "3":
                                    {
                                        Console.WriteLine("Du erhöhst deine Konstitution um 3");
                                        character.con += 3;
                                        character.skillPoints -= 3;
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Gib bitte einen Wert zwischen 1 und 3 an");
                                    }
                                    break;
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Wieviele Punkte möchtest du investieren? ");
                            string destributionAmmount = Console.ReadLine();

                            switch (destributionAmmount)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Du erhöhst deine Geschicklichkeit um 1");
                                        character.dex++;
                                        character.skillPoints--;
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.WriteLine("Du erhöhst deine Geschicklichkeit um 2");
                                        character.dex += 2;
                                        character.skillPoints -= 2;
                                    }
                                    break;

                                case "3":
                                    {
                                        Console.WriteLine("Du erhöhst deine Geschicklichkeit um 3");
                                        character.dex += 3;
                                        character.skillPoints -= 3;
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Gib bitte einen Wert zwischen 1 und 3 an");
                                    }
                                    break;
                            }
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Wieviele Punkte möchtest du investieren? ");
                            string destributionAmmount = Console.ReadLine();

                            switch (destributionAmmount)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("Du erhöhst deine Schnelligkeit um 1");
                                        character.quick++;
                                        character.skillPoints--;
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.WriteLine("Du erhöhst deine Schnelligkeit um 2");
                                        character.quick += 2;
                                        character.skillPoints -= 2;
                                    }
                                    break;

                                case "3":
                                    {
                                        Console.WriteLine("Du erhöhst deine Schnelligkeit um 3");
                                        character.quick += 3;
                                        character.skillPoints -= 3;
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Gib bitte einen Wert zwischen 1 und 3 an");
                                    }
                                    break;
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Wähle bitte eine gültige Option");
                        }
                        break;
                }
            }
        }
    }
}
