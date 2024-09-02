using ComplexNumberLibrary;
using GeometricShapesLibrary;

var temp = new ComplexNumber(3, 4);
var temp2 = new ComplexNumber(1, 2);
var temp3 = temp + temp2;
Console.WriteLine($"{temp3.Real} + {temp3.Imaginary}i");
temp3 = temp - temp2;
Console.WriteLine($"{temp3.Real} + {temp3.Imaginary}i");
temp3 = temp * temp2;
Console.WriteLine($"{temp3.Real} + {temp3.Imaginary}i");
temp3 = temp / temp2;
Console.WriteLine($"{temp3.Real} + {temp3.Imaginary}i");

Console.WriteLine(temp == temp2);
Console.WriteLine(temp != temp2);
temp = new ComplexNumber(3, 4);
temp2 = new ComplexNumber(1, 2);
Console.WriteLine(temp == temp2);
Console.WriteLine(temp != temp2);
temp = new ComplexNumber(3, 4);
temp2 = new ComplexNumber(3, 2);
Console.WriteLine(temp == temp2);
Console.WriteLine(temp != temp2);
temp = new ComplexNumber(3, 5);
temp2 = new ComplexNumber(2, 5);
Console.WriteLine(temp == temp2);
Console.WriteLine(temp != temp2);
temp = new ComplexNumber(3, 5);
temp2 = new ComplexNumber(3, 5);
Console.WriteLine(temp == temp2);
Console.WriteLine(temp != temp2);

Console.WriteLine(temp.Equals(temp2));
Console.WriteLine(temp2.GetHashCode());

var circle = new Circle(10);
Console.WriteLine(circle.Area());
Console.WriteLine(circle.Perimeter());
Console.WriteLine(circle.ToString());

var rectangle = new Rectangle(10, 15);
Console.WriteLine(rectangle.Area());
Console.WriteLine(rectangle.Perimeter());
Console.WriteLine(rectangle.ToString());

var triangle = new Triangle(5, 12, 15);
Console.WriteLine(triangle.Area());
Console.WriteLine(triangle.Perimeter());
Console.WriteLine(triangle.ToString());