using System;

class Program {
  public static void Main() {
		Frete x = new Frete();
		x.SetPeso(1);
		x.SetDistancia(10);

		Console.WriteLine(x.GetDistancia());
		Console.WriteLine(x.GetPeso());
		Console.WriteLine(x.CalcFrete());
		Console.WriteLine(x);

	}
}
class Frete {
	private double distancia;
	private double peso;

	public void SetDistancia(double d){
		if (d > 0) this.distancia = d; 
	}
	
	public void SetPeso(double p){
		if (p > 0) this.peso = p; 
	}

	public double GetDistancia(){
		return this.distancia;
	}

	public double GetPeso(){
		return this.peso;
	}

	public double CalcFrete(){
		return (distancia*peso*0.1);
	}

	public override string ToString(){
		return $"distancia: {distancia}, peso: {peso}";
	}	
}