using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory = PixelverseRecodeWinForms.Items.Inventory;

namespace PixelverseRecodeWinForms.Subrenderer
{
	internal class InventoryRenderer : Panel, IKeyInputHandler
	{
		public Inventory ReferenceInventory { get; private set; }
		public InventoryVisualConfig InventoryVisualConfig { get; private set; }
		public PictureBox Visual_Background { get; private set; }

		public InventoryRenderer(Player InventoryPlayer) : this(InventoryPlayer.Inventory, new InventoryVisualConfig() { }) { }
		public InventoryRenderer(Player InventoryPlayer, InventoryVisualConfig InventoryVisualConfig) : this(InventoryPlayer.Inventory, InventoryVisualConfig) { }
		public InventoryRenderer(Inventory Inventory) : this(Inventory, new InventoryVisualConfig()) { }
		public InventoryRenderer(Inventory Inventory, InventoryVisualConfig InventoryVisualConfig)
		{
			this.ReferenceInventory = Inventory;
			this.InventoryVisualConfig = InventoryVisualConfig;
			Visual_Background = new PictureBox();
			Visual_Background.Image = Graphics.InventoryGraphics.GetInventoryGraphc("InventoryBackground1");
			Visual_Background.Dock = DockStyle.Fill;
			Visual_Background.SizeMode = PictureBoxSizeMode.Zoom;
			Controls.Add(Visual_Background);
			this.BackColor = Color.Transparent;
			this.Visible = false;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			// Now, draw all the item images in their respective slots
		}


		#region ToDo: Input Handling

		public bool OnKeyPressed(Keys key, int times)
		{
			// ToDo Handle event
			if(key == KeyBinds.OpenInventory && !Visible)
			{
				// Open the Inventory
				Visible = true;
				return true;
			}
			if(key == KeyBinds.CloseInventory && Visible)
			{
				// Close the Inventory
				Visible = false;
				return true;
			}
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

	}

	struct InventoryVisualConfig
	{
		public Point Location;
		public Size Size;
		public int SlotSize, SlotSpacing;
		public Point RelativeFirstSlotLocation;
		public int SlotsPerRow;

		public InventoryVisualConfig() : this(new Point(0,0), new Size(300, 100), 25, 10, 5) { }
		public InventoryVisualConfig(
			Point Location,
			Size Size,
			int SlotSize,
			int SlotsPerRow,
			int SlotSpacing = -1
			) : this(Location, Size, SlotSize, SlotsPerRow, new Point(0, 0), SlotSpacing)
		{
		}
		public InventoryVisualConfig(
			Point Location,
			Size Size,
			int SlotSize,
			int SlotsPerRow,
			Point RelativeFirstSlotLocation,
			int SlotSpacing = -1
			)
		{
			this.Location = Location;
			this.Size = Size;
			this.SlotSize = SlotSize;
			this.SlotsPerRow = SlotsPerRow;
			this.RelativeFirstSlotLocation = RelativeFirstSlotLocation;
			this.SlotSpacing = SlotSpacing == -1 ? SlotSize / 5 : SlotSpacing;
		}
	}
}
