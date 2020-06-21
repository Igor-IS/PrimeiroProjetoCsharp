
using LeagueOfLegends.StatusBaseLol;
using System;

namespace LeagueOfLegends.StatusPersonagem.Wukong
{
    internal class Kong : StatusBase
    {
        internal string Class = "Wukong";
        internal protected byte PontoSkill { get; set; }
        internal int Atk { get; set; }
        internal int AP { get; set; }
        internal int Def { get; set; }
        internal int MR { get; set; }

        internal Kong()
        {
            Experience = 0;
            Level = 1;
            PontoSkill = 1;
            PontosDeVida = 480;
            PontosDeMana = 250;
            Atk = 60;
            AP = 18;
            Def = 44;
            MR = 18;
            
        }



        internal void StatusWu() => Console.WriteLine($"\n{Class}\nLevel {Level}\nHP {PontosDeVida} | MP {PontosDeMana}\nAtk {Atk} | AP {AP} \nDef {Def} | MR {MR}\n");


    }
}
