using System;
namespace Test
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Random r = new Random();
			int n, num;
			String isContinue;
			do
			{
				n = r.Next(1, 100);
				Console.WriteLine("Random number: "+ n);
				int d = n;
				int i = 0;
				for (i=0 ; i < 7; i++) {
					Console.Write("Enter number: ");
					num = Convert.ToInt32(Console.ReadLine());
					if (num == n){
						Console.WriteLine("You win!");
						break;
					}
					else if (num < n){
						Console.WriteLine("You input number smaller than random number");
					}
					else{
						Console.WriteLine("You input number larger than random number");
					}
				}
				if (i == 7) {
					Console.WriteLine("Game over!");
				}
				Console.WriteLine("Type 1 to continue...");
				isContinue = Console.ReadLine();
			} while (isContinue == "1");
		}
	}
}