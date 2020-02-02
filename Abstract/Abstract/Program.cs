using System;
using System.Collections.Generic;
using Abstract.Entities;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>();
            Console.Write("Entre com o numero de contribuintes:");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Contribuinte #{i}:");
                Console.Write("Fisica ou Juridica (f/j):");
                char type;
                char.TryParse(Console.ReadLine(), out type);
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Renda:");
                double renda;
                    double.TryParse(Console.ReadLine(),out renda);
                if (type == 'f')
                {
                    Console.Write("Gastos com saude:");
                    double saude;
                    double.TryParse(Console.ReadLine(), out saude);
                    contribuintes.Add(new PessoaFisica(saude, nome, renda));
                }else if(type == 'j')
                {
                    Console.Write("Numero de funcionarios:");
                    int funcionarios;
                    int.TryParse(Console.ReadLine(), out funcionarios);
                    contribuintes.Add(new PessoaJuridica(funcionarios, nome, renda));
                }
            }
            Console.WriteLine("Impostos pagos");
            double count=0;
            foreach(Contribuinte c in contribuintes)
            {
                double value = c.ImpostoPago();
                Console.WriteLine(c.Nome+": $ " +value.ToString("F2"));
                count += value;
            }
            Console.WriteLine();
            Console.WriteLine("Total pago "+ count.ToString("F2"));
        }
    }
}
