using System;

class Program {
  public static void Main() {
	
	string name = Console.ReadLine();
	
	double v1 = double.Parse(Console.ReadLine());
	double v2 = double.Parse(Console.ReadLine());

	double total = (((v2*15)/100) + v1);

	Console.WriteLine($"TOTAL = R$ {total:0.00}");

}
}