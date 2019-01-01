﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Visualiser.Containers.Types
{
	[StructLayout(LayoutKind.Sequential)]
	public struct XYZTextureType
	{
		public float x;
		public float y;
		public float z;
		public float tu;
		public float tv;
	}
}
