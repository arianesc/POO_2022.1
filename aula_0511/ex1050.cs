using System;
public class Program {
	public static void Main() {
		int x = int.Parse(Console.ReadLine());
		switch(x) {
			case 61: Console.WriteLine("Brasilia"); break;
			case 71: Console.WriteLine("Salvador"); break;
			case 11: Console.WriteLine("Sao Paulo"); break;
			case 21: Console.WriteLine("Rio de Janeiro"); break;
			case 32: Console.WriteLine("Juiz de Fora"); break;
			case 19: Console.WriteLine("Campinas"); break;
			case 27: Console.WriteLine("Vitoria"); break;
			case 31: Console.WriteLine("Belo Horizonte"); break;
			default:  Console.WriteLine("DDD nao cadastrado"); break;
		}

		// if (x == 61) Console.WriteLine("Brasilia");
		// else if (x == 71) Console.WriteLine("Salvador");
		// else if (x == 11) Console.WriteLine("Sao Paulo");
		// else if (x == 21) Console.WriteLine("Rio de Janeiro");
		// else if (x == 32) Console.WriteLine("Juiz de Fora");
		// else if (x==19) Console.WriteLine("Campinas");
		// else if (x == 27) Console.WriteLine("Vitoria");
		// else if (x == 31) Console.WriteLine("Belo Horizonte");
		// else Console.WriteLine("DDD nao cadastrado");
	}
}