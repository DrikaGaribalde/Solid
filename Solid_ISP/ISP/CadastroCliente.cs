﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP.ISP
{
    internal class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void ValidarDados()
        {
            // Validar CPF, Email
        }
    }
}
