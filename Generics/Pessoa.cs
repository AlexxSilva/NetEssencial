using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Generics
{
    public class Pessoa
    {
        public int CPF { get; set; }
        public string? Nome { get; set; }


        public Pessoa(int cpf, string? nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is Pessoa)) return false;

            var other= (Pessoa)obj;

            return CPF.Equals(other.CPF);
        }

        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }
    }
}
