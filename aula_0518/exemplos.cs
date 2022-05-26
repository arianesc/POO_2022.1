using System;

class Program {
	public static void Main() { 
		Aluno a1 = new Aluno();
		a1.idade = 10;
		Console.WriteLine(a1.DiasVividos());
		Console.WriteLine(a1);
	
	}

	class Aluno {
		public string nome;
		public string matricula;
		public int idade;
		
		public int DiasVividos(){
			return idade * 365;
		}
			public string str(){
		return nome;}
				
	}
}