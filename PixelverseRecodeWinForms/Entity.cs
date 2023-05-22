using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms
{
	internal class Entity
	{
		public int X, Y;
		/// <summary>
		/// The Padding of the Hitbox, (0,0,0,0) means the Hitbox is the entire Bounds area of the image.
		/// </summary>
		public Padding HitboxPadding;

		public Image EntityImage { get => CurrentAnimation.CurrentImage; }
		public Animation CurrentAnimation;
	}
}
