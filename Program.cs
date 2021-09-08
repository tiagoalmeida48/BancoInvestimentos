using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            ClientePF cliPF = new ClientePF();
            cliPF.nome = "Tiago";
            double valor = 30;
            conta.DepositarDinheiro(valor);

            Console.WriteLine("Depósito realizado de R$ " + valor + " com sucesso!");
            Console.WriteLine("Nome:" + cliPF.nome);
            Console.WriteLine("Valor atual: R$ " + conta.saldoAtual);
            Console.WriteLine();
              
            conta.SacarDinheiro(30);
            Console.WriteLine("Saque realizado de R$ " + valor + " com sucesso");
            Console.WriteLine("Nome:" + cliPF.nome);
            Console.WriteLine("Valor atual: R$" + conta.saldoAtual);
            Console.WriteLine();
            Console.WriteLine("====================================================================");
            Console.WriteLine();

            //Dictionary<int, ContaInvestimentos> dicContaInvestimento = new Dictionary<int, ContaInvestimentos>();

            //dicContaInvestimento.add(1, new ContaInvestimentos())
        }
    }
}
