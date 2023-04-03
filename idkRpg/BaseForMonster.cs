internal class BaseForMonster
{
	public int HealthMonster { get; set; }
	public string NameOfMonster { get; set; }

	public BaseForMonster(int health, string name)
	{
		HealthMonster = health;
		NameOfMonster = name;
	}
}