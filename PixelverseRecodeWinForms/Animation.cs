using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms
{
	internal class Animation
	{
		public Image? CurrentImage { get => FrameIndex < Frames.Count ? Frames [FrameIndex].Image : Frames.Count > 0 ? Frames[0].Image : null; }
		
		private List<Frame> Frames;
		private int FrameIndex;

		public Animation()
		{
			Frames = new List<Frame>();
		}
	}

	internal struct Frame
	{
		public Image Image;
		public int DurationMS;
	}
}
