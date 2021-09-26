using System;
using System.Collections.Generic;
using CalculoDeTrabalho.Entities;
using CalculoDeTrabalho.Entities.Enums;


namespace CalculoDeTrabalho.Entities
{
    class ServicoExecutado
    {
        public DateTime Data { get; set; }
        //public string Tipo { get; set; }
        public double ValorPorServiço { get; set; }
        public double Quantidade { get; set; }


        //construtor
        public ServicoExecutado()
        {
        }

        public ServicoExecutado(DateTime data, double valorPorServiço, double quantidade)
        {
            Data = data;
            //Tipo = tipo;
            ValorPorServiço = valorPorServiço;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            return Quantidade * ValorPorServiço;
        }
    }

}
