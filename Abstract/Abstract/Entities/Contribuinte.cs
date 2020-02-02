
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public Double RendaAnual { get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double ImpostoPago();
    }
}
