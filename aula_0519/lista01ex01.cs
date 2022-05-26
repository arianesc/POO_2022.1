using System;

class Program {
	public static void Main() { 
		Circulo a1 = new Circulo();
	
	}

	class Circulo {
		public string raio;
		public string dimensao;
		public int idade;

		int pi = 3.14;
		public int Area(){
				return (pi*(raio*raio));
		}
			public int Circunferencia(){
		return (2*pi*raio);
			}
				
	}
}