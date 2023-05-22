using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelverseRecodeWinForms.Items;

namespace PixelverseRecodeWinForms
{
	internal class Player
	{
		public PlayerInventory Inventory;
	}

	internal class PlayerInventory : Inventory
	{
		private Dictionary<int, ItemStack> Hotbar;
		private int HotbarSize;
		public ItemStack Helmet;
		public ItemStack Chestplate;
		public ItemStack Leggings;
		public ItemStack Boots;

		public PlayerInventory(int InventorySize, int HorbarSize)
			: base(InventorySize)
		{

		}
	}
}
