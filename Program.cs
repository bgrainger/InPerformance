using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace InPerformance
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Test>();
		}
	}

	public class Test
	{
		// 25.1ns
		[Benchmark]
		public double PointByValue()
		{
			double Distance(Point3D a, Point3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new Point3D(1, 1, 1);
			var p2 = new Point3D(2, 2, 2);
			return Distance(p1, p2);
		}

		// 21.8ns
		[Benchmark]
		public double PointByRef()
		{
			double Distance(ref Point3D a, ref Point3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new Point3D(1, 1, 1);
			var p2 = new Point3D(2, 2, 2);
			return Distance(ref p1, ref p2);
		}

		// 34.6ns
		[Benchmark]
		public double PointByIn()
		{
			double Distance(in Point3D a, in Point3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new Point3D(1, 1, 1);
			var p2 = new Point3D(2, 2, 2);
			return Distance(in p1, in p2);
		}

		// 25.3ns
		[Benchmark]
		public double ReadOnlyPointByValue()
		{
			double Distance(ReadOnlyPoint3D a, ReadOnlyPoint3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new ReadOnlyPoint3D(1, 1, 1);
			var p2 = new ReadOnlyPoint3D(2, 2, 2);
			return Distance(p1, p2);
		}

		// 21.8ns
		[Benchmark]
		public double ReadOnlyPointByRef()
		{
			double Distance(ref ReadOnlyPoint3D a, ref ReadOnlyPoint3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new ReadOnlyPoint3D(1, 1, 1);
			var p2 = new ReadOnlyPoint3D(2, 2, 2);
			return Distance(ref p1, ref p2);
		}

		// 21.8ns
		[Benchmark]
		public double ReadOnlyPointByIn()
		{
			double Distance(in ReadOnlyPoint3D a, in ReadOnlyPoint3D b)
			{
				var x = a.X - b.X;
				var y = a.Y - b.Y;
				var z = a.Z - b.Z;
				return Math.Sqrt(x * x + y * y + z * z);
			}

			var p1 = new ReadOnlyPoint3D(1, 1, 1);
			var p2 = new ReadOnlyPoint3D(2, 2, 2);
			return Distance(in p1, in p2);
		}
	}
}
