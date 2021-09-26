using System;
using System.Collections.Generic;
using CalculoDeTrabalho.Entities;
using CalculoDeTrabalho.Entities.Enums;

namespace CalculoDeTrabalho.Entities
{
    class Departamento
    {
        public string Nome { get; set; }
        public Departamento()
        {
        }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}