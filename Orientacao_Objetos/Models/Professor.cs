﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Professor
    {
        public string? Nome { get;set; }
        public string? Disciplina { get; set; }

        public Professor(string? nome, string? disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;    
        }
    }
}
