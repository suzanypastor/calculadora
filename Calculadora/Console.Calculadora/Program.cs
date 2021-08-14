using System;

namespace Console.Calculadora
{
    class Program
    {
		/*
			Objetivo: 
				Criar uma rotina para calcular a folha de pagamnentos, solicitando os dados abaixo do usuário
				Nome
				Idade
				Salário
				Beneficios
				Gastos
			Premissas: 
				Aplicativo só pode fechar quando o usuário digitar a letra 'Q'
			O que iremos utilizar
				Tipos básicos do C#
				Função
				Console (Entrada/Saida)
				Operador lógico (== (Iqualidade), !=(Diferente), <(Menor), >(Maior) e etc)
		*/
		static void Main(string[] args)
        {
			System.Console.WriteLine("Brasil");
			System.Console.WriteLine("São Paulo - " + "SP");
			System.Console.WriteLine(string.Concat("Data e Hora: ", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), ""));
			System.Console.WriteLine("Olá, para realizar o calcula da folha de pagamentos é necessário informar os dados abaixo, para continuar digite enter ou para sair digite Q *");

			// laço de repetição, enquanto a tecla Q não for digitada o laço de repetição irá continuar chamando a função Calcular
			while (System.Console.ReadLine() != "Q")
				Calcular();

			System.Console.WriteLine("BYE BYE");
		}

		public static void Calcular()
		{
			// string é do tipo class e por isso pode receber o valor null
			string nomeCompleto;

			// int e decimal são do tipo struct
			int idade = 0;
			decimal salario, beneficios, gastos = 0;

			System.Console.WriteLine("*-------------- Digite seu nome ----------------*");
			// lendo o que o usuário informou no console
			nomeCompleto = System.Console.ReadLine();

			System.Console.WriteLine("*-------------- Digite sua idade ----------------*");
			// lendo o que o usuário informou no console
			idade = Convert.ToInt32(System.Console.ReadLine());

			System.Console.WriteLine("*-------------- Digite seu salario ---------------*");
			// lendo o que o usuário informou no console
			salario = Convert.ToDecimal(System.Console.ReadLine());

			System.Console.WriteLine("*-------------- Digite o total de beneficios -----*");
			// lendo o que o usuário informou no console
			beneficios = Convert.ToDecimal(System.Console.ReadLine());

			System.Console.WriteLine("*-------------- Digite o total de gastos ---------*");
			// lendo o que o usuário informou no console
			gastos = Convert.ToDecimal(System.Console.ReadLine());

			// chamando a função calcular para realizar a operação matematica informada via parametro.
			decimal totalSalario = Calcular(salario, beneficios, "Somar");

			// chamando a função calcular para realizar a operação matematica informada via parametro.
			decimal saldoConta = Calcular(totalSalario, gastos, "Subtrair");

			// imprimindo a folha de pagamento do usuario
			Imprimir(nomeCompleto, salario, totalSalario, gastos, saldoConta);

			// 
			CalcularVelhice(idade);

			System.Console.WriteLine("Para voltar ao inicio da aplicativo digite enter, ou Q para sair");
		}

		/*
			Calcular
				Função: Calcular
				Parametros 
					Decimal numero1: valor1 para ser utilizado no calculo
					Decimal numero2: valor2 para ser utilizado no calculo
					String operação: Indica para o função calcular qual operação matematica devera ser executada
				Retorno
					static decimal: Indica que a função calcular retornará um decimal correspondente do resultado da operação solicitada.
				Controle de fluxo ou condicional: if e else
		*/
		static decimal Calcular(decimal numero1, decimal numero2, string operacao)
		{
			switch (operacao)
			{
				case "Somar":
					return numero1 + numero2;

				case "Subtrair":
					return numero1 - numero2;

				case "Multiplicar":
					return numero1 * numero2;

				case "Dividir":
					return numero1 / numero2;

				default:
					return 0;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="idade"></param>
		static void CalcularVelhice(int idade)
		{
			if (idade < 30)
				System.Console.WriteLine("Novinho");
			else
				System.Console.WriteLine("Novinho ++");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="nomeUsuario"></param>
		/// <param name="salarioUsuario"></param>
		/// <param name="salarioTotalUsuario"></param>
		/// <param name="gastosUsuario"></param>
		/// <param name="saldoAtualContaUsuario"></param>
		static void Imprimir(string nomeUsuario, decimal salarioUsuario, decimal salarioTotalUsuario, decimal gastosUsuario, decimal saldoAtualContaUsuario)
		{
			System.Console.WriteLine("O salario da " + nomeUsuario + " é R$" + salarioUsuario);
			System.Console.WriteLine("O salario total da " + nomeUsuario + " é com beneficios R$" + salarioTotalUsuario);
			System.Console.WriteLine("O total de gastos da " + nomeUsuario + " é R$" + gastosUsuario);
			System.Console.WriteLine("O saldo da " + nomeUsuario + " é R$" + saldoAtualContaUsuario);
			System.Console.WriteLine("");
		}
	}
}