using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public class Enemy : IEnemy
    {
        public string EnemyType { get; set; }


        public int hp { get; set; }


        public int str { get; set; }


        public int con { get; set; }


        public int dex { get; set; }


        public int quick { get; set; }


        public int atk { get; set; }


        public int def { get; set; }


        public int xpWorth { get; set; }

        public Enemy()
        {
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
            hp = random.Next(1, 100);
            str = random.Next(1, 10);
            con = random.Next(1, 10);
            dex = random.Next(1, 10);
            quick = random.Next(1, 10);
            atk = random.Next(1, 10);
            def = random.Next(1, 10);
            xpWorth = 200;
        }
    }
}
