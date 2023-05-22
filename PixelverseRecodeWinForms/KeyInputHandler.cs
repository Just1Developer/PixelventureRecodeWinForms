using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms
{
	internal interface IKeyInputHandler
	{
		// Methods return true if handled

		public bool OnKeyPressed(Keys key, int times);
		public bool OnKeyDown(Keys key);
		public bool OnKeyUp(Keys key);
		public bool OnMouseButtonClicked(MouseButtons Button, int times);
		public bool OnMouseButtonDown(MouseButtons Button);
		public bool OnMouseButtonUp(MouseButtons Button);
		/*
		public void KeyPressed(char c, int times)
		{

		}
		public void KeyDown(char c)
		{

		}
		public void KeyUp(char c)
		{

		}

		public void MouseButtonClicked(int Button, int times)
		{

		}
		public void MouseButtonDown(int Button)
		{

		}
		public void MouseButtonUp(int Button)
		{

		}
		*/
	}
}
