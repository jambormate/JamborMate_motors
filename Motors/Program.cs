namespace Motors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika statisztika = new Statisztika();
			statisztika.ReadFromFile("motors.txt");
            Console.WriteLine("Az összes motor ára összesen:" + statisztika.SumPrices());
            Console.WriteLine("Szerepel-e Andesean 320? " + statisztika.Contains("Andesean 320"));
			Console.WriteLine("Szerepel-e Himalayan 450? " + statisztika.Contains("Himalayan 450"));
            Console.WriteLine("Legrégebbi motor: " + statisztika.Oldest().ToString());
            Console.WriteLine("Yamaha motorok árának összege: " + statisztika.SumBasedOnBrand("Yamaha"));
			statisztika.Sort();
            Console.WriteLine("A motorok teljesítményük alapján sorba lettek rendezve.");
        }
	}
}
