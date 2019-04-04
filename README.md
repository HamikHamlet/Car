# Car
## Program that tests the speed of the car and event preparation
This code checks speed and performs appropriate actions
```csharp
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
```
