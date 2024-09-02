namespace GeometricShapesLibrary
{
	public class Circle(double radius) : IShape
	{
		public double Radius { get; private set; } = radius;
		public double Area()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}

		public double Perimeter()
		{
			return 2 * Math.PI * Radius;
		}

		public override string ToString()
		{
			return $"Shape: {base.ToString()}; Radius: {Radius}; Area: {Area()}; Perimeter: {Perimeter()}";
		}
	}
}
