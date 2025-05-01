using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Departamento
    {
        public string? Nome { get; set; }
        public List<Professor>? professores { get; set; }

        public Departamento(string? nome)
        {
            Nome = nome;
            professores = new List<Professor>();    
        }

        public void IncluirProfessor(Professor professor)
        {
            professores?.Add(professor);//elvis operator

        }

        public void ListaProfessores()
        {
            MessageBox.Show($"Departamento de :  {Nome} \n");
            foreach (var prof in professores)
                MessageBox.Show(prof.Nome + " -> " + prof.Disciplina);
        }
    }
}
