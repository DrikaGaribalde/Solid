using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP.Resolucao_ISP
{
    internal interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
