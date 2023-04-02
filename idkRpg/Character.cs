using idkRpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace idkRpg
{
	interface IInventory
	{
		void AddItem(string name, ItemType type);
	}
	enum ItemType
	{
		Sword,
		Potion
	}
	internal class Character : IInventory
	{
		public int health;
		public int potionsLeft;
		public int swordUsesLeft;
		public bool hasSword;
		public Random random;
		public Character()
		{
			health = 100;
			potionsLeft = 0;
			swordUsesLeft = 0;
			hasSword = false;
		}
		public void AddItem(string name, ItemType type)
		{
			switch (type)
			{
				case ItemType.Sword:
					hasSword = true;
					swordUsesLeft = swordUsesLeft + 3;
					Console.WriteLine("Do inventáře byl přidán meč.");
					break;
				case ItemType.Potion:
					potionsLeft = potionsLeft + 2;
					Console.WriteLine("Do inventáře byla přidán potion.");
					break;
			}
		}
		public void Attack(Monster monster)
		{
			if (hasSword && swordUsesLeft > 0)
			{
				swordUsesLeft--;
				int damage = random.Next(30, 50);
				if (swordUsesLeft % 3 == 0)
				{
					damage = (int)Math.Floor((double)damage / 1.5);
					Console.WriteLine("Meč se opotřebil a jeho účinnost se snížila na " + damage + " damage.");
				}
				Console.WriteLine("Útočíme na monstra s mečem!");
				monster.TakeDamage(damage);
			}
			else
			{
				Console.WriteLine("Útočíme na monstra s pěstmi!");
				monster.TakeDamage(10);
			}
		}
		public void UsePotion()
		{
			if (potionsLeft > 0)
			{
				potionsLeft--;
				int healAmount = 25;
				if (potionsLeft % 2 == 0)
				{
					healAmount = (int)Math.Floor((double)healAmount / 1.5);
					Console.WriteLine("Léčivá koule se pokazila a její účinnost se snížila na " + healAmount + " healu.");
				}
				Console.WriteLine("Používáme léčivou kouli a získáváme " + healAmount + " zdraví.");
				health += healAmount;
			}
			else
			{
				Console.WriteLine("Nemáte žádné léčivé koule v inventáři!");
			}
		}
		public void TakeDamage(int damage)
		{
			health -= damage;
			if (health <= 0)
			{
				Console.WriteLine("Zemřeli jste!");
				return;
			}
			Console.WriteLine("Dostáváme " + damage + " poškození od monstra.");
		}

	}
}
