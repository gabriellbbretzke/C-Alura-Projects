using Bytebank;
using Bytebank.titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "110123-X";
//conta1.numero_agencia = 123;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-X";
//conta2.numero_agencia = 321;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pós- Transferência: " + conta1.saldo);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "André Silva";
//conta3.titular.profissao = "Programador C#";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agência Central";
//conta3.saldo = 100;

//Console.WriteLine(conta3.titular.nome);

//if (conta3.titular == null)
//{
//    Console.WriteLine("O campo titular está nulo.");
//}

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(235, "125358-X");
//conta4.Saldo = 100;
//conta4.Titular = sarah;

//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Saldo);
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

//ContaCorrente conta5 = new ContaCorrente(2535, "125358-X");
//ContaCorrente conta6 = new ContaCorrente(365, "957256-X");

//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Cliente cliente1 = new Cliente("Nome","CPF001","Profissão1");
Cliente cliente2 = new Cliente("Nome2", "CPF002", "Profissão2");

Console.WriteLine(Cliente.TotalDeClientesCadastrados);
Cliente cliente3 = new Cliente("Nome3", "CPF003", "Profissão3");
Cliente cliente4 = new Cliente("Nome4", "CPF004", "Profissão4");

Console.WriteLine(Cliente.TotalDeClientesCadastrados);


Console.ReadKey();