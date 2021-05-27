using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class parallelogram : Description
	{
		public parallelogram(double side1, double side2, double height, double radius, double diagonal, double side3, double side4) :
			base(side1, side2, height, radius, diagonal, side3, side4)
		{
		}
		internal override double square()
		{
			double c = Side1;
			double h = Height;
			double S = c * h;
			Console.WriteLine("Площадь параллелограмма равна: " + S);
			return S;
		}
		internal override void Perimetr()
		{
			double a = Side1;
			double b = Side2;
			double c = Side3;
			double d = Side4;
			double P = a + b + c + d;
			Console.WriteLine("Периметр параллелограмма равен: " + P);
		}
	}
}
