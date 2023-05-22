namespace PixelverseRecodeWinForms
{
	public partial class ApplicationWindow : Form
	{
		public ApplicationWindow()
		{
			InitializeComponent();

			CurrentScene = new IngameScene
			{
				Dock = DockStyle.Fill
			};
			Controls.Add(CurrentScene);
		}

		internal Scene CurrentScene;

		private void Form1_Load(object sender, EventArgs e)
		{
			Logger.Log($"Resource Path: {System.Environment.CurrentDirectory}{Graphics.Graphics.subpath_resourcesDefault}");
			Logger.Log($"Graphics Path: {System.Environment.CurrentDirectory}{Graphics.Graphics.subpath_graphicsDefault}");
		}
	}

	public class Logger
	{
		public static void Log(string s)
		{
			if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debug.WriteLine($">> {s}");
			else Console.WriteLine($">> {s}");
		}
	}
}