using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
	class Program
	{
		public static Random r = new Random();
		static void Main(string[] args)
		{
			Car mycar = new Car();
			mycar.MaxNormalSpeed += C_MaxNormalSpeed;
			mycar.MinNormalSpeed += C_MinNormalSpeed;
			mycar.NormalSpeed += C_NormalSpeed;
			mycar.OnMaxSpeed += C_OnMaxSpeed;
			int temp = 0;
			while (true)
			{

				temp += r.Next(1, 30);
				Thread.Sleep(500);
				mycar.ContorlSpeed(temp);
			}
		}

		private static void C_OnMaxSpeed(object sender, EventArgs e)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			if (sender is Car)
			{
				Car car = sender as Car;
				Console.WriteLine("Ssenc ete sharunakes kxpes avtot qo aragujtun@ {0}  maximum aragutjun@ {1}", car.NowSpeed, car.MaxSpeed);
			}
		}

		private static void C_NormalSpeed(object sender, EventArgs e)
		{

			Console.ForegroundColor = ConsoleColor.Green;
			if (sender is Car)
			{
				Car car = sender as Car;
				Console.WriteLine("Apres normala ssenc sharunaki qo aragutjun {0} maximal aragutjun@ {1}", car.NowSpeed, car.MaxSpeed);
			}
		}

		private static void C_MinNormalSpeed(object sender, EventArgs e)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Shat dandax es qshum miqich aragacra");
			if (sender is Car)
			{
				Car car = sender as Car;
				int temp = r.Next(car.MinSpeed, car.NormSpeed);
				car.NormSpeed += temp;
				Console.WriteLine("Dzer aragutjun@  {0} er  ajm avelacel e {1} ev kazmum e {2}", car.NowSpeed - temp, temp, car.NowSpeed);
			}
		}

		private static void C_MaxNormalSpeed(object sender, EventArgs e)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Duq gerazanceleq tujlatrvum aragujtun@ petq e dadaxacneq");
			if (sender is Car)
			{
				Car car = sender as Car;
				int temp = r.Next(-100, -10);
				car.NowSpeed += temp;
				Console.WriteLine("Dzer aragutjun@  {0} er  ajm ijecvel e {1} ev kazmum e {2}", car.NowSpeed + Math.Abs(temp), temp, car.NowSpeed);
			}
		}
	}
}
