class App
{

	static void Main()
	{
		int n=5;
		Factorial f = new Factorial();
		int fn= f.Calculate(5);

		System.Console.WriteLine("Factorial of "+n+" is "+fn);		

		//Expected Output:   Factorial of 5 is 120
		
	}
}

