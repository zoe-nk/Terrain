﻿namespace Visualiser.Containers
{
	public class MovementInput
	{
		public bool Forward { get; set; }
		public bool Backward { get; set; }
		public bool Upward { get; set; }
		public bool Downward { get; set; }
		public bool Leftward { get; set; }
		public bool Rightward { get; set; }

		public int LookDown { get; set; }
		public int LookRight { get; set; }

		public bool Jump { get; set; }
		public bool Sprint { get; set; }
	}
}
