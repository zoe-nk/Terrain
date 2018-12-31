﻿using Visualiser.Containers;
using Visualiser.Utilities;

using Math = System.Math;

namespace Visualiser.Graphics.Objects
{
	public class Player
	{
		private Velocity3D _velocity;
		private LookDirection2D _lookDirection;

		public Player()
		{
			_velocity = new Velocity3D();
			_lookDirection = new LookDirection2D();
		}

		public Coordinate3D<float> Position { get; set; }
		public Coordinate3D<float> Rotation { get; set; }

		public void Update(float frameTime, MovementInput input)
		{
			_velocity.Update(frameTime, input);
			_lookDirection.Update(frameTime, input);

			Rotation.X += _lookDirection.NetDown;
			Rotation.X = Rotation.X.Clamp(-90, 90);

			Rotation.Y += _lookDirection.NetRight;
			Rotation.Y = Rotation.Y.RotationLock();

			var radians = Rotation.Y * Constants.RadiansPerDegree;

			Position.X += (float)Math.Sin(radians) * _velocity.NetForward;
			Position.Y += _velocity.NetUpward;
			Position.Z += (float)Math.Cos(radians) * _velocity.NetForward;
		}
	}
}