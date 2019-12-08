using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Teste.Models
{
     public class Funcao
    {
        public Funcao(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public Funcao()
        {
        }
        public int Codigo { get;  set; }
        public string Descricao { get;  set; }
    }
}