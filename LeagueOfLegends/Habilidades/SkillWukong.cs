using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeagueOfLegends.Habilidades
{
     abstract class SkillWukong
    {
        public string Campeao = "Habilidades Wukong";
        public string HabilidadePassiva = "(Passiva) Wukong ganha empilhamento de armadura e máxima regeneração de vida enquanto luta contra campeões e monstros";
        protected internal string Q { get; private set; }
        protected internal string W { get; private set; }
        protected internal string E { get; private set; }
        protected internal string R { get; private set; }

        protected internal SkillWukong()
        {
            Q = "Golpe Destruidor";
            W = "Guerreiro Trapaceiro";
            E = "Resplendor das Nuvens";
            R = "Ciclone";
        }
    }
}
