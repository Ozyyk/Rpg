using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idkRpg
{
	internal class Inventory
	{
		private List<Item> items;

		public Inventory()
		{
			items = new List<Item>();
		}

		public void AddItem(Item item)
		{
			items.Add(item);
		}

		public void RemoveItem(Item item)
		{
			items.Remove(item);
		}

		public List<Item> GetItems()
		{
			return items;
		}
	}
}
