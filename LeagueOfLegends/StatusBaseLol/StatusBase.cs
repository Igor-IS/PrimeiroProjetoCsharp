
using System;


namespace LeagueOfLegends.StatusBaseLol
{
    abstract class StatusBase
    {
        internal protected byte Level { get; set; }
        internal protected int PontosDeVida { get; set; }
        internal protected int PontosDeMana { get; set; }
        internal protected int Experience = 0;
        internal protected const int ExpAfk = 8;

        internal StatusBase() { }

        internal virtual void ContadorDeExp(int exp)
        {
            exp = ExpAfk;
            Experience += exp;
        }

    }
}
