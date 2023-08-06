using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public interface IEnemy
    {
        string EnemyType { get; }


        int hp { get; }


        int str { get; }


        int con { get; }


        int dex { get; }


        int quick { get; }


        int atk { get; }


        int def { get; }


        int xpWorth { get; }


        void SetEnemyType();
    }
}
