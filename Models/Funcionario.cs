using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Teste.Models
{
     public class Funcionario
    {
        public Funcionario()
        {
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public Funcao Funcao { get; set; }
        public List<Dependente> Dependentes { get; set; }

    }
}