using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegends.StatusBaseLol.Inimigos
{
    class CampeaoInimigo : StatusBase
    {
        internal int CampeaoExp = 70;

        internal CampeaoInimigo() { }

        internal void MatarPlayer(int quantidade)
        {
            ContadorDeExp(quantidade); 
        }

        internal override void ContadorDeExp(int quantidadeKills)
        {
            int Abates = quantidadeKills;
            kills(Abates);
            int ExpAdquirida = quantidadeKills * CampeaoExp;
            Experience += ExpAdquirida;
        }

        protected void kills( int quantidadeAbates)
        {
            if (quantidadeAbates == 2)
            {
                DoubleKill();
            }
            else if (quantidadeAbates == 3)
            {
                TreepleKill();
            }
            else if (quantidadeAbates == 4)
            {
                QuadraKill();
            }
            else if (quantidadeAbates == 5)
            {
                PentaKill();
            }
        }

        internal int GanhodeExp(int abate, out int res)
        {
            abate = 0;
            return res = Experience;
        }

        protected void DoubleKill() => Console.WriteLine("\nDouble Kill\n");
        protected void TreepleKill() => Console.WriteLine("\n  Treeple Kill  \n");
        protected void QuadraKill() => Console.WriteLine("\n...Quadra Kill...\n");
        protected void PentaKill() => Console.WriteLine("\n....P.E.N.T.A  K.I.L.L....\n");
    }
}
