using System;

public class Square
{
	private double _side;
	private double _area;
	public Square(double side)
	{
		_side = side;
		_area = GetArea();
	}

	public double Side {
		get
		{
			return _side;
		}
		private set
		{
			_side = value; 
		}
	}

	public double Area {
		get 
		{
			return _area;
		}
		set 
		{
			_area = value;
		}
	}
	
	private double GetArea()
	{
		return Math.Round(Math.Pow(_side, 2), 2);
	}
}
