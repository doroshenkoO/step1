using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	internal class Point3D
	{
		private int x;
		private int y;
		private int z;

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

		public int Z
		{
			get { return z; }
			set { z = value; }
		}

		public Point3D(int x, int y, int z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public override string ToString()
		{
			return String.Format("x = {0}, y = {1}, z = {2}.", this.X, this.Y, this.Z);
		}
	}
}