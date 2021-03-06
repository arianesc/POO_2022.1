using System;

class Program {
  public static void Main() {
		Retangulo x = new Retangulo();
		
		x.SetBase(2);
		x.SetAltura(3);

		Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
		Console.WriteLine(x.CalcArea());
		Console.WriteLine(x);



	}
}

class Retangulo {
	private double b, h;

	public Retangulo(double b, h){
		this.b = b;
		this.h = c;
	}
	
	public void SetBase(double b){
		this.b = b;	
	}
	
	public void SetAltura(double h){
		this.h = h;
	}
	
	public double GetBase(){
			return b;
	}
		
	public double GetAltura(){
		return h;
	}
		
	public double CalcArea(){
		return b*h;
	}
		
	public double CalcDiagonal(){
		// raiz de b^2 + h^2
		return	Math.Sqrt((b*b) + (h*h));
		
	}

	public override string ToString(){
		return $"base = {b}, altura = {h}";
	}
	
	}
