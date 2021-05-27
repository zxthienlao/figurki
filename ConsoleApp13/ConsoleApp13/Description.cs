using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Description
	{
		public double Side1;
		public double Side2;
		public double Side3;
		public double Side4;
		public double Height;
		public double Radius;
		public double Diagonal;


		public Description(double side1, double side2, double height, double radius, double diagonal, double side3, double side4)
		{
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
			Side4 = side4;
			Height = height;
			Radius = radius;
			Diagonal = diagonal;

		}
		internal virtual double square()
		{
			double c = Side1;
			double S = Math.Pow(c, 2);
			Console.WriteLine("Площадь квадрата равна: " + S);
			return S;
		}
		internal virtual void Perimetr()
		{
			double a = Side1;
			double b = Side2;
			double c = Side3;
			double d = Side4;
			double P = a + b + c + d;
			Console.WriteLine("Периметр квадрата равен: " + P);
		}
	}
}
