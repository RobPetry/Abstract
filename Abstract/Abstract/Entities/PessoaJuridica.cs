using System;
using System.Collections.Generic;
using System.Text;
namespace Abstract.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(int funcionarios, string nome, double rendaAnual) :base(nome,rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double ImpostoPago()
        {
            float imposto = Funcionarios > 10 ? 0.14f : 0.16f;
            return RendaAnual * imposto;
        }
    }
}
