using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class Enemy : IEnemy
    {
        private LevelCheck levelCheck;


        public string EnemyType { get; set; }


        public double hp { get; set; }


        public double str { get; set; }


        public double con { get; set; }


        public double dex { get; set; }


        public double quick { get; set; }


        public double atk { get; set; }


        public double def { get; set; }


        public double xpWorth { get; set; }

        public Enemy(LevelCheck levelCheck)
        {
            this.levelCheck = levelCheck;
            levelCheck.Check();
            SetEnemyType();
            SetStats();
            
        }
        public void SetEnemyType()
        {
            List<string> enemyTypes = new List<string>();
            enemyTypes.Add("Goblin");
            enemyTypes.Add("Spinne");
            enemyTypes.Add("Wolf");
            enemyTypes.Add("Bär");
            enemyTypes.Add("Slime");

            Random random = new Random();
            int aRandomPos = random.Next(enemyTypes.Count);
            EnemyType = enemyTypes[aRandomPos];

        }

        public void SetStats()
        {
            Random random = new Random();
            hp = Math.Round(random.Next(50, 101) * levelCheck.modifier);
            str = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            con = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            dex = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            quick = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            atk = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            def = Math.Round(random.Next(1, 11) * levelCheck.modifier);
            xpWorth = Math.Round(random.Next(50, 201) * levelCheck.modifier);
        }
    }
}
