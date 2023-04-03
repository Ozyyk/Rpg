using idkRpg;
using System;

internal class Monster : BaseForMonster
{
	protected Random random = new Random();

	public Monster(int health, string name) : base(health, name)
	{
		HealthMonster = health;
		NameOfMonster = name;
	}

	public void Attack(Character character)
	{
		int damage = random.Next(15, 20);
		Console.WriteLine(NameOfMonster + " útočí na nás a způsobuje " + damage + " poškození.");
		character.TakeDamage(damage);
	}

	public void TakeDamage(int damage)
	{
		HealthMonster -= damage;
		if (HealthMonster <= 0)
		{
			Console.WriteLine(NameOfMonster + " byl poražen!");
		}
		else
		{
			Console.WriteLine(NameOfMonster + " ztrácí " + damage + " zdraví a zbývá mu " + HealthMonster + " zdraví.");
		}
	}
}