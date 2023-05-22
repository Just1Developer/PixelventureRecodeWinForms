using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms.Items
{
	internal struct ItemStack
	{

		#region Static and Const stuff

		public static ItemStack Empty { get; } = new ItemStack(Material.Air, 1, 0);

		public const int MaxStackSizeSwords = 1;
		public const int MaxStackSizeShields = MaxStackSizeSwords;
		public const int MaxStackSizeTools = MaxStackSizeSwords;
		public const int MaxStackSizeMaterial = 999;
		public const int MaxStackSizePotion = 9;
		public const int MaxStackSizeFood = 99;

		#endregion

		public Material Material { get; private set; }
		public int Amount { get; private set; }
		public int MaxStackSize { get; private set; }
		public ItemMeta ItemMeta { get; private set; }

		public ItemStack(Material Material, int Amount, int MaxStackSize)
		{
			this.Material = Material;
			this.Amount = Amount;
			this.ItemMeta = new ItemMeta();
			this.MaxStackSize = MaxStackSize >= 1 ? MaxStackSize : 1;
		}

		public bool Equals(ItemStack otherStack)
		{
			if(otherStack.Amount == this.Amount &&
				otherStack.Material == this.Material &&
				otherStack.ItemMeta == this.ItemMeta)
			{
				return true;
			}
			return false;
		}
	}

	internal class ItemMeta
	{
		// TODO Implement ItemMeta
		public int temp_property1, temp_property2;

		public bool Equals(ItemMeta otherMeta)
		{
			if (otherMeta.temp_property1 == this.temp_property1 &&
				otherMeta.temp_property2 == this.temp_property2)
			{
				return true;
			}
			return false;
		}
	}

	enum Material
	{
		Air,
		Sword_Wooden, Sword_Stone, Sword_Iron, Sword_Diamond,
		Shield_Wooden, Shield_Stone, Shield_Iron, Shield_Diamond,
		Potion_Heal,
	}
}


/*
public static bool operator ==(ItemMeta? otherMeta)
{
	return false;
}
public static bool operator !=(ItemMeta? otherMeta)
{
	return !(this == otherMeta);
}
*/