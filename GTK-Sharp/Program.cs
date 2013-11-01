using System;
using Gtk;

namespace GTK_Sharp
{
	class Program
	{
		static void Main()
		{
			Application.Init();

			Button btn = new Button("Hello World");
			btn.Clicked += new EventHandler(Hello);

			Window window = new Window("Hello World");
			window.DeleteEvent += Delete_Event;

			window.Add(btn);
			window.ShowAll();

			Application.Run();
		}


		static void Delete_Event(object obj, DeleteEventArgs args)
		{
			Application.Quit();
		}

		static void Hello(object obj, EventArgs args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
