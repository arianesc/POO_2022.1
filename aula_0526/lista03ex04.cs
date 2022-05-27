using System;

class Program {
  public static void Main() {
		
	}

class Equacao{
	private double a, b, c;

	public Equacao(double a, double b, double c){
		this.a = a;
		this.b = b;
		this.c = c;
	}

	public void SetABC(double a; double b; double c) {
		this.a = a;
		this.b = b;
		this.c = c;
	}

	public void GetABC(){
		return $" a = {a}, b = {b}, c = {c}";
	}

	public bool RaizesReais(){
		// calcular raizes da eq
	}

	public double Delta(){
		// calcular delta 
	}

	public override string ToString(){
		
	}

}