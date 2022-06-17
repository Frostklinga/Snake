using System;
using System.Windows.Input;

namespace Snake.PlayerControls
{
	public class Controls
	{
		public Controls()
		{

		}
		public void SetDirection(Direction direction)
		{
			CurrentDirection = direction;
		}
		public Direction GetDirection()
		{
			return CurrentDirection;
		}
		private Direction CurrentDirection { get; set; } = Direction.Right;

	}
}