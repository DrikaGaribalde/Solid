using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP.ISP
{
    internal class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem e-mail, o que eu faço agora???
            throw new NotImplementedException("Esse metodo não serve pra nada");
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void ValidarDados()
        {
            // Validar valor
        }
    }
}
