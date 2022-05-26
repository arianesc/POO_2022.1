using System;

class Program {
	public static void Main() { 
		Console.WriteLine(MenorValor(4,5,3));
		int y = MenorValor(
			int.Parse(Console.ReadLine()),
			int.Parse(Console.ReadLine()),
			int.Parse(Console.ReadLine()));
		Console.WriteLine(y);
	}
		public static int MenorValor(int a, int b, int c) { 
			int menor = a;
			if (b < menor) menor = b;
			if (c < menor) menor = c;
			return menor;
	}
}