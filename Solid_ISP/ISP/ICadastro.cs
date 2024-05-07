using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP.ISP
{
    internal interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
/// Duas classes herdam a mesma interface, 
/// CadastroCliente e CadastroProduto
/// porém o método EnviarEmail()
/// não corresponde para a classe CadastroProduto, pois o produto 
/// não tem e-mail.
/// Como resolver?