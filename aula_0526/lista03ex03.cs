using System;

class Program {
  public static void Main() { 
	Conversor x = new Conversor();
	x.SetNum(2);
	Console.WriteLine(x.GetNum());
	Console.WriteLine(x);

	
	}
}

class Conversor {
	private int num;

	public Conversor(int num) {
		this.num = num;
	}
	
	public void SetNum(int num){
		if (num > 0) this.num = num;
	}

	public int GetNum(){
		return num;
	}

	public string Binario(){
		int x = num;
		int remainder;
		string result = " ";
		
		while (x > 0) 
		{
			remainder = x % 2;
			x/=2;
			result = remainder.ToString() + result; 
		}
		
		return result;
	}

	public override string ToString(){
		return $" decimal: {this.num } binario:{this.Binario()} ";
	}			

}