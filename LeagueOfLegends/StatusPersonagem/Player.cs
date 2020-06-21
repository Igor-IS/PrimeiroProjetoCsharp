
using LeagueOfLegends.Habilidades;
using LeagueOfLegends.StatusBaseLol.Inimigos;
using LeagueOfLegends.StatusPersonagem.Wukong;
using System;

namespace LeagueOfLegends.StatusPersonagem
{
    internal class Player : AtkWukong
    {
        private protected Kong Wu { get; set; }
        internal int ExpUp { get; set; }

        internal Player(Kong warrior)
        {
            Wu = warrior;
        }

        internal void ExibirStatus() => Console.WriteLine($"\n{Wu.Class}\nLevel {Wu.Level}\nHP {Wu.PontosDeVida} | MP {Wu.PontosDeMana}\nAtk {Wu.Atk} | AP {Wu.AP} \nDef {Wu.Def} | MR {Wu.MR}\n");

        protected internal override void ExibiSkills()
        {
            base.ExibiSkills();
        }

        internal override void UsarSkill(char skill)
        {
            base.UsarSkill(skill);
        }

        internal void ExpParaSubirLevel(int exp)
        {
            ExpUp += exp;
            if (ExpUp >= 120 && Wu.Level <= 6)
            {
                SubirLevel();
            }
            else if (ExpUp >= 300 && Wu.Level <= 11)
            {
                SubirLevel();
            }
            else if (ExpUp >= 480 && Wu.Level <= 18)
            {
                SubirLevel();
            }
        }

        private void SubirLevel()
        {
            Wu.Level += 1;
            ExpUp = 0;
            AtualizacaoDeStatus();
        }
        private void AtualizacaoDeStatus()
        {
            if (Wu.Level >= 2 && Wu.Level <= 18)
            {
                Wu.PontoSkill += 1;
                Wu.PontosDeVida += 90;
                Wu.PontosDeMana += 50;
                Wu.Atk += 9;
                Wu.AP += 2;
                Wu.Def += 8;
                Wu.MR += 3;
                NotificacaoDeLevelUp();
            }
            else
            {
                Console.WriteLine($"Você Esta no Max Level!");
            }
        }

        protected void NotificacaoDeLevelUp() 
        { 
            Console.WriteLine("Level Up");
            ExibirStatus();
        }


    }
}
