using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete
{
	public class Runtime
	{
		public void MainMenu()
		{
			bool isRunning = true;

			Manager manager = new Manager();
			GUI gui = new GUI();

			while (isRunning)
			{
				gui.MainMenuGUI();
				ConsoleKey input = Console.ReadKey(true).Key;

				switch (input)
				{
					case ConsoleKey.D1:
						Console.Clear();
						manager.Coca();
						Console.ReadKey(true);
						break;
					case ConsoleKey.D2:
						Console.Clear();
						manager.Cola();
						Console.ReadKey(true);
						break;
					case ConsoleKey.D3:
						Console.Clear();
						manager.CocaCola();
						Console.ReadKey(true);
						break;
					case ConsoleKey.D4:
						Console.Clear();
						manager.LoopTroughAllNumbers();
						Console.ReadKey(true);
						break;
					case ConsoleKey.D5:
						isRunning = false;
						break;
				}
			}
		}
	}
}
