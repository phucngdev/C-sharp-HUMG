using System;
namespace _11_9
{
	public class Cat : Animal 
	{
		public string Food;

		public Cat(int Legs, string Food)
		{
			this.Legs = Legs;
			this.Food = Food;
		}

		public void Eat()
		{
			Console.WriteLine($"Food : {Food}");
		}

        public override string ToString()
        {
            return $"Cat có {Legs} chân và ă {Food}";
        }n
    }
}

