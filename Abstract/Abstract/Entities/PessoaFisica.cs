
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Entities
{
    class PessoaFisica :Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(double gastoSaude, string nome, double rendaAnual):base(nome,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double ImpostoPago()
        {
            float imposto = RendaAnual < 20000 ? 0.15f : 0.25f;
            double abateImposto =GastoSaude > 0 ? GastoSaude / 2 : 0;
            return RendaAnual * imposto - abateImposto;
        }
    }
}
