using System;

public class Program
{
	public static void Main()
	{
		persona[] personaType = {new persona(), new persona(), new persona ()};
		personaType[1].personaName = "Arsene";
		personaType[2].personaName = "Carmen";
		
		for(var i=0;i<personaType.Length;i++) {
			personaType[i].personaLevel = 100;
		}
		
		foreach(var phantomthief in personaType){
			Console.WriteLine(phantomthief.personaName);
			Console.WriteLine(phantomthief.personaLevel);
		}
	}
}

public class persona {
	public string personaName = "Captain Kidd";
	public int personaLevel = 1;
}
