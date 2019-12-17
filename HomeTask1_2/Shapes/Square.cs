using System;

public class Square
{
	private double _side;
	private double _area;
	private double _diagonal;
	public Square(double side)
	{
		_side = side;
		_area = GetArea();
		_diagonal = GetDiagonal();
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
	public double Diagonal
	{
		get
		{
			return _diagonal;
		}
		private set
		{
			_diagonal = value;
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
	private double GetDiagonal()
	{
		return Math.Round(_side * Math.Sqrt(2), 2);
	}
}
