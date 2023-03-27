using System;

namespace idkRpg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Inventory inventory = new Inventory();
			inventory.AddItem(new Item("Apple", "A juicy red apple", 1, DateTime.Now.AddDays(3)));
			inventory.AddItem(new Item("Sword", "A sharp steel sword", 100, DateTime.MaxValue));

			Console.WriteLine("Inventory items:");
			foreach (Item item in inventory.GetItems())
			{
				Console.WriteLine("{0} - {1}", item.Name, item.Description);
			}
		}
	}
}
