using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
	public class Car : EventArgs
	{
		public Random r = new Random();
		public string SityName { get; set; }
		public int NormSpeed { get; set; }
		public int MaxSpeed { get; set; }
		public int MinSpeed { get; set; }
		public int NowSpeed { get; set; }
		public event EventHandler NormalSpeed;
		public event EventHandler MaxNormalSpeed;
		public event EventHandler OnMaxSpeed;
		public event EventHandler MinNormalSpeed;
		public Car()
		{
			SityName = "Tokyo";
			NormSpeed = 100;
			MinSpeed = 10;
			MaxSpeed = 200;
		}

		public Car(string sityName, int nowSpeed, int maxSpeed, int minspeed)
		{
			SityName = sityName;
			NormSpeed = nowSpeed;
			MaxSpeed = maxSpeed;
			MinSpeed = minspeed;
		}

		public void ContorlSpeed(int speed)
		{
			NowSpeed = speed;

			if (NowSpeed >= NormSpeed && NowSpeed < MaxSpeed)
			{
				OnMaxSpeed?.Invoke(this, new EventArgs());

			}
			else if (NowSpeed > MaxSpeed)
			{
				MaxNormalSpeed?.Invoke(this, new EventArgs());
			}
			else if (NowSpeed < MinSpeed)
			{
				MinNormalSpeed?.Invoke(this, new EventArgs());
			}
			else if (NowSpeed < NormSpeed && NowSpeed > MinSpeed)
			{
				NormalSpeed?.Invoke(this, new EventArgs());
			}



		}
	}
}
