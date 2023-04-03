using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idkRpg
{
	internal class Monster
	{
		public int health;
		protected Random random = new Random();
		public Monster()
		{
			health = 500;
		}
		public void Attack(Character character)
		{
			int damage = random.Next(15,20);
			Console.WriteLine("Monster útočí na nás a způsobuje " + damage + " poškození.");
			character.TakeDamage(damage);
		}
		public void TakeDamage(int damage)
		{
			health -= damage;
			if (health <= 0)
			{
				Console.WriteLine("Monster byl poražen!");
			}
			else
			{
				Console.WriteLine("Monster ztrácí " + damage + " zdraví a zbývá mu " + health + " zdraví.");
			}
		}
	}
}
