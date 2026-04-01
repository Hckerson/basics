using System.Runtime.Serialization;
using Point = (double X, double Y);

namespace MyApp.Geometry;

class Shape
{
	public static double Distance(Point p1, Point p2)
	{
		var dx = p2.X - p1.X;
		var dy = p2.Y - p1.Y;
		return Math.Sqrt(dx * dx + dy * dy);
	}
}
