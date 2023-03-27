using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idkRpg
{
	internal class Item
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Durability { get; set; }
		public DateTime ExpiryDate { get; set; }

		public Item(string name, string description, int durability, DateTime expiryDate)
		{
			Name = name;
			Description = description;
			Durability = durability;
			ExpiryDate = expiryDate;
		}
	}
}
