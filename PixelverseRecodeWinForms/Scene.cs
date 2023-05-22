using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms
{
	internal abstract class Scene : Label, IKeyInputHandler
	{

		#region Input Handling

		protected List<IKeyInputHandler> InputHandlerPriorityQueue;

		// If the list is modified in any way during an event, a sort of ConcurrentModificationException
		// should not occur since the method returns immediately after without another loop cycle.
		// This could also be false depending on how C# handles this internally.

		public bool OnKeyPressed(Keys key, int times)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnKeyPressed(key, times)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}
		public bool OnKeyDown(Keys key)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnKeyDown(key)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}
		public bool OnKeyUp(Keys key)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnKeyUp(key)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}

		public bool OnMouseButtonClicked(MouseButtons button, int times)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnMouseButtonClicked(button, times)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}
		public bool OnMouseButtonDown(MouseButtons button)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnMouseButtonDown(button)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}
		public bool OnMouseButtonUp(MouseButtons button)
		{
			foreach (var keyInputHandler in InputHandlerPriorityQueue)
			{
				if (keyInputHandler.OnMouseButtonUp(button)) return true;
			}
			// Not handled by any inputhandler, so handle it ourselves
			// ToDo Handle event
			return true;
		}

		#endregion

		public Scene()
		{
			InputHandlerPriorityQueue = new List<IKeyInputHandler>();
			//this.OnKeyPre += (s, e) => OnMouseButtonClicked(e.Button, e.Clicks);
			this.MouseDown += (s, e) => OnMouseButtonDown(e.Button);
			this.MouseUp += (s, e) => OnMouseButtonUp(e.Button);

			this.MouseClick += (s, e) => OnMouseButtonClicked(e.Button, e.Clicks);
			this.MouseDown += (s, e) => OnMouseButtonDown(e.Button);
			this.MouseUp += (s, e) => OnMouseButtonUp(e.Button);
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			// Debug
			Logger.Log("Hello World!");
			OnKeyPressed(Keys.Select, 0);
			e.Handled = true;
		}

	}
}

/**
 
 Default Implementation Code:

		#region ToDo: Input Handling

		public bool OnKeyPressed(Keys key, int times)
		{
			// ToDo Handle event
			return false;
		}
		public bool OnKeyDown(Keys key)
		{
			// ToDo Handle event
			return false;
		}
		public bool OnKeyUp(Keys key)
		{
			// ToDo Handle event
			return false;
		}

		public bool OnMouseButtonClicked(MouseButtons button, int times)
		{
			// ToDo Handle event
			return false;
		}
		public bool OnMouseButtonDown(MouseButtons button)
		{
			// ToDo Handle event
			return false;
		}
		public bool OnMouseButtonUp(MouseButtons button)
		{
			// ToDo Handle event
			return false;
		}

		#endregion
 
 */