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


        bool block { get; }


        double hp { get; }


        double hpMax { get; }


        int str { get; }


        int con { get; }


        int dex { get; }


        int quick { get; }


        double atk { get; }


        double def { get; }


        int level { get; }


        double xpCurrent { get; }


        double xpTreshold { get; }


        int skillPoints { get; }


        string classType { get; }


        void SetDefaultStats();


        void SetName();


        void SetClassType();
    }
}
