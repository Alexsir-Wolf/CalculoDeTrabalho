using System;
using System.Collections.Generic;
using System.Globalization;
using CalculoDeTrabalho.Entities;
using CalculoDeTrabalho.Entities.Enums;

namespace CalculoDeTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Digite os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Função (CabistaF/Oficial): ");
            Funcao funcao = Enum.Parse<Funcao>(Console.ReadLine());

            Departamento departamento = new Departamento(nomeDepartamento);
            Funcionario funcionario = new Funcionario(nome, funcao, departamento);

            Console.WriteLine("Digite quantos tipos de Serviços : (EX.: Cabo AS = 1 tipo, Cabo Espinado = 1 tipo," +
                " Fusão = 1 tipo, Emenda = 1 tipo...)"); //opção de add serviço.
            int qtdServiços = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int i = 1; i <= qtdServiços; i++)
            {
                Console.WriteLine($"Entre com o tipo #{i} de serviço: ");
                Console.Write("Data: ");
                DateTime data = DateTime.Parse(Console.ReadLine());                
                Console.Write("Quantidade executada: (metragem ou unidade)");
                double quantidadeDeServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Valor do serviço: ");
                double valorPorServico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ServicoExecutado servico = new ServicoExecutado(data, quantidadeDeServico, valorPorServico);
                funcionario.AddServico(servico);
            }


            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Entre com dia e mes para calcular valor ganho pelo funcionario: (DD/MM)");
            string diaEMes = Console.ReadLine();
            int dia = int.Parse(diaEMes.Substring(0, 2));// Substring recorta da posição 0 ate a 2 = dia digitado.
            int mes = int.Parse(diaEMes.Substring(3));// Substring recorta da posição 3 ate o final = mes digitado.

            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Valor Ganho: " + diaEMes + ": " + funcionario.ValorGanho(dia, mes).ToString("F2", CultureInfo.InvariantCulture ));


        }
    }
}



