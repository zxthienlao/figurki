using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangle a = new Triangle(2, 4, 3, 2, 2, 4, 0);
			Square b = new Square(3, 4, 3, 2, 3, 5, 6);
			parallelogram c = new parallelogram(5, 4, 5, 2, 2, 3, 2);
			a.square();
			a.Perimetr();
			Console.WriteLine("");
			b.square();
			b.Perimetr();
			Console.WriteLine("");
			c.square();
			c.Perimetr();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.ReadKey();
		}
	}
}
