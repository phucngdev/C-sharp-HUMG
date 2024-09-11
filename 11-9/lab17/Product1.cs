using System;
namespace Sanpham 
{
	public partial  class Product
	{
		public string name { set; get; }
		public decimal price { set; get; }

		

		public string GetInfo()
		{
			return $"name: {name}, price: {price}, description: {description}";
		}
	}
}

