﻿using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Visualiser.Containers.Types
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PositionTextureNormalType
	{
		public Vector3 position;
		public Vector2 texture;
		public Vector3 normal;
	}
}
