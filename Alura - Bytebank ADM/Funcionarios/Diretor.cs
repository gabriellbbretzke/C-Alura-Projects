﻿using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.5;
        }
        //public string Senha { get; set; }
        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}
    }
}
