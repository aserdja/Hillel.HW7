namespace GeometricShapesLibrary
{
	public class Rectangle(double firstSideLength, double secondSideLength) : IShape
	{
		public double FirstSideLength { get; private set; } = firstSideLength;
		public double SecondSideLength { get; private set;} = secondSideLength;

		public double Area()
		{
			return FirstSideLength * SecondSideLength;
		}

		public double Perimeter()
		{
			return (FirstSideLength * 2) + (SecondSideLength * 2);
		}

		public override string ToString()
		{
			return $"Shape: {base.ToString()}; First side length: {FirstSideLength}; Second side length: {SecondSideLength}; " +
				$"Area: {Area()}; Perimeter: {Perimeter()}";
		}
	}
}
