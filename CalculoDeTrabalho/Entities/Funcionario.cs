using System;
using System.Collections.Generic;
using CalculoDeTrabalho.Entities;
using CalculoDeTrabalho.Entities.Enums;

namespace CalculoDeTrabalho.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public Funcao Funcao { get; set; }
        public Funcionario funcionario { get; set; }
        public Departamento Departamento { get; set; }
        public List<ServicoExecutado> ServicosExecutados { get; set; } = new List<ServicoExecutado>();

        //construtor

        public Funcionario()
        {
        }

        public Funcionario(string nome, Funcao funcao, Departamento departamento)
        {
            Nome = nome;
            Funcao = funcao;
            Departamento = departamento;
        }

        //metodos

        public void AddServico(ServicoExecutado servico)
        {
            ServicosExecutados.Add(servico);
        }
        public void RemoverServico(ServicoExecutado servico)
        {
            ServicosExecutados.Remove(servico);
        }

        public double ValorGanho(int dia, int mes)
        {
            double soma = 0;
            foreach (ServicoExecutado servico in ServicosExecutados)
            {
                if (servico.Data.Day == dia && servico.Data.Month == mes)
                {
                    soma = +servico.ValorTotal();
                }
            }
            return soma;
        }
    }
}
