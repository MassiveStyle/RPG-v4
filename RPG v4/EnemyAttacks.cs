using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class EnemyAttacks
    {
        private Enemy enemy;
        private Character character;
        private Random skillChange = new Random();
        public double dmg;

        public EnemyAttacks(Enemy enemy, Character character)
        {
            this.enemy = enemy;
            this.character = character;
        }

        public void Attacks()
        {
            switch (enemy.EnemyType)
            {
                case "Goblin":
                    {
                        if (!character.block)
                        {
                            switch (skillChange.Next(1, 2))
                            {
                                case 1:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk + 3;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk + 3 - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;

                case "Spinne":
                    {
                        if (!character.block)
                        {
                            switch (skillChange.Next(1, 2))
                            {
                                case 1:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk + 2;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk + 2 - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;

                case "Wolf":
                    {
                        if (!character.block)
                        {
                            switch (skillChange.Next(1, 2))
                            {
                                case 1:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk + 4;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk + 4 - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;

                case "Bär":
                    {
                        if (!character.block)
                        {
                            switch (skillChange.Next(1, 2))
                            {
                                case 1:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk + 5;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk + 5 - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;

                case "Slime":
                    {
                        if (!character.block)
                        {
                            switch (skillChange.Next(1, 2))
                            {
                                case 1:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk + 1;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk + 1 - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (!character.block)
                                        {
                                            dmg = enemy.atk;
                                            character.hp = character.hp - dmg;

                                        }
                                        else
                                        {
                                            dmg = enemy.atk - character.def;
                                            character.hp = character.hp - dmg;
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
