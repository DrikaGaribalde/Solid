﻿namespace Solid_OCP.Resolucao_OCP
{
    public class DebitoContaPoupanca_OCP : DebitoConta_OCP
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormatarTransacao();
        }
    }
}
