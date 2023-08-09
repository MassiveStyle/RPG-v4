using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_v4
{
    public class Character : ICharacterStats
    {
        public bool turn { get; set; }


        public bool block { get; set; }


        public string name { get; set; }


        public double hp { get; set; }


        public double hpMax { get; set; }


        public int str { get; set; }


        public int con { get; set; }


        public int dex { get; set; }


        public int quick { get; set; }


        public double atk { get; set; }


        public double def { get; set; }


        public int level { get; set; }


        public double xpCurrent { get; set; }


        public double xpTreshold { get; set; }


        public int skillPoints { get; set; }


        public string classType { get; set; }


        public Character()
        {
            SetName();
            SetDefaultStats();
            SetClassType();
        }

        public void SetName()
        {
            while (string.IsNullOrEmpty(this.name))
            {
                Console.WriteLine("Bitte wähle einen Namen: ");
                string name = Console.ReadLine();
                this.name = name;

            }

        }
        public void SetDefaultStats()
        {
            hp = Math.Round(100 + con * 0.25);
            hpMax = hp;
            str = 10;
            con = 10;
            dex = 10;
            quick = 10;
            atk = 10; 
            def = Math.Round(5 + dex * 0.17);
            level = 0;
            xpCurrent = 0;
            xpTreshold = 200;
            skillPoints = 0;
            turn = false;
        }

        public void SetClassType()
        {
            Console.WriteLine("Wähle eine Klasse: (1) Krieger, (2) Jäger  ");
            string Class = Console.ReadLine();

            switch (Class)
            {
                case "1":
                    {
                        Console.WriteLine("Du hast den Krieger gewählt");
                        this.classType = "Krieger";
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Du hast den Jäger gewählt");
                        this.classType = "Jäger";
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Wähle bitte eine Klasse");
                    }
                    break;
            }
        }
    }
}
