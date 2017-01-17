using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete
{
	public class Manager
	{
		public bool Coca()
		{
			bool isCoca = false;

			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine("Coca");
					isCoca = true;			
				}
				else
				{
					Console.WriteLine(i);					
				}				
			}

			return isCoca;
		}

		public bool Cola()
		{
			bool isCola = false;

			for (int i = 1; i < 101; i++)
			{
				if (i % 5 == 0)
				{
					Console.WriteLine("Cola");
					isCola = true;
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return isCola;
		}

		public bool CocaCola()
		{
			bool isCocaCola = false;

			for (int i = 1; i < 101; i++)
			{
				if(i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("CocaCola");
					isCocaCola = true;
				}
				else
				{
					Console.WriteLine(i);
				}
			}

			return isCocaCola;
		}

		public string ShowAllDividableNumbers(int number)
		{
			if (number % 15 == 0)
				return "CocaCola";
			else if (number % 3 == 0)
				return "Coca";
			else if (number % 5 == 0)
				return "Cola";
			else
				return number.ToString();
		}

		public void LoopTroughAllNumbers()
		{
			int i = 1;

			while (i < 101)
			{
				Console.WriteLine(ShowAllDividableNumbers(i));
				i++;
			}
		}

	}
}
