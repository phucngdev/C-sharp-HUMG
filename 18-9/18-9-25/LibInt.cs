using System;

namespace LibInt
{
	public static class Lib
	{
		public static int Pow(this int x)
		{
			return x * x;
		}

		public static int Sqrt(this int x)
		{
			return (int)Math.Sqrt(x);
		}
	}
}

