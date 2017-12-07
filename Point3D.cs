namespace InPerformance
{
	public struct Point3D
	{
		public Point3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;

			padding1 = 1;
			padding2 = 2;
			padding3 = 3;
			padding4 = 4;
		}

		public double X { get; }
		public double Y { get; }
		public double Z { get; }

		readonly long padding1;
		readonly long padding2;
		readonly long padding3;
		readonly long padding4;
	}
}
