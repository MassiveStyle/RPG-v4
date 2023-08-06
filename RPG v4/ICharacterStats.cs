using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_v4
{
    public interface ICharacterStats
    {
        bool turn { get; }


        int hp { get; }


        int hpMax { get; }


        int str { get; }


        int con { get; }


        int dex { get; }


        int quick { get; }


        int atk { get; }


        int def { get; }


        int level { get; }


        int xpCurrent { get; }


        int xpTreshold { get; }


        int skillPoints { get; }


        string classType { get; }


        void SetDefaultStats();


        void SetName();


        void SetClassType();
    }
}
