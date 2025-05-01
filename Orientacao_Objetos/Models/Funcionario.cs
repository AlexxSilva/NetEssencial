using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Funcionario : Pessoa
    {
        public string? Empresa { get; set; }
        public decimal Salario { get; set; }

        internal void ListarFuncionario()
        {
            
        }
    }
}
