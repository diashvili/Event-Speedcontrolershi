using G15;

namespace BMW;

internal class M5
{
	public const int MaxSpeed = 320;

	private readonly SpeedController _speedController;

	public M5()
	{
		_speedController = new SpeedController();
		// Subscribing event
		//_speedController.SpeedExceed += Alarm;
		_speedController.SpeedExceed += x => Console.WriteLine($"Please, slow down by {x}");
	}

	public string Model => "BMW M5";
	public int CurrentSpeed { get; private set; }

	public void Accelerate(int kmh)
	{
		if (CurrentSpeed + kmh < MaxSpeed && CurrentSpeed + kmh >= 0)
		{
			CurrentSpeed += kmh;
		}
		else if(CurrentSpeed + kmh <= 0)
        {
			CurrentSpeed = 0;
        }
		else
		{
			CurrentSpeed = MaxSpeed;
		}

		_speedController.CurrentSpeed = this.CurrentSpeed;

		Console.WriteLine($"{Model} Current Speed Is {CurrentSpeed}");
	}

	private void Alarm(int x)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"Your Speed Is To High! Over Speed Is: {x}");
		Console.ResetColor();
		// Unsubscribing event
		_speedController.SpeedExceed -= Alarm;

	}
}