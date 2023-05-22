using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelverseRecodeWinForms.Graphics
{
	internal abstract class Graphics
	{
		public const string subpath_resourcesDefault = "/resources/";
		public const string subpath_graphicsDefault = $"{subpath_resourcesDefault}graphics/";



		public static Image GetGraphic(string Filename, string subFolderPath = "")
		{
			string Filepath = GetGraphicResourcePath(Filename, subFolderPath);
			// make path and check existance
			//if (!File.Exists(Filepath)) return Image.FromHbitmap(new Bitmap(16, 16, System.Drawing.Imaging.PixelFormat.Alpha).GetHbitmap());
			// Error Fix by ChatGPT:
			if (!File.Exists(Filepath))
			{
				Bitmap defaultBitmap = new Bitmap(16, 16, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(defaultBitmap);
				graphics.Clear(Color.White);
				return defaultBitmap;
			}
			return Image.FromFile(Filepath);
		}


		/// <summary>
		/// Gets the path of a specified resource file.
		/// </summary>
		/// <param name="Filename">The name of the file, including the File type.</param>
		/// <param name="subFolderPath">The subfolder path inside the resources directory. </param>
		/// <returns>The filepath of the given file, regardless if the file exists or not. </returns>
		public static string GetGraphicResourcePath(string Filename, string subFolderPath)
		{
			// Fix Filename
			Filename = Filename.Trim();
			// Fix subFolder path
			subFolderPath = subFolderPath.Replace("\\", "/");
			if (subFolderPath.Length > 0 && !subFolderPath.EndsWith('/')) subFolderPath += '/';
			string folder = System.Environment.CurrentDirectory + subpath_graphicsDefault + $"{subFolderPath}";
			return folder + Filename;
		}


		/// <summary>
		/// Gets the path of a specified resource file.
		/// </summary>
		/// <param name="Filename">The name of the file, including the File type.</param>
		/// <param name="subFolderPath">The subfolder path inside the resources directory. </param>
		/// <returns>The filepath of the given file, regardless if the file exists or not. </returns>
		public static string GetResourcePath(string Filename, string subFolderPath)
		{
			// Fix Filename
			Filename = Filename.Trim();
			// Fix subFolder path
			subFolderPath = subFolderPath.Replace("\\", "/");
			if (subFolderPath.Length > 0 && !subFolderPath.EndsWith('/')) subFolderPath += '/';
			string folder = System.Environment.CurrentDirectory + subpath_resourcesDefault + $"{subFolderPath}";
			return folder + Filename;
		}


		/**
		 * 
		 * Was I high? (no just tired)
		 * 
		/// <summary>
		/// Gets a specified graphic / image.
		/// </summary>
		/// <param name="Filename">The name of the file. Need not include periods or the file format. </param>
		/// <param name="subFolderPath"> Optional: A given Subfolder, for example "materials". </param>
		/// <returns></returns>
		public static Image? GetGraphic(string Filename, string subFolderPath = "")
		{
			// Fix Filename
			Filename = Filename.Trim();
			if (Filename.Contains('.')) Filename = Filename.Substring(0, Filename.LastIndexOf('.'));
			// Fix subFolder path
			subFolderPath = subFolderPath.Replace("\\", "/");
			if (subFolderPath.Length > 0 && !subFolderPath.EndsWith('/')) subFolderPath += '/';
			// make path and check existance
			string folder = System.Environment.CurrentDirectory + subpath_graphicsDefault + $"{subFolderPath}";
			if (!Directory.Exists(folder)) return null;
			// Iterate through all files
			var Files = Directory.GetFiles(folder);
			foreach (string File in Files)
			{
				string _File = File.Contains('.') ? File.Substring(0, File.LastIndexOf('.')) : File;
				if (_File == Filename)
				{
					return Image.FromFile(File);
				}
			}
			return null;
		}

		/// <summary>
		/// Gets a specified resource from a given folder.
		/// </summary>
		/// <param name="Filename"> The name of the file, not including the file extension. </param>
		/// <param name="subFolderPath"> The path of additional folders inside the /resources/ directory. </param>
		/// <returns> Returns a nullable string that either contains the Filepath or is null. Might change to String.Empty instead of null in the future. </returns>
		public static string? GetResource(string Filename, string subFolderPath)
		{
			// Fix Filename
			Filename = Filename.Trim();
			if (Filename.Contains('.')) Filename = Filename.Substring(0, Filename.LastIndexOf('.'));
			// Fix subFolder path
			subFolderPath = subFolderPath.Replace("\\", "/");
			if (subFolderPath.Length > 0 && !subFolderPath.EndsWith('/')) subFolderPath += '/';
			// make path and check existance
			string folder = System.Environment.CurrentDirectory + subpath_graphicsDefault + $"{subFolderPath}";
			if (!Directory.Exists(folder)) return null;
			// Iterate through all files
			var Files = Directory.GetFiles(folder);
			foreach (string File in Files)
			{
				string _File = File.Contains('.') ? File.Substring(0, File.LastIndexOf('.')) : File;
				if (_File == Filename)
				{
					return File;
				}
			}
			return null;
		}
		*/
	}
}
