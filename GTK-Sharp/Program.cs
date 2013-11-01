using System;
using Gtk;

namespace GTK_Sharp
{
	class Program
	{
		static void Main()
		{
			Application.Init();

			Window window = new Window("Hello World");
			window.DeleteEvent += Delete_Event;

			Button btn = new Button("Hello World");
			btn.Clicked += new EventHandler(Hello);

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
