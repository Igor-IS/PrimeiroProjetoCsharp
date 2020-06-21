
using LeagueOfLegends.StatusBaseLol.Inimigos;
using LeagueOfLegends.Habilidades;
using LeagueOfLegends.StatusPersonagem;
using LeagueOfLegends.StatusPersonagem.Wukong;
using System;

namespace LeagueOfLegends
{
    class Program
    {
        static void Main(string[] args)
        {
            WuTopLane();
        }

        static void WuTopLane()
        {
            var matarPlayer = new CampeaoInimigo();
            var wu = new Kong();
            var wukong = new Player(wu);
            int abatesTop = 10;
            char Q = 'q';
            char W = 'w';
            char E = 'E';
            char R = 'R';
            matarPlayer.MatarPlayer(abatesTop);
            int res;
            matarPlayer.GanhodeExp(abatesTop, out res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
            wukong.ExpParaSubirLevel(res);
           



            
            wukong.ExibiSkills();
            wukong.UsarSkill(W);
            wukong.UsarSkill(E);
            wukong.UsarSkill(Q);


            wukong.ExpParaSubirLevel(res);
            wukong.ExibiSkills();
            wukong.UsarSkill(R);
            matarPlayer.MatarPlayer(abatesTop);
        }

        static char EscolhendoUmaSkillParaUsar()
        {
            Console.Write("Usar Skill  : ");
            char skill = char.Parse(Console.ReadLine());
            return skill;
        }
    }  
}
