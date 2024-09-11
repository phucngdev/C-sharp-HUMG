using System;
namespace _11_9
{
	public class Animal
	{
		public int Legs { set; get; }
		public float  Weight { set; get; }
		
		public Animal()
		{

		}

		public void  ShowLegs()
		{
			Console.WriteLine($"Legs : {Legs}");
		}
	}
}

