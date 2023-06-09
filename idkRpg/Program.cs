﻿using System;
using System.Globalization;
using System.Threading;
namespace idkRpg
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Vítejte v RPG hře!");
			Character character = new Character();
			Monster monster = new Monster(500, "DracekMracek");
			while (true)
			{
				Console.WriteLine("─────────────────────────────────");
				Console.WriteLine("Vaše zdraví: " + character.health);
				Console.WriteLine("Počet potionu: " + character.potionsLeft);
				Console.WriteLine("Počet zbývajících použití meče: " + character.swordUsesLeft);

				Console.WriteLine("Co chcete udělat?");
				Console.WriteLine("1. Útok na monstra");
				Console.WriteLine("2. Použití potion");
				Console.WriteLine("3. Přidání itemu do inventáře");
				string input = Console.ReadLine();
				switch (input)
				{
					case "1":
						character.Attack(monster);
						if (monster.HealthMonster <= 0)
						{
							break;
						}
						monster.Attack(character);
						break;
					case "2":
						character.UsePotion();
						monster.Attack(character);
						break;
					case "3":
						Console.WriteLine("Zadej jmeno sveho itemu");
						string name = Console.ReadLine();
						Console.WriteLine("Chcete přidat sword nebo potion?");
						string output = Console.ReadLine().Trim().ToLower();
						switch (output)
						{
							case "sword":
								character.AddItem(name, ItemType.Sword); break;
							case "potion":
								character.AddItem(name, ItemType.Potion); break;
						}
						break;
				}
				if (monster.HealthMonster <= 0)
				{
					Console.WriteLine("Konec hry");
					Console.ReadLine();
					Console.Clear();
				}
				Console.ReadKey();
				Console.Clear();
			}
		}


	}


}
