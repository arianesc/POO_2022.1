using System;

class Program {
  public static void Main() {
		Frete x = new Frete(100, 10);
	
		Console.WriteLine(x.GetDistancia());
		Console.WriteLine(x.GetPeso());
		Console.WriteLine(x.CalcFrete());
		Console.WriteLine(x);

	}
}


class Frete {		
	private double distancia, peso;
	public Frete(double distancia, double peso){ // construtor equivalente ao init do python!
		this.distancia = distancia;
		this.peso = peso;
	}

	public double GetDistancia(){
		return distancia;
	}

	public double GetPeso(){
		return peso;
	}
	
	public void SetDistancia(double d){
		if (d > 0) this.distancia = d; 
	}
	
	public void SetPeso(double p){
		if (p > 0) this.peso = p; 
	}

	public double CalcFrete(){
		return (distancia*peso*0.01);
	}

	public override string ToString(){
		return $"distancia = {distancia} km, peso = {peso} kg";
	}	
}