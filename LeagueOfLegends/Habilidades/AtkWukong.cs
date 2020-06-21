
using LeagueOfLegends.StatusPersonagem.Wukong;
using System;


namespace LeagueOfLegends.Habilidades
{
    class AtkWukong : SkillWukong
    {
        internal protected Kong LevelAtual {get; set;}

        public AtkWukong() { }

        public AtkWukong(Kong lvl)
        {
            LevelAtual = lvl;
        }


        protected internal virtual void ExibiSkills() => Console.WriteLine($"\n{Campeao}\n{HabilidadePassiva}\n[Q] : {Q} | [W] : {W} | [E] : {E} | [R] : {R}\n");
        private void Skill_Q() => Console.WriteLine($"\nUsar Habilidade {Q}\n");
        private void Skill_W() => Console.WriteLine($"\nUsar Habilidade {W}\n");
        private void Skill_E() => Console.WriteLine($"\nUsar Habilidade {E}\n");
        private void Skill_R() => Console.WriteLine($"\nUsar Habilidade {R}\n");

        internal virtual void UsarSkill(char skill)
        {
            if (skill == 'q' || skill == 'Q')
            {
                Skill_Q();
            }
            else if (skill == 'w' || skill == 'W')
            {
                Skill_W();
            }
            else if (skill == 'e' || skill == 'E')
            {
                Skill_E();
            }
            else if (skill == 'r' || skill == 'R')
            {
                Skill_R();
            }
            else
            {
                Console.WriteLine("Comando invalido!");
            }
        }

    }
}
