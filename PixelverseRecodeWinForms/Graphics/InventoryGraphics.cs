using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms.Graphics
{
	internal abstract class InventoryGraphics : Graphics
	{
		public static Image GetInventoryGraphc(string Filename) => GetGraphic(Filename, "Inventory");
		public static Image GetMaterialGraphc(string Filename) => GetGraphic(Filename, "Material");
	}
}
