using System;
public class HelloProgram
{
	public static void Main()
	{
		Console.WriteLine("Greetings! What is your name?");
		Console.Write("My name is: ");
		string name = Console.ReadLine();
		Console.WriteLine("Nice to meet you, " + name);
		Console.Read();
	}
}