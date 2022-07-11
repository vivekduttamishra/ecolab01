class App
{

	static void Main()
	{
		int n=5;
		int fn= Factorial(5);

		System.Console.WriteLine("Factorial of "+n+" is "+fn);		

		//Expected Output:   Factorial of 5 is 120
		
	}

	static int Factorial(int x)
	{
		int fx=1;
		while(x>1)
		{
			fx*=x--;
		}
		return fx;
	}
}