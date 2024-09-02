namespace ComplexNumberLibrary
{
	public class ComplexNumber(double real, double imaginary)
	{
		public double Real { get; private set; } = real;
		public double Imaginary { get; private set; } = imaginary;

		public static ComplexNumber operator + (ComplexNumber left, ComplexNumber right)
		{
			return new ComplexNumber((left.Real + right.Real), (left.Imaginary + right.Imaginary));
		}

		public static ComplexNumber operator - (ComplexNumber left, ComplexNumber right)
		{
			return new ComplexNumber((left.Real - right.Real), (left.Imaginary - right.Imaginary));
		}

		public static ComplexNumber operator * (ComplexNumber left, ComplexNumber right)
		{
			var temp = new ComplexNumber((left.Real * right.Real), (left.Real * right.Imaginary + left.Imaginary * right.Real));
			var lastMember = left.Imaginary * right.Imaginary;
			return new ComplexNumber((temp.Real + (-lastMember)), (temp.Imaginary));
		}

		public static ComplexNumber operator / (ComplexNumber left, ComplexNumber right)
		{
			var numerator = new ComplexNumber((left.Real * right.Real) + (left.Imaginary * right.Imaginary), (left.Real * (-right.Imaginary)) + (left.Imaginary * right.Real));
			var denominator = (right.Real * right.Real) + (right.Real * (-right.Imaginary)) + (right.Imaginary * right.Real) + (right.Imaginary * right.Imaginary);
			return new ComplexNumber((numerator.Real / denominator), (numerator.Imaginary / denominator));
		}

		public static bool operator != (ComplexNumber left, ComplexNumber right)
		{
			return left.Real != right.Real | left.Imaginary != right.Imaginary;
		}

		public static bool operator == (ComplexNumber left, ComplexNumber right)
		{
			return left.Real == right.Real && left.Imaginary == right.Imaginary;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}

		public new string ToString()
		{
			return $"{Real} + {Imaginary}i";
		}
	}
}
