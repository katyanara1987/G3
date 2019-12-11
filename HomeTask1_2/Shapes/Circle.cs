using System;

public class Circle
{
	private double _radius;
	private double _area;

	public Circle(double radius)
	{
		Radius = radius;
		Area = GetArea();
	}

	public double Radius { 
		get 
		{ 
			return _radius; 
		}
		private set
		{
			_radius = value; 
		} 
	}

	public double Area {
		get 
		{
			return _area;
		}
		private set 
		{
			_area = value;
		}
	}
	private double GetArea()
	{
		return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
	}
}
