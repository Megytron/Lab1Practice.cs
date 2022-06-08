using System;

public class Program
{
	public static void Main()
	{
		string[] playerClasses = {"Tank", "Tank", "Tank"};
		
		for (var i = 0; i < playerClasses.Length ; i++) {
			playerClasses[i] = "Healer";
		}
		
		foreach(var player in playerClasses) {
			Console.WriteLine(player);
		}
	}
}
