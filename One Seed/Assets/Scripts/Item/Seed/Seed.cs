public class Seed : Item
{
	public Seed(int id, string name, DNA dna)
		: base(id, name)
	{
		DNA = dna;
	}

	public DNA DNA { get; set; }
}