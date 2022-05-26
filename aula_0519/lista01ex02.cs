using System;

class Program {
	public static void Main(){
		Disciplina x = new Disciplina();

		x.nome = "matematica";
		x.n1 = 5;
		x.n2 = 5;
		x.n3 = 5;
		x.n4 = 5;

		x.media_final = 5;

  Console.WriteLine(x.MediaParcial());
  Console.WriteLine(x.MediaFinal());
		
	}
}

class Disciplina {
	public string nome;
	public double n1, n2, n3, n4, media_final;

	public double MediaParcial(){
		// notas bimestrais
		return ( ( (n1*2) + (n2*2) + (n3*3) + (n4*3))  / 10);
	}

	public double MediaFinal(){
		// com todas as notas
	return ((MediaParcial() + media_final)/2);
	}


	public void Resultado(){
		double res;
		if MediaParcial() < 60 && MediaFinal() < 60; {
				return ("Reprovado");
		else {
			""
		}
			

		
			
	}
}