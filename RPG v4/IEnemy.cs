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


        double hp { get; }


        double str { get; }


        double con { get; }


        double dex { get; }


        double quick { get; }


        double atk { get; }


        double def { get; }


        double xpWorth { get; }


        void SetEnemyType();


        void SetStats();
    }
}
