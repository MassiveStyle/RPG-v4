using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class LevelCheck
    {
        private Character character;
        public double modifier;

        public LevelCheck(Character character)
        {
            this.character = character;
        }

        public void Check()
        {
            switch (character.level)
            {
                case 0:
                    {
                        modifier = 1;
                    }
                    break;

                case 1:
                    {
                        modifier = 1.15;
                    }
                    break;

                case 2:
                    {
                        modifier = 1.25;
                    }
                    break;

                case 3:
                    {
                        modifier = 1.5;
                    }
                    break;

                case 4:
                    {
                        modifier = 1.75;
                    }
                    break;

                case 5:
                    {
                        modifier = 2;
                    }
                    break;
            }
        }
    }
}
