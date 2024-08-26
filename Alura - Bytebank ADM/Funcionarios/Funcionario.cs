using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int totalFuncionarios { get; set; }

        public Funcionario(string cpf, double salario)        {
            Cpf = cpf;
            Salario = salario;
            Console.WriteLine("Criando um funcionário");
            totalFuncionarios++;
        }

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract double getBonificacao();

        public abstract void AumentarSalario();

    }
}
