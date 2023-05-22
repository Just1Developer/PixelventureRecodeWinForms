using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms.Items
{
	internal partial class Inventory
	{
		public int InventorySize { get; }
		// 0-based indexing
		private Dictionary<int, ItemStack> Contents = new Dictionary<int, ItemStack>();
		public bool IsFull { get => Contents.Count >= InventorySize; }

		public ItemStack GetItem(int Slot)
		{
			if(!Contents.ContainsKey(Slot)) return ItemStack.Empty;
			return Contents[Slot];
		}

		/// <summary>
		/// Adds an item into a new free slot. <br/>
		/// Returns true if the Item was added, false if the inventory is full;
		/// </summary>
		/// <returns> True if Item was added, false if not. </returns>
		public bool AddItemIntoNewSlot(ItemStack Stack)
		{
			if (IsFull) return false;
			for(int Slot = 0; Slot < InventorySize; ++Slot)
			{
				if (!Contents.ContainsKey(Slot))
				{
					Contents.Add(Slot, ItemStack.Empty);
					return true;
				}
			}
			return false;
		}

		public Inventory(int InventorySize)
		{
			this.InventorySize = InventorySize;
		}
	}
}
