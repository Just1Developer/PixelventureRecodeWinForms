using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelverseRecodeWinForms.Subrenderer;

namespace PixelverseRecodeWinForms
{
	internal class IngameScene : Scene
	{
		// Might Change this later to account for multiple players or something
		Player MainPlayer;

		public IngameScene() : base()
		{
			DebugConstructorVoid();
			MainPlayer = new Player();
			InputHandlerPriorityQueue.Add(new InventoryRenderer(MainPlayer));
		}

		private void DebugConstructorVoid()
		{
			BackColor = Color.DarkBlue;
		}
	}
}
