using Solid_OCP.Resolucao_OCP;

namespace Solid_OCP
{
    public class DebitoConta_OCP
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                //Débito em conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                //Débito em conta poupança
                //Valida Aniverário da conta
            }
        }
    }
}

///No exemplo a classe DebitoConta, contém o métoto que é responsável para realizar
///débitos das contas Corrente e Poupança, através do Enum "TipoConta"
///Quanto mais regras forem criadas, mais vai ficar difícil a manutenção,
///como resolver?
