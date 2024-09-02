namespace GeometricShapesLibrary
{
	public class Triangle(double firstSideLength, double secondSideLength, double thirdSideLength) : IShape
	{
		public double FirstSideLength { get; private set; } = firstSideLength;
		public double SecondSideLength { get; private set; } = secondSideLength;
		public double ThirdSideLegth { get; private set; } = thirdSideLength;

		public double Area()
		{
			var p = Perimeter() / 2;
			return Math.Sqrt(p * (p - FirstSideLength) * (p - SecondSideLength) * (p - ThirdSideLegth));
		}

		public double Perimeter()
		{
			return FirstSideLength + SecondSideLength + ThirdSideLegth;
		}

		public override string ToString()
		{
			return $"Shape: {base.ToString()}; First side length: {FirstSideLength}; Second side length: {SecondSideLength}; " +
				$"Third side length: {SecondSideLength}; Area: {Area()}; Perimeter: {Perimeter()}";
		}
	}
}
