namespace G15;

internal class SpeedController
{
	private int _currentSpeed;

	// Publishing event
	public event Action<int> SpeedExceed;

	public SpeedController()
	{
		MaxSpeed = Random.Shared.Next(200, 300);
	}

	public int MaxSpeed { get; private init; }

	public int CurrentSpeed
	{
		get
		{
			return _currentSpeed;
		}
		set
		{
			if (value > MaxSpeed)
			{
				if (SpeedExceed != null)
				{
					SpeedExceed(value - MaxSpeed);
				}
			}
			_currentSpeed = value;
		}
	}
}