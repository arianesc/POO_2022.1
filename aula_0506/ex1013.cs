using System;

class Program {
  public static void Main() {
		int a = Console.ReadLine();
		int b = Console.ReadLine();
		int s = Console.ReadLine();
		// (a+b+abs(a-b)) / 2 
		int maior = (a+b+(a*b*s))/2;

		Console.WriteLine($"{maior} eh o maior");
		
  }
}