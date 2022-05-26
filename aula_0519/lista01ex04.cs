using System;

class Program {
	public static void Main(){
		ContaBancaria x = new ContaBancaria();

		x.titular = "Eduardo";
		x.numero = "123-x";
		x.saldo = 100;
		
		Console.WriteLine(x.titular);
		Console.WriteLine(x.numero);
		Console.WriteLine(x.saldo);

		x.Depositar(100);
		Console.WriteLine(x.saldo);
		
		x.Sacar(50);
		Console.WriteLine(x.saldo);
		
	}
}


class ContaBancaria {
	public string titular, numero;
	public double saldo;

	public void Depositar(double valor){
		saldo = saldo + valor;
	}


	public void Sacar(double valor){
		saldo = saldo - valor;
	}

	
	
}